using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.General;

namespace WinFormsApp1.Models
{
    class Apartment
    {
        int id;
        string name;
        string apartmentNo;
        string status;

        static string conString = ConfigurationManager.ConnectionStrings["myDBConnection"].ConnectionString;
        public Apartment(int id, string name, string apartmentNo, string status) {
            this.id = id;
            this.name = name;
            this.apartmentNo = apartmentNo;
            this.status = status;
        }
        public class ApartmentInfo
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? ApartmentNo { get; set; }
            public string? status { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }
        public static ApartmentInfo? FetchById(int id)
        {
            var info = new List<ApartmentInfo>();
            try
            {
                string sql = "SELECT * FROM apartment WHERE id = '" + id + "';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new ApartmentInfo
                    {
                        Id = dr.GetInt32("id"),
                        Name = dr.GetString("name"),
                        ApartmentNo = dr.GetString("apartmentNo"),
                        status = dr.GetString("status"),
                        CreatedAt = dr.GetDateTime("createdAt"),//DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        UpdatedAt = dr.GetDateTime("updatedAt")//DateTime.ParseExact(dr.GetString("updatedAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    info.Add(tInfo);
                }
                dr.Close();
                if (info.Count <= 0)
                {
                    return null;
                }
                return info[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("FetchById: " + e.Message);
                return null;
            }
        }
        public bool Create()
        {
            try
            {
                if (this.name.Trim() == "")
                {
                    MessageBox.Show("Please enter apartment name");
                    return false;
                }
                if (this.apartmentNo.Trim() == "")
                {
                    MessageBox.Show("Please add apartment number");
                    return false;
                }
                if (this.status.Trim() == "")
                {
                    MessageBox.Show("Please select a status");
                    return false;
                }
                string sql = "INSERT INTO apartment(name, apartmentNo, status) VALUES ('"+ this.name + "', '"+ this.apartmentNo + "', '"+ this.status + "');";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Create: " + e.Message);
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                if (this.name.Trim() == "")
                {
                    MessageBox.Show("Please enter apartment name");
                    return false;
                }
                if (this.apartmentNo.Trim() == "")
                {
                    MessageBox.Show("Please add apartment number");
                    return false;
                }
                if (this.status.Trim() == "")
                {
                    MessageBox.Show("Please select a status");
                    return false;
                }
                ApartmentInfo? apartment = Apartment.FetchById(this.id);
                if(apartment == null)
                {
                    MessageBox.Show("Apartment could not be found");
                    return false;
                }
                if(this.status != apartment.status && apartment.status == "Leased")
                {
                    MessageBox.Show("This apartment has been leased");
                    return false;
                }
                string sql = "UPDATE apartment SET name = '" + this.name + "', apartmentNo = '" + this.apartmentNo + "', status = '"+this.status+"', updatedAt = getdate() WHERE id = '" + this.id + "';";
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
        public static bool UpdateStatus(int id, string status)
        {
            try
            {
                
                ApartmentInfo? apartment = Apartment.FetchById(id);
                if (apartment == null)
                {
                    MessageBox.Show("Apartment could not be found");
                    return false;
                }
                string sql = "UPDATE apartment SET  status = '" + status + "', updatedAt = getdate() WHERE id = '" + id + "';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("UpdateStatus: " + e.Message);
                return false;
            }
        }
        public static List<ApartmentInfo> FetchAll()
        {
            var info = new List<ApartmentInfo>();
            try
            {
                string sql = "SELECT * FROM apartment ORDER BY id DESC;";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new ApartmentInfo
                    {
                        Id = dr.GetInt32("id"),
                        Name = dr.GetString("name"),
                        ApartmentNo = dr.GetString("apartmentNo"),
                        status = dr.GetString("status"),
                        CreatedAt = dr.GetDateTime("createdAt"),//DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
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
        public static List<ApartmentInfo> FetchLeased()
        {
            var info = new List<ApartmentInfo>();
            try
            {
                string sql = "SELECT * FROM apartment WHERE status = 'Leased' ORDER BY id DESC;";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var tInfo = new ApartmentInfo
                    {
                        Id = dr.GetInt32("id"),
                        Name = dr.GetString("name"),
                        ApartmentNo = dr.GetString("apartmentNo"),
                        status = dr.GetString("status"),
                        CreatedAt = dr.GetDateTime("createdAt"),//DateTime.ParseExact(dr.GetString("createdAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        UpdatedAt = dr.GetDateTime("updatedAt")//DateTime.ParseExact(dr.GetString("updatedAt"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                    };
                    info.Add(tInfo);
                }
                dr.Close();
                return info;
            }
            catch (Exception e)
            {
                MessageBox.Show("FetchLeased: " + e.Message);
                return info;
            }
        }
        public static bool DeleteById(string? id)
        {
            try
            {
                ApartmentInfo? apartment = Apartment.FetchById(Int32.Parse(id));
                if (apartment == null)
                {
                    MessageBox.Show("Apartment could not be found");
                    return false;
                }
                if (apartment.status == "Leased")
                {
                    MessageBox.Show("This apartment has been leased, hence cannot be deleted");
                    return false;
                }
                string sql = "DELETE FROM apartment WHERE id = '" + id + "';";
                SqlCommand cmd = AppConnection.RunCommand(sql);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
