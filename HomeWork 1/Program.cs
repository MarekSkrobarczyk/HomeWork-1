using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            task_3();
            Console.ReadLine();
        }

        public static void task_1()
        {
            /* Stwórz program , w którym zadeklarujesz zmienne dotyczące pracownika firmy. Dane które chcesz przetrzymywać
              to: Imię, Nazwisko, Wiek, Płeć, PESEL, numer pracownika */
            
            
            string name;
            string lastName;
            byte age;
            char sex;
            int[] PESEL = new int[11];
            int ID;
        }

        public static void task_2()
        {
            /* Napisz program który stworzy 3 zmienne, a następnie wyświetl je w kolejności odwrotnej do deklaracji */
            
            char[] list = new char[3];
            list[0] = 'a';
            list[1] = 'b';
            list[2] = 'c';

            for (byte i = 3; i > 0; i--)
            {
                Console.WriteLine(list[i-1]);
            }

        }

        public static void task_3()
        {
            /* Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
            przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) */
            
            short a;
            short b;
            
            Console.WriteLine(" Enter value a: ");
            short.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter b: ");
            short.TryParse(Console.ReadLine(), out b);
            
            Console.WriteLine($"The length of the diagonal is {Math.Sqrt(a*a + b*b)}");
        }

        public static void task_4()
        {
            byte a = 10;
            string b = "Szkoła Dotneta";
            double c = 10.5;
            
        }

        public static void task_5()
        {
            string firstname;
            string lastname;
            int mobile;
            string mail;
            double height;
            double weight;
            
            
            
        }
        

    }
   
    
    
    
    
}
