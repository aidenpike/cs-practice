using System;
using System.IO.Pipes;

class practice {
    static double predict_sales(double total_sales, double profit_percentage){
        return Math.Round(total_sales * profit_percentage, 2);
    }

    static double get_final_price(double purchase_amount, double state_tax, double county_tax){
        return Math.Round(purchase_amount * (1 + state_tax) * (1 + county_tax), 2); 
    }

    static string get_day(int day_number){
        string[] days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]; 

        return days[day_number - 1];
    }

    static void Main(){
        //Predicting Sales
        double profit_percentage = 0.23;

        Console.Write("Enter projected amount of total sales: ");
        double total_sales = Convert.ToDouble(Console.ReadLine());
        double annual_profit = predict_sales(total_sales, profit_percentage);

        Console.WriteLine("Annual Profit: " + Convert.ToString(annual_profit));

        //Calculating Sales Tax
        double state_tax = 0.5;
        double county_tax = 0.025;

        Console.Write("Enter purchase amount: ");
        double purchase_amount = Convert.ToDouble(Console.ReadLine());

        double final_price = get_final_price(purchase_amount, state_tax, county_tax);

        Console.WriteLine("Your final price is " + Convert.ToString(final_price));

        //Day of the Week
        Console.WriteLine("Enter a day number between 1-7: ");
        int day_number = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Your day is " + get_day(day_number));
    }
}