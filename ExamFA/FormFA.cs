using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Configuration;
using System.Collections.Specialized;

using XDICTGRB;
using log4net;

namespace ExamFA
{
    public partial class FormFA : Form, IXDictGrabSink 
    {
        public FormFA()
        {
            InitializeComponent();
        }

        ILog HelperLog = log4net.LogManager.GetLogger(typeof(Program));
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern int SetWindowPos(    //窗口永远置前
            IntPtr hwnd,
            int hWndInsertAfter,
            int x,
            int y,
            int cx,
            int cy,
            int wFlags
        );
       

        //接口的实现 
        int IXDictGrabSink.QueryWord(string WordString, int lCursorX, int lCursorY, string SentenceString, ref int lLoc, ref int lStart)
        {
            this.RTB_topic.Text = SentenceString;//鼠标所在语句 
            //this.RTB_answer.Text = SentenceString;
            return 1;
        }

        private void FormFA_Load(object sender, EventArgs e)
        {

            SetWindowPos(this.Handle, -1, Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2, this.Width, this.Height, 0);
            GrabProxy gp = new GrabProxy();

            gp.GrabInterval = 1;//指抓取时间间隔 
            gp.GrabMode = XDictGrabModeEnum.XDictGrabMouse;//设定取词的属性 
            //gp.GrabFlag = XDictGrabFlagEnum.XDictGrabOnlyEnglish;//只取英文
            gp.GrabEnabled = true;//是否取词的属性 
            gp.AdviseGrab(this);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            HelperLog.Info("Start");
            HelperLog.Info("End");
        }

        private void RTB_topic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //DoFindAnswer
                //MessageBox.Show(this.RTB_topic.Text.Trim());
                string connectionString = "";
                       connectionString = ConfigurationManager.AppSettings["DBConStrPostgres"];
        
                DbUtility db = new DbUtility(connectionString, DbProviderType.PostgreSql);
                StringBuilder sql = new StringBuilder();
               // sql.Append("select 1+1 ");
                String mysql = "select now() ";
                sql.Append("select title as 题目, option as 选项,answer as 答案 from t_app_question_bank where title like '%");
                sql.Append(RTB_topic.Text.Trim());
                sql.Append("%'");
                mysql = sql.ToString();
               // MessageBox.Show(mysql);                
                HelperLog.Info(this.RTB_topic.Text.Trim());
                HelperLog.Info(mysql);
                object res = db.ExecuteScalar(mysql, null, CommandType.Text);
                DataTable dt = db.ExecuteDataTable(mysql, null, CommandType.Text);
                DGV.DataSource = dt;
                
                DGV.Columns[0].FillWeight = 150;
                DGV.Columns[1].FillWeight = 100;
                DGV.Columns[2].FillWeight = 80;
                //DGV.DefaultCellStyle(); 
                //HelperLog.Info(dt.Rows.Count); 
                //this.RTB_answer.Text = res.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); HelperLog.Error(ex.Message); }
        }
    }
}
