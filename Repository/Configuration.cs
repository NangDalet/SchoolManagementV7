namespace SchoolManagementAPI.Repository
{
    public class Configuration
    {
        private static string? Connection = "";
        public static string? GetConnection => Connection;
        public static string SetConnection(string value) => Connection = value;
    }
}
