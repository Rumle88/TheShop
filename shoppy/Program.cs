using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppy
{
    public class SampleEventArgs
    {
        public SampleEventArgs(string s) { Text = s; }
        public String Text
        {
            get;
            private set;
        } // readonly
    }

    class Program
    {

        public delegate void HappyHandler(object sender, SampleEventArgs e);
        public event HappyHandler day;

        public void happy(object sender, SampleEventArgs e)
        {
 
        }
         static void Main(string[] args)
        {

            Program test = new Program();
            //test.day += new HappyHandle;
            //test.day(test, new SampleEventArgs("t10"));
            //test.Main2();
        }

        public void Main2()
        {
            string user;
            string pass ;
            bool stop = false;
            Console.WriteLine("Press 1 for login \nPress 2 for Startpage");

           // anonamuse class
            var name = new [] { new { test = "a1",set = "a2" } ,new{ test= "b1",set = "b2"}};

           // name[1].test
            Console.WriteLine("værdi 0 er ={0}, og værdi 1 ={1}",name[0].test,name[1].set);
            List<string> username = new List<string>();
            username.Add("hans");
            username.Add("peter");
            username.Add("jan");
            username.Add("mark");

            int [] i = new int [10];

            List<medarbejder> test = new 
          
            List<string> password = new List<string>();
            password.Add("1234");
            password.Add("qqq");
            password.Add("www");
            password.Add("eee");
          
            do
            {
                var input = Console.ReadKey();
           
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    
                    Console.WriteLine("Welcome to the login site\n");
                    Console.WriteLine("Please Input Username");
                    user = Console.ReadLine();
                    Console.WriteLine("Please Input Password");
                    pass = Console.ReadLine();
                    Console.WriteLine(user.ToString());
                    Console.WriteLine(pass.ToString());
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Welcome to our Shop ABM\nWe sell Anime Based Merchandise \nPlease Login to see the Shop\n");
                    Console.WriteLine("Press 1 for login \nPress 0 for Exit");
                    if (input.Key == ConsoleKey.D1)
                    {
                        goto case ConsoleKey.D1;
                    }
                    
                    break;
                default:
                    if (input.Key == ConsoleKey.D0)
                    {
                        stop = true;  
                    }
                    
                    break;
            }
            } while (stop == false);
            
            


            Console.ReadKey();
        }

      class medarbejder
        {
            string fornavn;
            string efternavn;
            int id;
            List<string> tlf;
        }
        static List<medarbejder> = new{}
     
    }
}
