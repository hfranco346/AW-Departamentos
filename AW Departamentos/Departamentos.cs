using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces requeridos
using System.Data;
using System.Data.SqlClient;

namespace AW_Departamentos
{
    class Departamentos
    {
        protected SqlConnection conn = new SqlConnection(@"server = .\sqlexpress; 
                integrated security = true; database = AdventureWorks2014");
        protected string sql;

        // Constructor
        public Departamentos() { }

        public List<Departamento> LeerTodos()
        {
            // Lista de tipo departamendo
            List<Departamento> resultados = new List<Departamento>();

            sql = @"Select DepartmentID, Name, GroupName From HumanResources.Department";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                // Ejecutar el query via un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Obtener los valores del ExecuteReader
                // y pasarlos a lista de tipo departamento
                while (rdr.Read())
                {
                    Departamento departamento = new Departamento();

                    departamento.id = rdr.GetInt16(0);
                    departamento.name = rdr.GetString(1);
                    departamento.groupName = rdr.GetString(2);

                    resultados.Add(departamento);
                }

                return resultados;
            }
            catch (SqlException ex)
            {
                return resultados;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Insertar(Departamento departamento)
        {
            sql = "Insert into HumanResources.Department (Name, GroupName, ModifiedDate) values (@name, @groupName, @ModifiedDate)";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = departamento.name;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = departamento.groupName;
                    cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = departamento.modifiedDate;

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }

        public bool Eliminar(Departamento departamento)
        {
            // Crear el comando con el Stored Procedure
            SqlCommand cmd = new SqlCommand("sp_EliminarDepartamento", conn);

            // Establecer el comando como Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("nombreDepartamento", SqlDbType.NVarChar, 50));
            cmd.Parameters["nombreDepartamento"].Value = departamento.name;

            try
            {
                // Establecer la conexión
                conn.Open();

                // Query de eliminación
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}
