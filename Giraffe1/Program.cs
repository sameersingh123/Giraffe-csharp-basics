using Giraffe1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
     class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("Harry Potter", "JK Rowling", 400);
           
            Console.WriteLine(book.title);

            Student student = new Student("Sameer", "Computer Science", 3.6);
            Console.WriteLine(student.HasHonors());

            Movie movie1 = new Movie("Inception", "Christopher Nolan", "PG-163");
            Console.WriteLine(movie1.MovieCount());
            Movie movie2 = new Movie("Interstellar", "Christopher Nolanin", "PG-16");
            Console.WriteLine(Movie.movieCount);

            Console.WriteLine(movie1.Rating);

            Movie.SayHi("Sameer");



            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            IndianChef indianChef = new IndianChef();
            indianChef.MakeChicken();
            indianChef.MakeBiryani();
            indianChef.MakeSpecialDish();

            ParameterizedConstructor parameterizedConstructor1 = new ParameterizedConstructor(5);
            ParameterizedConstructor parameterizedConstructor2 = new ParameterizedConstructor(10);

            parameterizedConstructor1.Print();
            parameterizedConstructor2.Print();
           
            CopyConstructor copyConstructor1 = new CopyConstructor(5);
            
            CopyConstructor copyConstructor2 = new CopyConstructor(copyConstructor1);

            copyConstructor1.Display();
            copyConstructor2.Display();

            StaticConstructor staticConstructor1 = new StaticConstructor();
            Console.WriteLine(staticConstructor1.y);
            Console.WriteLine(StaticConstructor.x);
            
            


            

            
            





            //string characterName = "Singh Si";
            //Console.WriteLine($"Sameer {characterName[0]}");
            //Console.WriteLine(characterName.Substring(6,2));
            //Console.WriteLine(true);
            //Console.WriteLine(characterName.Contains("ngh"));
            //Console.WriteLine(Math.Pow(2,3));

            //int[] array = {1,2,3,4,5};
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

           
            //SayHi("Sameer Singh");
            //Console.WriteLine(Cube(3));
            //Console.WriteLine(Power(5,6));
            //Console.WriteLine(GetMax(5,8));
            //Console.WriteLine(GetDay(1));

            //string answer = "sam";
            //string inputName = "";
            //int count = 1;
            //bool outOfGuess = false;

            //while (inputName != answer && !outOfGuess)
            //{
            //    if (count <= 4)
            //    {
            //        Console.Write("Enter Word: ");
            //        inputName = Console.ReadLine();
            //        count++;
            //    }
            //    else
            //    {
            //        outOfGuess = true;
            //    }

            //}
            //if (outOfGuess)
            //{
            //    Console.WriteLine("You Lose!!");
            //}
            //else
            //{
            //    Console.WriteLine("You Win!!");
            //}

            //for (int i = 1; i <=5; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            //try
            //{
            //    Console.Write("Enter 1st num: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter 2nd num: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num1 / num2);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            

            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static int Cube(int a)
        {
            return a * a * a;
        }

       static int Power(int a, int b)
        {
            int ans = 1;
            for(int i = 1; i <= b; i++)
            {
                ans = ans * a;
            }
            return ans;
        }

        static int GetMax(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }
    }
}
