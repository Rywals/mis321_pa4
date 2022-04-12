namespace api
{
    public class ConnectionString
    {
         public string cs {get;set;}

        public ConnectionString(){
            string server = "wb39lt71kvkgdmw0.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "auxpe7r6dvleicpn";
            string port = "	3306";
            string userName = "earxv2vmgzzkjjlk";
            string password = "aw7qic7o5nq9naim";

            cs = $@"server={server};username={userName};database={database};port={port};password={password};";
        }
    }
}