namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            
            Console.WriteLine($"celicius: {celcius}" );
            
            var farenheit = TempConverter.CelsiusToFahrenheit(24);
            Console.WriteLine($"farenheit: {farenheit}" );
            
        }
    }
}
