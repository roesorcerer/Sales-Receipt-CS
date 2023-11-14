using System;
using System.Linq;
using System.Collections.Generic;


namespace CourseProject
{
    class SalesReceipt
    {
        static void Main(string[] args)
        {
            //strings for customer info, items, and totals.
            List<string> custInfo = new List<string>();
            List<string> item = new List<string>();
            List<double> itemPrice = new List<double>();
            List<double> totalTax = new List<double>();
            List<double> completeCost = new List<double>();
            //variable declarations
            string paper = "Paper";
            string staples = "Staples";
            string paperClips = "Paper Clips";
            string pens = "Pens";
            string notebook = "Notebook";
            int paperCost = 2;
            int stapleCost = 1;
            int paperClipCost = 1;
            int penCost = 3;
            int notebookCost = 5;
            double tax = 0.04;

            //asking for customer input information 
            Console.WriteLine("Create a sales receipt for a customer");

            while (true)//program will run as long as user says yes.
            {
                Console.WriteLine("Enter the first name of the customer:");
                string firstName = Console.ReadLine();
                custInfo.Add(firstName);
                //all inputs will be added to string until the user asks to end program. 
                Console.WriteLine("Enter the last name of the customer:");
                string lastName = Console.ReadLine();
                custInfo.Add(lastName);

                Console.WriteLine("Enter the customer phone number:");
                string phoneNumber = Console.ReadLine();
                custInfo.Add(phoneNumber);

                Console.WriteLine("Enter the email address for the customer:");
                string emailAddress = Console.ReadLine();
                custInfo.Add(emailAddress);

                Console.WriteLine("Enter full customer address:");
                string address = Console.ReadLine();
                custInfo.Add(address);
                //choice for what item the user would like to purchase
                Console.WriteLine("Please choose an item to purchase:");
                Console.WriteLine("Press 1 to purchase " + paper);
                Console.WriteLine("Press 2 to purchase " + staples);
                Console.WriteLine("Press 3 to purchase " + paperClips);
                Console.WriteLine("Press 4 to purchase " + pens);
                Console.WriteLine("Press 5 to purchase " + notebook);
                int purchaseItem = Convert.ToInt32(Console.ReadLine());

                switch (purchaseItem)
                {//swutch statement for what they would like to purchase 
                    case 1:
                        Console.WriteLine("You have chosen to purchase " + paper);
                        item.Add(paper);
                        Console.WriteLine("Please enter how many reems of " + paper + " you would like to purchase:");
                        int reemsPaper = Convert.ToInt32(Console.ReadLine());
                        //the calculations are completed here and added to string so that the program can calculate totals at the end. 
                        double paperTotal = reemsPaper * paperCost;
                        itemPrice.Add(paperTotal);
                        double paperTax = paperTotal * tax;
                        totalTax.Add(paperTax);
                        double total1 = paperTotal + paperTax;
                        completeCost.Add(total1);
                        break;
                    case 2: //case statements are all similar and preform the same thing
                        Console.WriteLine("You have chosen to purchase " + staples);
                        item.Add(staples);
                        Console.WriteLine("Please enter how many boxes of " + staples + " you would like to purchase:");
                        int stapleBoxes = Convert.ToInt32(Console.ReadLine());
                        double stapleTotal = stapleBoxes * stapleCost;
                        itemPrice.Add(stapleTotal);
                        double stapleTax = stapleTotal * tax;
                        totalTax.Add(stapleTax);
                        double total2 = stapleTotal + stapleTax;
                        completeCost.Add(total2);
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to purchase " + paperClips);
                        item.Add(paperClips);
                        Console.WriteLine("Please enter how many boxes of " + paperClips + " you would like to purchase:");
                        int clipBoxes = Convert.ToInt32(Console.ReadLine());
                        double clipTotal = clipBoxes * paperClipCost;
                        itemPrice.Add(clipTotal);
                        double clipTax = clipTotal * tax;
                        totalTax.Add(clipTax);
                        double total3 = clipTotal + clipTax;
                        completeCost.Add(total3);
                        break;
                    case 4:
                        Console.WriteLine("You have chosen to purchase " + pens);
                        item.Add(pens);
                        Console.WriteLine("Please enter how many boxes of " + pens + " you would like to purchase:");
                        int penBoxes = Convert.ToInt32(Console.ReadLine());
                        double penTotal = penBoxes * penCost;
                        itemPrice.Add(penTotal);
                        double penTax = penTotal * tax;
                        totalTax.Add(penTax);
                        double total4 = penTotal + penTax;
                        completeCost.Add(total4);
                        break;
                    case 5:
                        Console.WriteLine("You have chosen to purchase " + notebook);
                        item.Add(notebook);
                        Console.WriteLine("Please enter how many of " + notebook + " you would like to purchase:");
                        int notebookNumber = Convert.ToInt32(Console.ReadLine());
                        double notebookTotal = notebookNumber * notebookCost;
                        itemPrice.Add(notebookTotal);
                        double notebookTax = notebookTotal * tax;
                        totalTax.Add(notebookTax);
                        double total5 = notebookTotal + notebookTax;
                        completeCost.Add(total5);
                        break;
                }

                //output statements that will show the totals with the custoemr name that can be used as receipt. 
                Console.WriteLine("Customer information for all customers:");
                Console.WriteLine(string.Join(", ", custInfo));//join all strings 
                Console.WriteLine("You have added the following items:" + string.Join(",", item));//items purchased 
                Console.WriteLine("Total\t\t" + "Tax\t\t" + "Total with tax");
                double taxSum = totalTax.Sum();//calculations to add all totals in strings for output
                double priceSum = itemPrice.Sum();
                double sum = itemPrice.Sum() + totalTax.Sum() + completeCost.Sum();
                Console.WriteLine("$" + priceSum + "\t\t" + "$" + taxSum + "\t\t" + "$" + sum);//this is the running total. It will update after each input. 


                Console.WriteLine("Do you want to check cost for another customer(Y/N) ");//statement for user to end program. 
                String nextOption = Console.ReadLine();
                if (nextOption.Equals("Y") || nextOption.Equals("y"))
                {

                    continue;
                }
                else
                {
                    break;

                }
            }
        }
    }
}
