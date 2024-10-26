namespace ServerManagement.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public bool IsOnline { get; set; }

        public Server()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, 2);
            IsOnline = RandomNumber == 0 ? false : true;
        }
    }

}
