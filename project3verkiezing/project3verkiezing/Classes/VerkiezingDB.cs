using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3verkiezing.Classes
{
    class VerkiezingDB
    {
        #region fields
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=verkiezingenprj3;Uid=root;Pwd=;");
        #endregion


        #region method/functions

        public DataTable SelectPartijen()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM partij; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable SelectThema()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM thema; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable SelectStandpunt()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM standpunten; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable SelectVerkiezingSoort()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM verkiezingsoort; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable SelectVerkiezing()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM verkiezing; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable SelectVerkiezingPartij()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT* FROM verkiezingspartijen; ";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool DeletePartij(string PartijId)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `partij` WHERE `partij`.`PartijId` = @PartijId;";
                command.Parameters.AddWithValue("@PartijId", PartijId);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }



            return succes;
        }
        public bool DeleteThema(string ThemaId)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `thema` WHERE `thema`.`ThemaId` = @ThemaId;";
                command.Parameters.AddWithValue("@ThemaId", ThemaId);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }



            return succes;
        }
        #endregion
    }
}
