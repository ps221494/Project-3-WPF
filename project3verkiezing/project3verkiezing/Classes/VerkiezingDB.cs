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
        public bool DeleteStandpunt (string StandpuntId)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `standpunten` WHERE `standpunten`.`StandpuntId` = @StandpuntId;";
                command.Parameters.AddWithValue("@StandpuntId", StandpuntId);
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
        public bool DeleteVerkiezingsoort(string SoortId)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `verkiezingsoort` WHERE `verkiezingsoort`.`SoortId` = @SoortId;";
                command.Parameters.AddWithValue("@SoortId", SoortId);
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
        public bool DeleteVerkiezing(string VerkiezingId)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `verkiezing` WHERE `verkiezing`.`VerkiezingId` = @VerkiezingId;";
                command.Parameters.AddWithValue("@VerkiezingId", VerkiezingId);
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
        public bool DeleteVerkiezingpartij(string Id)
        {
            bool succes = false;

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `verkiezingspartijen` WHERE `verkiezingspartijen`.`Id` = @Id;";
                command.Parameters.AddWithValue("@Id", Id);
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

        public bool VoegPartij(string PartijName, string Adres, string Postcode, string Gemeente ,string EmailAdres, string Telefoonnummer)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `partij` (`PartijId`, `PartijName`, `Adres`, `Postcode`, `Gemeente` , `EmailAdres`, `Telefoonnummer`) VALUES (NULL, @PartijName, @Adres, @Postcode, @Gemeente, @EmailAdres, @Telefoonnummer) ";
                command.Parameters.AddWithValue("@PartijName", PartijName);
                command.Parameters.AddWithValue("@Adres", Adres);
                command.Parameters.AddWithValue("@Postcode", Postcode);
                command.Parameters.AddWithValue("@Gemeente", Gemeente);
                command.Parameters.AddWithValue("@EmailAdres", EmailAdres);
                command.Parameters.AddWithValue("@Telefoonnummer", Telefoonnummer);
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
        public bool VoegThema(string Thema)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `thema` (`ThemaId`, `Thema`) VALUES (NULL, @Thema) ";
                command.Parameters.AddWithValue("@Thema", Thema);
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

        public bool VoegStandpunt(string PartijId, string PartijName, string ThemaId, string Thema, string Standpunt)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `standpunten` (`StandpuntId`, `PartijId`, `PartijName`, `ThemaId`, `Thema`, `Standpunt`) VALUES (NULL, @PartijId, @PartijName, @ThemaId, @Thema, @Standpunt) ";
                command.Parameters.AddWithValue("@PartijId", PartijId);
                command.Parameters.AddWithValue("@ThemaId", ThemaId);
                command.Parameters.AddWithValue("@PartijName", PartijName);
                command.Parameters.AddWithValue("@Thema", Thema);
                command.Parameters.AddWithValue("@Standpunt", Standpunt);
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

        public bool VoegVerkiezingsoort(string Verkiezingsoort)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `verkiezingsoort` (`SoortId`, `Verkiezingsoort`) VALUES (NULL, @Verkiezingsoort) ";
                command.Parameters.AddWithValue("@Verkiezingsoort", Verkiezingsoort);
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

        public bool VoegVerkiezing(string Soort, string Verkiezingsoort, string Datum)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `verkiezing` (`VerkiezingId`, `SoortId`, `Verkiezingsoort`, `Datum`) VALUES (NULL, @Soort, @Verkiezingsoort, @Datum) ";
                command.Parameters.AddWithValue("@Soort", Soort);
                command.Parameters.AddWithValue("@Verkiezingsoort", Verkiezingsoort);
                command.Parameters.AddWithValue("@Datum", Datum);
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
        public bool VoegVerkiezingpartij (string PartijId, string VerkiezingId)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `verkiezingspartijen` (`Id`, `PartijId`, `VerkiezingId`) VALUES (NULL, @PartijId, @VerkiezingId) ";
                command.Parameters.AddWithValue("@PartijId", PartijId);
                command.Parameters.AddWithValue("@VerkiezingId", VerkiezingId);
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
