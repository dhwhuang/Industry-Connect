using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Confirmation;

            do
            {
                string Username;
                string Password;
                string EnteredUsername;
                string EnteredPassword;

                //register
                Console.WriteLine("please enter your username");
                Username = Console.ReadLine();
                Console.WriteLine("please enter your password");
                Password = Console.ReadLine();

                string login;

                //Check for command L/l
                do
                {
                    Console.WriteLine("please enter L to login");
                    login = Console.ReadLine().ToUpper();

                    if (login.Equals( "L"))
                    {
                        Console.WriteLine("You have registered successfully");
                    }
                    else
                    {
                        Console.WriteLine("You have entered the incorrect login key, please enter the letter L");
                    }
                } while (!login.Equals("L"));

                string EnterKey;

                do
                {
                    Console.WriteLine("Please press Enter");
                    EnterKey = Console.ReadLine();

                    if (EnterKey == "") //todo
                    {
                        //login 
                        do
                        {
                            Console.WriteLine("Please enter your username for verification");
                            EnteredUsername = Console.ReadLine();
                            Console.WriteLine("Please enter your password for verification");
                            EnteredPassword = Console.ReadLine();
                            

                            if (Username == EnteredUsername && Password == EnteredPassword) //todo equals
                            {
                                Console.WriteLine("You have entered your username and password correctly");
                                Console.WriteLine("You have entered {0} for your username and {1} for your password", EnteredUsername, EnteredPassword);
                            }
                            else
                            {
                                Console.WriteLine("You have entered the incorrect username and password. Please try again");
                                Console.WriteLine("You have entered {0} for your username and {1} for your password", EnteredUsername, EnteredPassword);
                            }
                        } while (Username != EnteredUsername || Password != EnteredPassword);

                    }
                    else
                    {
                        Console.WriteLine("You did not press enter, try again");
                    }
                } while (EnterKey != "");

                Console.WriteLine("Do you want to exit? Type Yes to Exit");
                Confirmation = Console.ReadLine().ToUpper();

            } while (Confirmation != "YES"); //todo equals
        }
        public string Register()
        {

        }
    }
}
