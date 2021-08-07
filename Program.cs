using ACMEFactoryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to ACME Factory at Tokyo");
            //Console.WriteLine("Please login with you credentials");
            ////LogicForFloorManager or Regular Worker
            //if (/*FloorManager*/)
            //{
            //    Console.WriteLine("Choose what activity do you want to perform");
            //    Console.WriteLine("1.Get all employee working hours report");
            //    Console.WriteLine("2. Get all machine working hours report");
            //}
            //else if(/*Regular Worker*/)
            //{
            //    Console.WriteLine("Choose what activity do you want to perform");
            //    Console.WriteLine("1. Log Start Time for the Shift");
            //    Console.WriteLine("2. Log End Time for the Shift");
            //    Console.WriteLine("3. Log Start Time for the machine");
            //    Console.WriteLine("3. Log End Time for the machine");

            //}
            //else
            //{
            //    Console.WriteLine("You are not authorised to login/Login credentials is incorrect");
            //}

            WorkerBL objBL = new WorkerBL();

            Console.WriteLine("***************Welcome to ACME Factory at Tokyo*************************");
            Console.WriteLine("Please select from below :\n1.Factory Manager \n2. Worker");
            int choice = Convert.ToInt32(Console.ReadLine());
            int id;
            string username, password;
            switch (choice)
            {
                case 1 : Console.WriteLine("Welcome Factory manager.Please enter you Username and Password");
                    username = Console.ReadLine();
                    password = Console.ReadLine();
                    if (username == "FactoryTokyo" && password == "Tokyo@2021")
                    {
                        Console.WriteLine("Successful Login!!");
                        Console.WriteLine("Choose what activity do you want to perform");
                        Console.WriteLine("1.Get all employee working hours report");
                        Console.WriteLine("2. Get all machine working hours report");
                        int chFM;
                        chFM = Convert.ToInt32(Console.ReadLine());
                        switch (chFM)
                        {
                            case 1://call method
                                break;
                            case 2://call method
                                break;
                            default:Console.WriteLine("Invalid choice!!");
                                break;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Invalid Username or Password!!");

                    }
                    break;

                case 2: Console.WriteLine("Please enter your ID, Username and Password");
                    id = Convert.ToInt32(Console.ReadLine());
                    username = Console.ReadLine();
                    password = Console.ReadLine();
                    //call function to check credentails.
                    int re;
                    re = objBL.LoginCheck(id, username, password, out int rowaffected);
                     if(re==1)
                    {
                        Console.WriteLine("Login Successful!!");
                        Console.WriteLine("Choose what activity do you want to perform");
                        Console.WriteLine("1. Log Start Time for the Shift");
                        Console.WriteLine("2. Log End Time for the Shift");
                        Console.WriteLine("3. Log Start Time for the machine");
                        Console.WriteLine("4. Log End Time for the machine");
                        int chWKR;
                        chWKR = Convert.ToInt32(Console.ReadLine());
                        switch (chWKR)
                        {
                            case 1://Function calL
                                try
                                {
                                    
                                    Console.WriteLine("Enter time");
                                    int no = Convert.ToInt32(Console.ReadLine());
                                    
                                    int result =objBL.InsertALoginTime(no, out int rowAffected);
                                  
                                    Console.WriteLine($"Returned Value =" + result);
                                    Console.WriteLine(rowAffected + " row affected");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Something went wrong in inserting!!!!");

                                }
                                break;
                            case 2://Function call
                                
                                try
                                {

                                    Console.WriteLine("Enter time");
                                    int no = Convert.ToInt32(Console.ReadLine());

                                    int result = objBL.InsertALogoutTime(no, out int rowAffected);

                                    Console.WriteLine($"Returned Value =" + result);
                                    Console.WriteLine(rowAffected + " row affected");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Something went wrong in inserting!!!!");

                                }
                                break;
                            case 3://Function call
                                Console.WriteLine("Enter For Machine no");
                                int ch = Convert.ToInt32(Console.ReadLine());
                                if (ch == 1)
                                {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());

                                        int result = objBL.InsertALoginTimeForM1(no, out int rowAffected);

                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                else if (ch == 2)
                                {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());

                                        int result = objBL.InsertALoginTimeForM2(no, out int rowAffected);

                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                else
                                {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());

                                        int result = objBL.InsertALoginTimeForM3(no, out int rowAffected);

                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                break;
                            case 4://Function call
                                Console.WriteLine("Enter For Machine no");
                                int cho = Convert.ToInt32(Console.ReadLine());
                                if (cho == 1)
                                {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());

                                        int result = objBL.InsertALogoutTimeForM1(no, out int rowAffected);

                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                else if (cho == 2)
                                {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());

                                        int result = objBL.InsertALogoutTimeForM2(no, out int rowaffected);

                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                else {
                                    try
                                    {

                                        Console.WriteLine("Enter time");
                                        int no = Convert.ToInt32(Console.ReadLine());
                                        int result = objBL.InsertALogoutTimeForM3(no, out int rowaffected);


                                        Console.WriteLine($"Returned Value =" + result);
                                        Console.WriteLine(rowAffected + " row affected");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Something went wrong in inserting!!!!");

                                    }
                                }
                                break;
                            default:Console.WriteLine("Invalid choice!!");
                                break;


                        }
                    }

                    else {
                        Console.WriteLine("Invalid Username Or Password");

                    }


                        break;

                

                default: Console.WriteLine("Invalid Choice .Please enter proper choice from 1,2.Thankyou!!");
                    break;




            }
        }
    }
}
