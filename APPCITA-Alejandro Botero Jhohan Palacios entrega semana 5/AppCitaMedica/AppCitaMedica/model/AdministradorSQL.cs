using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCitaMedica.model
{
    internal class AdministradorSQL
    {
        MySqlConnection obj_conexion = new MySqlConnection();
      
        string server = "localhost";
        string user = "root";
        string passw = "Admin";
        string port = "3306";
        string db = "db_citas";
        string table = "registros";

        public MySqlConnection conectarSQL()
        {
            try
            {
                obj_conexion.ConnectionString = "server="+ server +"; port=" + port + "; user id=" + user + "; password=" + passw + "; database=" + db + ";";
                obj_conexion.Open();
                
                return obj_conexion;
            }
            catch(MySqlException err)
            {
                MessageBox.Show(err + "");
                return null;
            }

        }

        public void closeSQL()
        {
            obj_conexion.Close();
        }

        public void insert(string name, string id, string especialiad, string agendamiento, string medico)
        {
            string instruccionSQL = "INSERT INTO " + table + "(fullname, id, espe, agend, medico) VALUES ('"+name+"','"+id+"','"+especialiad+"','"+agendamiento+"','"+medico+"')";
            MySqlCommand obj_command = new MySqlCommand(instruccionSQL,obj_conexion);
            try
            {
                obj_command.ExecuteNonQuery();
                MessageBox.Show("Cita registrada con exito"); 
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err + "");
            }
        }

        public List<String> listaConsulta()
        {
            string instruccionSQL = "SELECT * FROM " + table;
            MySqlCommand obj_command = new MySqlCommand(instruccionSQL, obj_conexion);
            try
            {
                MySqlDataReader dataReader = obj_command.ExecuteReader();
                List<String> listaNombres = new List<String>();
                if (dataReader.HasRows) {
                    while (dataReader.Read())
                    {
                        listaNombres.Add(dataReader.GetString(0));
                    }
                    return listaNombres;
                }
                else
                {
                    MessageBox.Show("no hay citas registradas");
                    return null;
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err + "");
                return null;
            }
        }

        public ModelCitaMedica consulta(String nombre)
        {

            ModelCitaMedica obj_cita = new ModelCitaMedica();
            string instruccionSQL = "SELECT * FROM " + table+ " WHERE fullname='" + nombre+"';";
            
            MySqlCommand obj_command = new MySqlCommand(instruccionSQL, obj_conexion);
            try
            {
                DateTime agendamiento = new DateTime();
                MySqlDataReader dataRead = obj_command.ExecuteReader();
                dataRead.Read();
                obj_cita.setNombre(dataRead.GetString(0));
                obj_cita.setId(dataRead.GetString(1));
                obj_cita.setEspecialidad(dataRead.GetString(2));
                obj_cita.setAgendamiento(dataRead.GetDateTime(3));
                obj_cita.setMedico(dataRead.GetString(4));

                return obj_cita;


            }
            catch (MySqlException err)
            {
                MessageBox.Show(err + "");
                return null;

            }

            return null;
        }

       
    }
}
