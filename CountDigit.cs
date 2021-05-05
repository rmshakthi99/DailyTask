using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CreditCard
    {
        public static ulong number;
        static void CountDigit()
        {
            Console.WriteLine("enter a  number");
            ulong number = ulong.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                number = number / 10;
                sum++;
            }
            Console.WriteLine(+sum);
            if (sum == 15 || sum == 16)
            {
                Console.WriteLine("card digit is valid");
            }
            else
            {
                Console.WriteLine("enter valid card number");
            }
        }


        static  void RevNumber()
        {
            ulong remainder, revNumber=0;
            Console.WriteLine("enter a  number");
            ulong number = ulong.Parse(Console.ReadLine());

            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                revNumber = (revNumber * 10) + remainder;
                Console.WriteLine(+revNumber);
            }
            
        }
        static void ExpDate()
        {
            string pattern = "M/dd/yyyy";
            Console.WriteLine("enter expiry date");
            DateTime d = DateTime.ParseExact(Console.ReadLine(), pattern, null);
            d.ToString("dd MMMM,yyyy");
            DateTime dd = DateTime.Now;
            Console.WriteLine("today is" + dd);
           
            if(d > dd)
            {
                Console.WriteLine("correct date");
            }
            else
            {
                Console.WriteLine("expired date");


            }




        }
        static void CvvNumber()
        {
            Console.WriteLine("enter a  number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                number = number / 10;
                sum++;
            }
            Console.WriteLine(+sum);
            if (sum == 3)
            {
                Console.WriteLine("valid CVV number");
            }
            else
            {
                Console.WriteLine("enter valid CVV number");
            }
        }
        static void Main(String[] args)
        {
            CreditCard.CountDigit();
            RevNumber();
            CvvNumber();
            ExpDate();
            Console.ReadKey();


        }
    }
  
    

    
}
                    


            
        
        
        

    

