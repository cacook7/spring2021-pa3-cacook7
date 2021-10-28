using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.Interfaces;
using spring2021_pa3_cacook7.models;

namespace spring2021_pa3_cacook7.Database
{
    public class ViewPost : IViewPost
    {
        List<Post> IViewPost.ViewPost()
        {
            List<Post> allPosts = new List<Post>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();
        
            string stm = "SELECT * FROM jefznar9d71gs1pb.posts";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Post temp = new Post(){Id=rdr.GetInt32(0), Text=rdr.GetString(1), Date=rdr.GetString(2)};
                allPosts.Add(temp);
            }
            return allPosts;
        }
    }
}