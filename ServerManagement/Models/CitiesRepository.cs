namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> Cities = new List<string>() { "Toronto", "Montreal", "Ottawa", "Calgary", "Halifax" };
        public static List<string> GetCities() => Cities;
    }
}

