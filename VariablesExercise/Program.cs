namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Sadie";
            int dogAge = 4;
            char dogGender = 'f';
            bool isDog = true;
            
            //dotnet 9.0 has an issue with this being declared as a decimal, for some reason.
            //I've converted this to a double so it works, but if it's necessary to make this a decimal let me know and I'll troubleshoot"
            //Appending the "M" suffix to the variable still didn't let me manually set its data type as a decimal."
            double dogWeight = 5.3;
            
            double dogFoodPrice = 39.99;
            Console.WriteLine($"My dog's name is {dogName}. She is {dogAge} years old. Her gender is {dogGender}, and she is {dogWeight} kg. Her food costs {dogFoodPrice}");
        }
    }
}
