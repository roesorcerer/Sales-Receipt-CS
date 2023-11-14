# Sales Receipt Program Readme

## Overview
This Sales Receipt program is a simple console application written in C# to help you create sales receipts for customers. It allows you to enter customer information, select items they want to purchase, and calculates the total cost including tax.

## Getting Started
1. Clone or download this repository to your local machine.
2. Make sure you have Visual Studio or a C# development environment installed.
3. Open the project in your development environment.

## Usage
1. Run the program by executing the `SalesReceipt.cs` file.

2. The program will prompt you to enter customer information, including:
   - First name
   - Last name
   - Phone number
   - Email address
   - Full address

3. After entering customer information, you will be asked to choose an item to purchase from a list of available items:
   - Paper
   - Staples
   - Paper Clips
   - Pens
   - Notebook

4. Enter the quantity of the selected item you want to purchase.

5. The program will calculate the subtotal, tax amount, and the total cost for the selected item, and display this information to you.

6. You can repeat steps 3-5 to add more items to the customer's receipt.

7. The program will continuously update the running total as you add more items.

8. If you want to create a receipt for another customer, type "Y" or "y" when prompted. If not, type any other character to exit the program.

## Example
Here's an example of how the program works:
```
Create a sales receipt for a customer
Enter the first name of the customer: John
Enter the last name of the customer: Doe
Enter the customer phone number: 123-456-7890
Enter the email address for the customer: john.doe@example.com
Enter full customer address: 123 Main St, City, State, ZIP
Please choose an item to purchase:
Press 1 to purchase Paper
Press 2 to purchase Staples
Press 3 to purchase Paper Clips
Press 4 to purchase Pens
Press 5 to purchase Notebook
1
You have chosen to purchase Paper
Please enter how many reams of Paper you would like to purchase: 2
Customer information for all customers: John, Doe, 123-456-7890, john.doe@example.com, 123 Main St, City, State, ZIP
You have added the following items: Paper
Total      Tax       Total with tax
$4.00      $0.16      $4.16
Do you want to check cost for another customer(Y/N) 
Y
Enter the first name of the customer: Jane
Enter the last name of the customer: Smith
...
```

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author
[Your Name]

Feel free to reach out if you have any questions or need further assistance. Enjoy using the Sales Receipt program!
