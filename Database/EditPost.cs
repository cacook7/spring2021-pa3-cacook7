using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.Interfaces;

namespace spring2021_pa3_cacook7.Database
{
    public class EditPost : IEditPost
    {
        void IEditPost.EditPost()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine("What is the id of the post you want to edit?");
            int id = int.Parse(Console.ReadLine());

            string stm = $@"UPDATE posts SET text = @text WHERE (`id` = {id})";
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