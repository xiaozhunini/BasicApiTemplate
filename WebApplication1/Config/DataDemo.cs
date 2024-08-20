using MyWeb.Modles;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Config
{
    public class DataDemo
    {
        public void DataDemoText()
        {
            #region  第一种连接方式
            //string str = "Server = localhost; Database =myweb ; uid = sa; pwd = admin123; Trusted_Connection = False;";
            ////连接数据库
            //SqlConnection sqlConnection = new SqlConnection(str) ;
            ////执行sql语句
            //SqlCommand cmd = new SqlCommand("select * from db_user", sqlConnection) ;
            //try
            //{
            //    sqlConnection.Open();
            //    //Console.WriteLine(cmd.ExecuteNonQuery());

            //    SqlDataReader sqlDataReader = cmd.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        Console.WriteLine(sqlDataReader.GetString(2));
            //    }



            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    sqlConnection.Close();
            //}
            #endregion
            #region
            string str = "Server = localhost; Database =myweb ; uid = sa; pwd = admin123; Trusted_Connection = False;";
            //连接数据库
            SqlConnection sqlConnection = new SqlConnection(str);
            //执行sql语句
            SqlDataAdapter adapter = new SqlDataAdapter("select * from db_user", sqlConnection);  
            try
            {
                sqlConnection.Open();
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataTable dataTable in dataSet.Tables)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            Console.Write(row[i] + "\t");
                        }
                        Console.WriteLine();
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                sqlConnection.Close();
            }
            #endregion


        }
    }
}
