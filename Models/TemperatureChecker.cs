namespace MvcApp.Models
{
    public static class TemperatureChecker
    {
        public static string CheckTemperature(float temperature)
        {
            if (temperature >= 38)
            {
                return "You have a fever.";
            }
            else
            {
                return "Your temperature is normal or too low I don't know.";
            }
        }
    }
}