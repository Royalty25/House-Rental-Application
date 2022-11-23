using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using WinFormsApp1.General;

namespace WinFormsApp1.Models
{
    class Tenant
    {
        int id;
        string name;
        string gender;
        static string conString = ConfigurationManager.ConnectionStrings["myDBConnection"].ConnectionString;
        public class TenantInfo
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Gender { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }
        public Tenant(int id,string name,string gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
        }
        public static TenantInfo? FetchById(int id)
        {
            var info = new List<TenantInfo>();
            try
            {
                string sql = "SELECT * FROM tenant WHERE id = '" + id + "';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new TenantInfo
                    {
                        Id = dr.GetInt32("id"),
                        Name = dr.GetString("name"),
                        Gender = dr.GetString("gender"),
                        CreatedAt = dr.GetDateTime("createdAt"),//DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture),
                        UpdatedAt = dr.GetDateTime("updatedAt")//DateTime.ParseExact(dr.GetString("updatedAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    info.Add(tInfo);
                }
                dr.Close();
                if(info.Count <= 0)
                {
                    return null;
                }
                return info[0];
            }
            catch(Exception e)
            {
                MessageBox.Show("FetchById: "+e.Message);
                return null;
            }
        }
        public bool Create()
        {
            try
            {
                if (this.name.Trim() == "")
                {
                    MessageBox.Show("Please enter a full name");
                    return false;
                }
                if (this.gender.Trim() == "")
                {
                    MessageBox.Show("Please select a gender");
                    return false;
                }
                string sql = "INSERT INTO tenant (name, gender) VALUES ('"+this.name+"','"+this.gender+"');";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Create: " + e.Message);
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                if (this.name == "")
                {
                    MessageBox.Show("Please enter a full name");
                    return false;
                }
                if (this.gender == "")
                {
                    MessageBox.Show("Please select a gender");
                    return false;
                }
                TenantInfo? tenant = Tenant.FetchById(this.id);
                if(tenant == null)
                {
                    MessageBox.Show("Tenant could not be found");
                    return false;
                }
                string sql = "UPDATE tenant SET name = '"+this.name+"', gender = '"+this.gender+ "', updatedAt = getdate() WHERE id = '" + this.id+"';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Update: " + e.Message);
                return false;
            }
        }
        public static List<TenantInfo> FetchAll()
        {
            var info = new List<TenantInfo>();
            try
            {
                string sql = "SELECT * FROM tenant ORDER BY id DESC;";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new TenantInfo
                    {
                        Id = dr.GetInt32("id"),
                        Name = dr.GetString("name"),
                        Gender = dr.GetString("gender"),
                        CreatedAt = dr.GetDateTime("createdAt"), //DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        UpdatedAt = dr.GetDateTime("updatedAt")//DateTime.ParseExact(dr.GetString("updatedAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    info.Add(tInfo);
                }
                dr.Close();
                return info;
            }
            catch (Exception e)
            {
                MessageBox.Show("FetchAll: " + e.Message);
                return info;
            }
        }
        public static bool DeleteById(string? id)
        {
            try
            {
                TenantInfo? tenant = Tenant.FetchById(Int32.Parse(id));
                if (tenant == null)
                {
                    MessageBox.Show("Tenant could not be found");
                    return false;
                }
                string sql = "DELETE FROM tenant WHERE id = '"+id+"';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
