using ServerManagement.Components;
namespace ServerManagement.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsOnline { get; set; }

        public Server()
        {
            Random random = new Random();
            int r = random.Next(0, 2);
            IsOnline = r == 0 ? false : true;
        }

    }
}