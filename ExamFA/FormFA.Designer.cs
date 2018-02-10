namespace ExamFA
{
    partial class FormFA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.RTB_topic = new System.Windows.Forms.RichTextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(765, 10);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = " Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Visible = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // RTB_topic
            // 
            this.RTB_topic.Location = new System.Drawing.Point(23, 12);
            this.RTB_topic.Name = "RTB_topic";
            this.RTB_topic.Size = new System.Drawing.Size(696, 50);
            this.RTB_topic.TabIndex = 4;
            this.RTB_topic.Text = "YangPeng@2018";
            this.RTB_topic.TextChanged += new System.EventHandler(this.RTB_topic_TextChanged);
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(23, 90);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(795, 150);
            this.DGV.TabIndex = 5;
            // 
            // FormFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 266);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.RTB_topic);
            this.Controls.Add(this.btn_start);
            this.Name = "FormFA";
            this.Text = "FA";
            this.Load += new System.EventHandler(this.FormFA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RichTextBox RTB_topic;
        private System.Windows.Forms.DataGridView DGV;
    }
}

