namespace GetAgeStatus
{
    internal class Program
    {
        static void Main()
        {
            int parsedAge = 0;
            bool notValidAge = true; 

            do
            {
                Console.WriteLine("Введите возраст");
                string ageInputValue = Console.ReadLine() ?? string.Empty;
                bool parseResult = int.TryParse(ageInputValue, out int age);

                if (parseResult == false || age > 100 || age < 1)
                {
                    Console.WriteLine("Неверно, введите цифры от 1 до 100");
                }
                else
                {
                    notValidAge = false;
                    parsedAge = age;
                }
            } while (notValidAge);

            if (parsedAge >= 18)
            {
                Console.WriteLine("Человек совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Человек несовершеннолетний.");
            }
        }
    }
}
