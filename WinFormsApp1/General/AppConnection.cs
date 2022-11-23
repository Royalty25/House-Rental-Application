using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1.General
{
    public class AppConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MicrosoftSql"].ConnectionString;
        }
        public static SqlCommand RunCommand(string sql)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicrosoftSql"].ConnectionString);
            con.Open();
            SqlCommand cmd = new(sql, con);
            return cmd;
        }
        public static void InitDB(bool drop)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MicrosoftSql"].ConnectionString);
                con.Open();
                string sql = "";
                if (drop)
                {
                    sql += "DROP TABLE IF EXISTS tenant;";
                    sql += "DROP TABLE IF EXISTS apartment;";
                    sql += "DROP TABLE IF EXISTS lease;";
                }
                sql += @"CREATE TABLE dbo.tenant (
                          id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                          name VARCHAR(255) NOT NULL,
                          gender VARCHAR(45) NOT NULL,
                          createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                          updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                        );";
                sql += @"CREATE TABLE dbo.apartment (
                              id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                              name VARCHAR(255) NOT NULL,
                              apartmentNo VARCHAR(50) NOT NULL,
                              status VARCHAR(30) NOT NULL DEFAULT 'Available',
                              createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                              updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                        );";
                sql += @"CREATE TABLE dbo.lease (
                              id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                              apartmentId INT NOT NULL,
                              tenantId INT NOT NULL,
                              price FLOAT NOT NULL DEFAULT 0,
                              transactionRef VARCHAR(255) NOT NULL,
                              status VARCHAR(30) NOT NULL,
                              validTill DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                              createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                              updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                        );";
                SqlCommand cmd = new(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error initializing database:"+e.Message);
            }
        }
    }
}
