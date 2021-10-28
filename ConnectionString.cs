namespace spring2021_pa3_cacook7
{
    public class ConnectionString
    {
        public string cs{get; set;}

        public ConnectionString()
        {
            string server = "nnsgluut5mye50or.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "jefznar9d71gs1pb";
            string port = "3306";
            string userName = "x5k0rqupbxsjfgl8";
            string password = "zzekd0nd4vt0ir32";

            cs = $@"server = {server};user={userName};database={database};port={port};password={password};";
        }
    }
}