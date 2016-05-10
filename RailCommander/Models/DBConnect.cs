using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Text;

namespace RailCommander.Models
{
    public class DBConnect
    {
        private MySqlConnection connection;

        public DBConnect()
        {
            this.InitConnection();
        }

        private void InitConnection()
        {
            string connectionString = "SERVER=127.0.0.1;DATABASE=railcommander;UID=root;PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        //User
        public void AddUser(User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@pass", user.Pass);

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }catch(Exception e)
            {
                
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE user SET @ID, @name, @first_name, @pass, @email WHERE UsID = ID";

                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@pass", user.Pass);
                cmd.Parameters.AddWithValue("@email", user.Email);

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE FROM user WHERE UsID = @ID";

                cmd.Parameters.AddWithValue("@ID", user.ID);

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public List<User> usersBDD()
        {
            List<User> lesUsers = new List<User>();
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM user";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();
                    while(reader.Read())
                    {
                        User monUser = new User()
                        {
                            ID = int.Parse(reader.GetString(0)),
                            Name = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            Pass = reader.GetString(3),
                            Email = reader.GetString(4)
                        };

                        lesUsers.Add(monUser);
                    }
                }
            }catch (Exception e)
            {

            }

            return lesUsers;
        }

        //City
        public void AddCity(City city)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", city.ID);
                cmd.Parameters.AddWithValue("@name", city.Name);
                cmd.Parameters.AddWithValue("@first_name", city.FirstName);
                cmd.Parameters.AddWithValue("@email", city.Email);
                cmd.Parameters.AddWithValue("@pass", city.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateCity(City city)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@pass", user.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteCity(City city)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@pass", user.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Station
        public void AddStation(Station station)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateStation(Station station)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteStation(Station station)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Stop
        public void AddStop(Stop stop)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateStop(Stop stop)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteStop(Stop stop)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Train
        public void AddTrain(Train train)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateTrain(Train train)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteTrain(Train train)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Car
        public void AddCar(Car car)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateCar(Car car)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteCar(Car car)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Seat
        public void AddSeat(Seat seat)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateSeat(Seat seat)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteSeat(Seat seat)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        //Ticket
        public void AddTicket(Ticket ticket)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void UpdateTicket(Ticket ticket)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }

        public void DeleteTicket(Ticket ticket)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user VALUES(@ID, @name, @first_name, @email, @pass)";

                /*cmd.Parameters.AddWithValue("@ID", monUser.ID);
                cmd.Parameters.AddWithValue("@name", monUser.Name);
                cmd.Parameters.AddWithValue("@first_name", monUser.FirstName);
                cmd.Parameters.AddWithValue("@email", monUser.Email);
                cmd.Parameters.AddWithValue("@pass", monUser.Pass);*/

                cmd.ExecuteNonQuery();

                this.connection.Close();

            }
            catch (Exception e)
            {

            }
        }
    }
}