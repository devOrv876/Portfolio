using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CVDBConnect
    {
        static string conString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Orville\\Documents\\Visual Studio 2015\\Projects\\WebApplication4\\WebApplication4\\App_Data\\CVDB.mdf;Integrated Security = True");

        public string GetPS(string command)
        {
            //CVULTRACLASS.PersonalStatment ps = new CVULTRACLASS.PersonalStatment();
            string personalStatment = "";

            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                //string queryString = "Select * FROM personalstatment WHERE ID = @0";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.Add(new SqlParameter("0", 1));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personalStatment = reader.GetString(1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            string pstatementstring = "";
            return (pstatementstring);
        }


        public class QualifcationList
        {
            public string qualifcation { get; set; }
            public string Module { get; set; }
            public string ModuleDetail { get; set; }
            public string Grade { get; set; }
            public int EduLevel_ID { get; set; }
            public int Inst_ID { get; set; }

        }

        public QualifcationList GetEducation(string command)
        {
            QualifcationList EduList = new QualifcationList();
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                //string queryString = "Select * FROM personalstatment WHERE ID = @0";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.Add(new SqlParameter("0", 1));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EduList.qualifcation = reader.GetString(1);
                        EduList.Module = reader.GetString(2);
                        EduList.ModuleDetail = reader.GetString(3);
                        EduList.Grade = reader.GetString(4);
                        EduList.EduLevel_ID = reader.GetInt32(5);
                        EduList.Inst_ID = reader.GetInt32(6);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" ERROR MESSAGE -" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return (EduList);
        }



    }
}