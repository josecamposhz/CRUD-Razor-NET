using System;
using Npgsql;

namespace data01.Data
{
    public class DBTask
    {
        public long task_id = -1;
        public string taskname = "Default Task";
        public string supervisor = "José Campos";
        public string email_supervisor = "jcampos@supervisor.cl";
        public string responsible = "Responsible";
        public string email_responsible = "email@responsible.cl";
        public string created_on = "";
        public DateTime deadline = DateTime.Now;
        public string first_delivering = "";
        public string first_revising = "";
        public int estimate_hours = 2;
        public int effective_hours = -1;
        public string status { get; set; } = "Running";
        public bool set_from_reader(NpgsqlDataReader r)
        {
            if (r.IsOnRow)
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    string fname = r.GetName(i);
                    if (fname == "task_id")
                        this.task_id = r.GetInt64(i);
                    if (fname == "taskname")
                        this.taskname = r.GetString(i);
                    if (fname == "supervisor")
                        this.supervisor = r.GetString(i);
                    if (fname == "email_supervisor")
                        this.email_supervisor = r.GetString(i);
                    if (fname == "responsible")
                        this.responsible = r.GetString(i);
                    if (fname == "email_responsible")
                        this.email_responsible = r.GetString(i);
                    if (fname == "deadline")
                    {
                        this.deadline = Convert.ToDateTime(r.GetTimeStamp(i).ToString());
                    }
                }
                return true;
            }
            return false;
        }
    }
}