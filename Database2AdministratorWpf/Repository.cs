using Database2AdministratorWpf.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Database2AdministratorWpf
{
    class Repository
    {
        public SqlConnection con = new SqlConnection("Data Source=guftall.ir,25333;Initial Catalog=olympic;User ID=SA;Password=Rr12345678");

        public DataView ReadOlympics()
        {
            var query = "SELECT * FROM En_Olympic";
            DataView dv = null;
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Olympics");
                sda.Fill(dt);
                dv = dt.DefaultView;
            }

            return dv;
        }

        public DataView ReadAthletes()
        {
            var query = "SELECT * FROM En_Athlete";
            DataView dv = null;
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Athletes");
                sda.Fill(dt);
                dv = dt.DefaultView;
            }

            return dv;
        }

        public DataView ReadResidencies()
        {
            var query = "SELECT * FROM En_Residency";
            DataView dv = null;
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Residencies");
                sda.Fill(dt);
                dv = dt.DefaultView;
            }

            return dv;
        }

        public void InsertOlympic(Olympic olympic)
        {
            using (var cmd = new SqlCommand("insert into" +
                " En_Olympic(olympic_name,olympic_sponsors,olympic_website,olympic_twitter,olympic_facebook,olympic_logo,olympic_year" +
                ",happen_country,olympic_torch_image,olympic_torch_cost,olympic_torch_description,olympic_torch_designer)" +
                " values(@name,@sponsors,@website,@twitter,@facebook,@logo,@year,@country,@tImage,@tCost,@tDescription,@tDesigner)", con))
            {
                OpenConnection();
                cmd.Parameters.AddWithValue("@name", olympic.Name);
                cmd.Parameters.AddWithValue("@sponsors", olympic.Sponsors);
                cmd.Parameters.AddWithValue("@website", olympic.Website);
                cmd.Parameters.AddWithValue("@twitter", olympic.Twitter);
                cmd.Parameters.AddWithValue("@facebook", olympic.Facebook);
                cmd.Parameters.AddWithValue("@logo", olympic.Logo);
                cmd.Parameters.AddWithValue("@year", olympic.Year);
                cmd.Parameters.AddWithValue("@country", olympic.Country);
                cmd.Parameters.AddWithValue("@tImage", olympic.TorchImage);
                cmd.Parameters.AddWithValue("@tCost", olympic.TorchCost);
                cmd.Parameters.AddWithValue("@tDescription", olympic.TorchDescription);
                cmd.Parameters.AddWithValue("@tDesigner", olympic.TorchDesigner);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOlympic(Olympic olympic)
        {
            if (olympic == null)
                return;

            using (var cmd = new SqlCommand("update En_Olympic set" +
                " olympic_sponsors=@sponsors," +
                " olympic_website=@website," +
                " olympic_twitter=@twitter," +
                " olympic_facebook=@facebook," +
                " olympic_logo=@logo," +
                " olympic_year=@year" +
                " where olympic_name=@name", con)) {
                OpenConnection();
                cmd.Parameters.AddWithValue("@name", olympic.Name);
                cmd.Parameters.AddWithValue("@sponsors", olympic.Sponsors);
                cmd.Parameters.AddWithValue("@website", olympic.Website);
                cmd.Parameters.AddWithValue("@twitter", olympic.Twitter);
                cmd.Parameters.AddWithValue("@facebook", olympic.Facebook);
                cmd.Parameters.AddWithValue("@logo", olympic.Logo);
                cmd.Parameters.AddWithValue("@year", olympic.Year);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAthlete(Athlete athlete)
        {
            if (athlete == null)
                return;

            using (var cmd = new SqlCommand("update En_Athlete set" +
                " athlete_name=@name," +
                " athlete_birthdate=@birthdate," +
                " athlete_image=@image," +
                " athlete_gender=@gender" +
                " where athlete_id=@id", con))
            {

                OpenConnection();


                cmd.Parameters.AddWithValue("@id", athlete.Id);
                cmd.Parameters.AddWithValue("@name", athlete.Name);
                cmd.Parameters.AddWithValue("@birthdate", athlete.Birthdate);
                cmd.Parameters.AddWithValue("@image", athlete.Image);
                cmd.Parameters.AddWithValue("@gender", athlete.Gender);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveOlympic(string name)
        {
            if (name == null)
                return;
            using (var cmd = new SqlCommand("delete from En_Olympic where olympic_name=@name", con))
            {

                OpenConnection();

                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveAthlete(string id)
        {
            if (id == null)
                return;

            OpenConnection();

            using (var cmd = new SqlCommand("delete from Experienced_Athlete_Sport where athlete_id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            using (var cmd = new SqlCommand("delete from En_Athlete where athlete_id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }


        /*              Athlete         */

        public void InsertAthlete(Athlete athlete, Sport sport)
        {
            OpenConnection();

            string athleteId;
            using (var cmd = new SqlCommand("insert into" +
                " En_Athlete(athlete_team_id, athlete_name, athlete_birthdate, athlete_image, athlete_gender)" +
                " OUTPUT INSERTED.athlete_id Values(@teamId,@name,@birthdate,@image,@gender)", con))
            {


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@teamId", athlete.TeamId);
                cmd.Parameters.AddWithValue("@name", athlete.Name);
                cmd.Parameters.AddWithValue("@birthdate", athlete.Birthdate);
                cmd.Parameters.AddWithValue("@image", athlete.Image);
                cmd.Parameters.AddWithValue("@gender", athlete.Gender);
                athleteId = ((Guid)cmd.ExecuteScalar()).ToString();
                CloseConnection();
            }

            OpenConnection();
            using (var cmd = new SqlCommand("insert into Experienced_Athlete_Sport(athlete_id,sport)" +
                    " values(@athlete,@sportName)", con))
            {

                cmd.Parameters.AddWithValue("@athlete", athleteId);
                cmd.Parameters.AddWithValue("@sportName", sport.Name);

                cmd.ExecuteNonQuery();
            }
        }


        /*          Sport              */
        public List<Sport> ReadSports()
        {
            OpenConnection();
            var sports = new List<Sport>();
            using (var cmd = new SqlCommand("select sport_name from En_Sport", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var sport = new Sport();
                            sport.Name = reader.GetString(0);

                            sports.Add(sport);
                        }
                    }
                }
            }

            return sports;
        }

        /*      Country         */
        public List<Country> ReadCountries()
        {
            OpenConnection();
            var countries = new List<Country>();
            using (var cmd = new SqlCommand("select country_name from En_Country", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var country = new Country();
                            country.Name = reader.GetString(0);
                            countries.Add(country);
                        }

                    }
                }
            }

            return countries;
        }


        public Residency ReadResidency(string id)
        {
            OpenConnection();

            Residency residency = new Residency();
            using (var cmd = new SqlCommand("select residency_id,residency_name,residency_cost from En_Residency" +
                " where residency_id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            residency.Id= reader.GetGuid(0).ToString();
                            residency.Name = reader.GetString(1);
                            residency.Cost = reader.GetInt32(2);
                        }

                    }
                }
            }

            return residency;
        }


        public double CalculateResidencyCost(string residencyId, int count, int nights)
        {
            OpenConnection();
            double cost = 0;
            using (var cmd = new SqlCommand("select * from dbo.calculate_resident_cost(@residency_id,@count,@nights)", con))
            {
                cmd.Parameters.AddWithValue("@residency_id", residencyId);
                cmd.Parameters.AddWithValue("@count", count);
                cmd.Parameters.AddWithValue("@nights", nights);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            cost = reader.GetDouble(0);
                        }
                    }
                }
            }

            return cost;
        }

        private void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }

        private void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) con.Close();
        }
    }
}
