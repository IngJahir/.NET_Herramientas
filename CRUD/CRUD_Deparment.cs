using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD
{
    class CRUD_Deparment
    {
        private string connectionString 
            = "Data Source=localhost;Database=Tienda_JYM;Trusted_Connection=True;MultipleActiveResultSets=true";

        // Confirmacion de conexion
        // -------------------------
        public bool Confirmar_conexion() 
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch 
            {
                return false;
            }

            return true;
        }

        // CREATE Department
        // -----------------
        public void CREATE_Deparment(string Name) 
        {
            string query = "insert into Departments(Name) values" + "(@name)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name",Name);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BBDD" + ex.Message);
                }
            }
        }

        // READ Department 1: Lee todos los datos
        // --------------------------------------
        public List<Department> READ_Department() 
        {
            // Lista de departamentos
            List<Department> departments = new List<Department>();

            string query = "select Id_Department,Name from Departments";
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(query,connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) 
                    {
                        Department oDepartment = new Department();
                        oDepartment.Id_Depertment = reader.GetInt32(0);
                        oDepartment.Name = reader.GetString(1);
                        departments.Add(oDepartment);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BBDD"+ex.Message);
                }   
            }
            return departments;
        }

        // READ Department 2: Lee un solo dato
        // --------------------------------------
        public Department READ_Department(int Id)
        {
            string query = "select Id_Department,Name from Departments"+
                " where Id_Department=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    Department oDepartment = new Department();
                    oDepartment.Id_Depertment = reader.GetInt32(0);
                    oDepartment.Name = reader.GetString(1);
                    
                    reader.Close();
                    connection.Close();
                    return oDepartment;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BBDD" + ex.Message);
                }
            }
            
        }

        // UPDATE Department
        // -----------------
        public void UPDATE_Deperment(string Name, int Id) 
        {
            string query = "update Departments set Name=@name"+
                " Where Id_Department=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name",Name);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BBDD" + ex.Message);
                }
            }            
        }

        // DELETE Department
        // -----------------
        public void DELETE_Department(int Id)
        {
            string query = "delete from Departments" +
                " Where Id_Department=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la BBDD" + ex.Message);
                }
            }
        }
    }

    // Entidad
    // -------
    public class Department 
    {
        public int Id_Depertment { get; set; }
        public string Name { get; set; }
    }
}
