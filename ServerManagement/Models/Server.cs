namespace ServerManagement.Models
{
    public class Server
    {
        public int ServerId { get; set; }
        public string? ServerName { get; set; }
        public string? ServerCity { get; set; }
        public bool IsOnline { get; set; }

        public Server()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, 2);
            IsOnline = RandomNumber == 0 ? false : true;
        }
    }

}
