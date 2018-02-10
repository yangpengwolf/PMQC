- Table: public.t_app_question_bank

-- DROP TABLE public.t_app_question_bank;

CREATE TABLE public.t_app_question_bank
(
  id character varying(100),--pk
  knowledge character varying(100), 
  btype character varying(100),
  ktype character varying(100),
  title text,
  option text,
  answer text,
  memo character varying(100),
  flag character varying(100)
)
WITH (
  OIDS=FALSE
);
