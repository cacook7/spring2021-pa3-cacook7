using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.Interfaces;

namespace spring2021_pa3_cacook7.Database
{
    public class ReseedPost : IReseedPost
    {

        void IReseedPost.ReseedPost()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS posts";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            stm = @"CREATE TABLE `jefznar9d71gs1pb`.`posts` (`id` INT NOT NULL AUTO_INCREMENT,`text` VARCHAR(45) NULL,`date` VARCHAR(45) NULL, PRIMARY KEY (`id`))";
            using var cmd2 = new MySqlCommand(stm, con);

            cmd2.ExecuteNonQuery();

            
            stm = @"INSERT INTO posts(text, date) VALUES(@text, @date)";

            using var cmd3 = new MySqlCommand(stm, con);
            
            DateTime Date = DateTime.Now;


            string Text = "SEEDDATA";
            cmd3.Parameters.AddWithValue("@text", Text);
            cmd3.Parameters.AddWithValue("@date", Date);
            
            cmd3.Prepare();

            cmd3.ExecuteNonQuery();
        
    

        }

    }
}