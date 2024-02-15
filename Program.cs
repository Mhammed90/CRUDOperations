namespace CRUDOperations
{
    public partial class Program
    {
        static void Main(string[] args)
        {
        
            while (true)
            {
                Console.WriteLine("CRUD operationns\n");
            
               repeat:
                
                Console.WriteLine(" 1- Add User:\n 2- Update User:\n 3- Delete User:\n 4- Print all Users:\n 5- Print Single user:\n 6- Number of User:\n ");
                Console.Write(" What operation You want do :   ");
                int OperationNumber = Convert.ToInt32(Console.ReadLine());
                switch (OperationNumber)
                {
                    case 1:
                        User.AddUser();
                        break;
                    case 2:
                        User.Update();
                        break;
                    case 3:
                        User.DeleteUser();
                        break;
                    case 4:
                        User.PrintAlluser();
                        break;
                   case 5:
                        User.PrintSingelUser();
                        break;
                    case 6:
                        Console.WriteLine(User.NumberOfRegisterdUsers());
                        break;
                    default: 
                        Console.WriteLine("Wrong choice! Please Enter a valid choice");
                          goto repeat;
                        break;
                      
                }

                Console.Write("Are you sure you want to do anything else (YES/NO) :   ");
                var ChoiceAnswer = Console.ReadLine();
                ChoiceAnswer = ChoiceAnswer.ToLower();
                if (ChoiceAnswer == "yes")
                {
                  goto repeat;
                }
                else
                {
                    break;
                }
            }
        }

    }
}