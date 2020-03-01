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
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            var Query = @"SELECT  [EmployeeID]
      ,[EmployeeName]
      ,[Department]
      ,[MailID]
      ,[DOJ]
  FROM [ReactDB].[dbo].[Employees]";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

            using (var cmd = new SqlCommand(Query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }



        public string Post(Employee emp)
        {
            try
            {
                DataTable table = new DataTable();
                var Query = @"insert into [ReactDB].[dbo].[Employees] values('" + emp.EmployeeName + @"','" + emp.Department + @"','" + emp.MailID + @"','" + emp.DOJ + @"')";
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ReactDB"].ConnectionString))

                using (var cmd = new SqlCommand(Query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    da.Fill(table);
                }
                return "Add Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }



        }


        public string Put(Employee emp)
        {
            try
            {
                DataTable table = new DataTable();
                var Query = @"update [ReactDB].[dbo].[Employees] set EmployeeName='" + emp.EmployeeName + @"',Department='" + emp.Department + @"',MailID='" + emp.MailID + @"',
DOJ='" + emp.DOJ + @"' where EmployeeID='" + emp.EmployeeID + @"'";
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
                var Query = @"delete from [ReactDB].[dbo].[Employees] where EmployeeID='" + id + @"'";
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
