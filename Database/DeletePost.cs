using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.Interfaces;

namespace spring2021_pa3_cacook7.Database
{
    public class DeletePost : IDeletePost
    {
        void IDeletePost.DeletePost()
        {
            Console.WriteLine("What is the id of the post you would like to delete?");
            int id = int.Parse(Console.ReadLine());
            string stm = $@"DELETE FROM `jefznar9d71gs1pb`.`posts` WHERE (`id` = {id})";

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

        }
    }
}