using System;
using System.IO.Pipes;

class practice {
    static double predict_sales(double total_sales, double profit_percentage){
        return Math.Round(total_sales * profit_percentage, 2);
    }
    static void Main(){
        //Predicting Sales
        double profit_percentage = 0.23;

        Console.Write("Enter projected amount of total sales: ");
        double total_sales = Convert.ToDouble(Console.ReadLine());
        double annual_profit = predict_sales(total_sales, profit_percentage);

        Console.WriteLine("Annual Profit: " + Convert.ToString(annual_profit));
    }
}