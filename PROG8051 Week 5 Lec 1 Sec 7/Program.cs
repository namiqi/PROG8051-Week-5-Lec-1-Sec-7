using System;


namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2D Array
            string[,] Accounts = { { "A", "123", "5000" }, { "B", "1234", "50000" } };

            // Exercise : ATM simulation

            // step 1 : validation

            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            int rows = Accounts.GetLength(0);
            int cols = Accounts.GetLength(1);

            int userid = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Accounts[i, 0].Equals(username))
                    {
                        if (Accounts[i, 1].Equals(password))
                        {
                            Console.WriteLine("Successful Login");
                            userid = i;
                            break;
                        }
                    };
                }
            }

            // Step 2 : Display Menu

            Console.WriteLine("1. Check Balance \n2. Deposit \n3. Withdraw \n4.End");

            Console.WriteLine("Please choose action: ");
            string action = Console.ReadLine();
            // Step 3 : Check Balanse
            if (action == "1")
            {
                Console.WriteLine("Your balance is: "+ Accounts[userid, 2]);
            }

            // Step 4 : Deposit
            else if (action == "2")
            {
                Console.WriteLine("Please enter amount: ");
                string amountDepopsit = Console.ReadLine();
                Accounts[userid, 2] = Convert.ToString(Convert.ToInt32(Accounts[userid, 2]) + Convert.ToInt32(amountDepopsit));
                Console.WriteLine("Your balance is: " + Accounts[userid, 2]);
            }
            // Step 5 : Withdraw
            else if (action == "3")
            {
                Console.WriteLine("Please enter amount: ");
                string amountWithdraw = Console.ReadLine();
                Accounts[userid, 2] = Convert.ToString(Convert.ToInt32(Accounts[userid, 2]) - Convert.ToInt32(amountWithdraw));
                Console.WriteLine("Your balance is: " + Accounts[userid, 2]);
            }
            // Step 6 : End

            else if (action == "4")
            {
                Console.WriteLine("Remove your card ");
                
            }








            // How to create a 2D array


            // How to access element of an 2D array

            Console.WriteLine(Accounts[0,1]);

            // How to change the element of an 2D array

            Accounts[0, 1] = "234";

            Console.WriteLine(Accounts[0, 1]);

            Console.WriteLine("--------------------");

            // Loop through 2D array

            foreach(string account in Accounts)
            {
                Console.WriteLine(account); 
            }
            Console.WriteLine("--------------------");

            
            Console.WriteLine("--------------------");

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.WriteLine(Accounts[i,j]);
                }
            }



            // Exercise:Go through the list of ages and tell us how many people are udner 10 years old, 18years old, above 18

            int[] ages = { 13,14,32,42,13,15,16,12,9,5,3,2,20, 21, 20 };

            // counting
            int countUnder10 = 0;
            int countUnder18Over10 = 0;
            int over18 = 0;

            foreach (int age in ages)
            {
                if (age < 10)
                {
                    countUnder10++;
                }

                else if( age > 10 && age < 18) {
                    countUnder18Over10++;
                }

                else if (age >= 18)
                {
                    over18++;
                }
                else
                {
                    Console.WriteLine("Please enter correct input");
                }

            }
            Console.WriteLine($"{countUnder10} people are under 10, {countUnder18Over10} people are between the ages of 10 \n" +
                $" and 18, {over18} are over 18");


            Console.WriteLine("--------------------");







            // How to run a loop through an array
            // Option 1
            string[] names = { "Mayank", "Harpreet", "Naiya" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("--------------------");

            // Option 2
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");


            // How to declare one



            int[] studentAges = { 20, 21, 20 };

            // How to Access to the element of an Array

            Console.WriteLine("This is before: " + names[1]);

            // Length of an Array(1D)
            Console.WriteLine(names[names.Length-1]);


            // Chnage an element
            names[1] = "SMBYELSE";

            Console.WriteLine("This is after: "+names[1]);

        }
    }
}


