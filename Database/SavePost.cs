using System.Reflection.Metadata.Ecma335;
using System.Reflection.Emit;
using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.models;
using spring2021_pa3_cacook7.Interfaces;

namespace spring2021_pa3_cacook7.Database
{
    public class SavePost : ISavePost
    {
        void ISavePost.SavePost()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO posts(text, date) VALUES(@text, @date)";

            using var cmd = new MySqlCommand(stm, con);

            Console.WriteLine("What would you like your post to say?");
            
            string Text = Console.ReadLine();
            DateTime Date = DateTime.Now;

            cmd.Parameters.AddWithValue("@text", Text);
            cmd.Parameters.AddWithValue("@date", Date);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}