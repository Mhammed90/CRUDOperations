using System;
using System.Reflection.Metadata;
using static CRUDOperations.Program;

namespace CRUDOperations
{
    public partial class Program
    {  
       
       public class User
        {
            static List<User> users=new List<User>();
            private static int curId = 1;
            private  int userID { get; set;}
            private string? name { get; set; }
            private string? email { get; set; }
            private string? phoneNumber { get; set; }
            private User(string Name, string Email, string PhoneNumber)
            {
                this.userID = curId++;
                this.name = Name;
                this.email = Email;
                this.phoneNumber = PhoneNumber;
            }
            public static void AddUser()
            {
              
                Console.Write("Enter user Name   ");
                var Name = Console.ReadLine();
                Console.WriteLine() ;
                Console.Write("Enter Use email  ");
                var Email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter User Phone   ");
                var PhoneNumber= Console.ReadLine();
                users.Add(new User(Name,Email,PhoneNumber));
                Console.WriteLine("===========================Was Added Successfuly==========================");
                
            }
           
          public static void PrintAlluser()
            {
                if (users.Count() > 0)
                {
                    Console.WriteLine("=======================The users=====================");
       
                    foreach (var user in users)
                    { 
                        Console.WriteLine($"User Id  :     {user.userID}");
                        Console.WriteLine($"user name :     {user.name}");
                        Console.WriteLine($"user Email:      {user.email}");
                        Console.WriteLine($"user PhoneNumber :    {user.phoneNumber}");
                        Console.WriteLine("----------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("There's no users was added :");
                    Console.WriteLine();
                }
            }

            public static void PrintSingelUser()
            {
                Console.Write("Enter id of the User to print : ");
                int id=int.Parse(Console.ReadLine());
                User f = users.FirstOrDefault(i => i.userID==id);
                if (f == null)
                {
                    Console.WriteLine("Not Found User");
                }
                else
                {
                    Console.WriteLine($"User Id  :     {f.userID}");
                    Console.WriteLine($"user name :     {f.name}");
                    Console.WriteLine($"user Email:      {f.email}");
                    Console.WriteLine($"user PhoneNumber :    {f.phoneNumber}");
                    Console.WriteLine("----------------------------------------------");
                }
            }
            public static void Update()
            {
                Console.WriteLine();
                Console.Write("Enter the user id want to update his data ");
                int IId=int.Parse(Console.ReadLine());
                User f=users.FirstOrDefault(i=>i.userID==IId);
                Console.WriteLine(f);
                if (f != null)
                {
                    bool flag = false;
                    Console.WriteLine("1- Edit Name\n2- Edit Email\n3- Edit PhoneNumber");
                    int val=int.Parse(Console.ReadLine());
                    switch(val)
                    {
                        case 1:
                            Console.Write("Enter New Name : ");
                            var newName= Console.ReadLine();
                            f.name = newName;
                            break;
                        case 2:
                            Console.Write("Enter New Email : ");
                            var newEmail = Console.ReadLine();
                            f.email = newEmail;
                            break;
                        case 3:
                            Console.WriteLine("Enter New PhoneNumber : ");
                            var newPhoneNumber = Console.ReadLine();
                            f.phoneNumber = newPhoneNumber;
                            break;
                        default :
                            flag = true;
                            Console.WriteLine("Wrong Choice ");
                            break;
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("No updates occured");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your updated data");
                        Console.WriteLine($"User Id  :     {f.userID}");
                        Console.WriteLine($"user name :     {f.name}");
                        Console.WriteLine($"user Email:      {f.email}");
                        Console.WriteLine($"user PhoneNumber :    {f.phoneNumber}");
                        Console.WriteLine("----------------------------------------------");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not found user");
                }
            }
            public static void DeleteUser()
            {
                Console.WriteLine();
                Console.Write("Enter user id : ");
                int IId = int.Parse(Console.ReadLine());
                User f = users.FirstOrDefault(i => i.userID == IId);
                if(f != null)
                {
                    users.Remove(f);
                }
                else
                {
                    Console.WriteLine("The User Not Exist");
                }
            }
            public static int NumberOfRegisterdUsers()
            {
                Console.Write("Number of user exist :");
                return users.Count();
            }
       
        }

    }
}