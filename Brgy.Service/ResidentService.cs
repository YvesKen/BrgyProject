using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Brgy.Domain;
using System.Data;

namespace Brgy.Service
{
    public class ResidentService
    {
        private readonly string _connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BrgyDB;Integrated Security=True";

        // GET ALL RESIDENTS
        public DataTable GetAllResidents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string query = "SELECT ResidentId, FirstName, LastName, Age, Gender, Address, Status FROM Residents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        // SEARCH RESIDENTS BY NAME
        public DataTable SearchResidents(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string query = "SELECT * FROM Residents WHERE FirstName LIKE @search OR LastName LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}