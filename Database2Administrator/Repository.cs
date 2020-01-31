using Database2Administrator.Dto;
using System;
using System.Data.SqlClient;

namespace Database2Administrator
{
    class Repository
    {
        public SqlConnection con = new SqlConnection("Data Source=guftall.ir,25333;Initial Catalog=olympic;User ID=SA;Password=Rr12345678");
        SqlCommand cmd;

        public void InsertOlympic(Olympic olympic)
        {
            cmd = new SqlCommand("insert into" +
                " En_Olympic(olympic_name,olympic_sponsors,olympic_website,olympic_twitter,olympic_facebook,olympic_logo" +
                ",happen_country,olympic_torch_image,olympic_torch_cost,olympic_torch_description,olympic_torch_designer)" +
                " values(@name,@sponsors,@website,@twitter,@facebook,@logo,@country,@tImage,@tCost,@tDescription,@tDesigner)", con);
            OpenConnection();
            cmd.Parameters.AddWithValue("@name", olympic.Name);
            cmd.Parameters.AddWithValue("@sponsors", olympic.Sponsors);
            cmd.Parameters.AddWithValue("@website", olympic.Website);
            cmd.Parameters.AddWithValue("@twitter", olympic.Twitter);
            cmd.Parameters.AddWithValue("@facebook", olympic.Facebook);
            cmd.Parameters.AddWithValue("@logo", olympic.Logo);
            cmd.Parameters.AddWithValue("@country", olympic.Country);
            cmd.Parameters.AddWithValue("@tImage", olympic.TorchImage);
            cmd.Parameters.AddWithValue("@tCost", olympic.TorchCost);
            cmd.Parameters.AddWithValue("@tDescription", olympic.TorchDescription);
            cmd.Parameters.AddWithValue("@tDesigner", olympic.TorchDesigner);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOlympic(Olympic olympic)
        {
            if (olympic == null)
                return;

            cmd = new SqlCommand("update En_Olympic set" +
                " olympic_sponsors=@sponsors," +
                " olympic_website=@website," +
                " olympic_twitter=@twitter," +
                " olympic_facebook=@facebook," +
                " olympic_logo=@logo" +
                " where olympic_name=@name", con);
            OpenConnection();
            cmd.Parameters.AddWithValue("@name", olympic.Name);
            cmd.Parameters.AddWithValue("@sponsors", olympic.Sponsors);
            cmd.Parameters.AddWithValue("@website", olympic.Website);
            cmd.Parameters.AddWithValue("@twitter", olympic.Twitter);
            cmd.Parameters.AddWithValue("@facebook", olympic.Facebook);
            cmd.Parameters.AddWithValue("@logo", olympic.Logo);
            cmd.ExecuteNonQuery();
        }

        public void UpdateAthlete(Athlete athlete)
        {
            if (athlete == null)
                return;

            cmd = new SqlCommand("update En_Athlete set" +
                " athlete_name=@name," +
                " athlete_birthdate=@birthdate," +
                " athlete_image=@image," +
                " athlete_gender=@gender" +
                " where athlete_id=@id", con);

            OpenConnection();


            cmd.Parameters.AddWithValue("@id", athlete.Id);
            cmd.Parameters.AddWithValue("@name", athlete.Name);
            cmd.Parameters.AddWithValue("@birthdate", athlete.Birthdate);
            cmd.Parameters.AddWithValue("@image", athlete.Image);
            cmd.Parameters.AddWithValue("@gender", athlete.Gender);
            cmd.ExecuteNonQuery();
        }

        public void RemoveOlympic(string name)
        {
            if (name == null)
                return;
            cmd = new SqlCommand("delete from En_Olympic where olympic_name=@name", con);

            OpenConnection();

            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }

        public void RemoveAthlete(string id)
        {
            if (id == null)
                return;
            cmd = new SqlCommand("delete from En_Athlete where athlete_id=@id", con);

            OpenConnection();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }


        /*              Athlete         */

        public void InsertAthlete(Athlete athlete)
        {
            cmd = new SqlCommand("insert into" +
                " En_Athlete(athlete_team_id, athlete_name, athlete_birthdate, athlete_image, athlete_gender)" +
                " Values(@teamId,@name,@birthdate,@image,@gender)", con);
            OpenConnection();
            cmd.Parameters.AddWithValue("@teamId", athlete.TeamId);
            cmd.Parameters.AddWithValue("@name", athlete.Name);
            cmd.Parameters.AddWithValue("@birthdate", athlete.Birthdate);
            cmd.Parameters.AddWithValue("@image", athlete.Image);
            cmd.Parameters.AddWithValue("@gender", athlete.Gender);
            cmd.ExecuteNonQuery();
        }

        private void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }
    }
}
