using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            var Query = @"SELECT  [DepartmentID]
      ,[DepartmentName]
  FROM[ReactDB].[dbo].[Departments]";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

            using (var cmd = new SqlCommand(Query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Department dp)
        {
            try
            {
                DataTable table = new DataTable();
                var Query = @"insert into [ReactDB].[dbo].[Departments] values('" + dp.DepartmentName + @"')";
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

                using (var cmd = new SqlCommand(Query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    da.Fill(table);
                }
                return "Add Successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string Put(Department dp)
        {
            try
            {
                DataTable table = new DataTable();
                var Query = @"update[ReactDB].[dbo].[Departments] set DepartmentName = '" + dp.DepartmentName + @"' where DepartmentID = '" + dp.DepartmentID + @"'";
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

                using (var cmd = new SqlCommand(Query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    da.Fill(table);
                }
                return "Update Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string Delete(int id)
        {
            try
            {
                DataTable table = new DataTable();
                var Query = @"delete from [ReactDB].[dbo].[Departments] where DepartmentID='" + id + @"'";
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

                using (var cmd = new SqlCommand(Query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    da.Fill(table);
                }
                return "Delete Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }



        }

    }
}
