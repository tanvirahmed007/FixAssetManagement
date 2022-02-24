namespace FixAssetManagement.Controllers
{
    public class BalanceService
    {

        public void StraightLine()
        {

            // for depreciation value automatic with time by using for loop and without for loop

            double BookValue, RemainingBalance;
            int Year = 0;
            int YearForm = 0;
            Console.Write("Enter your Asset Value: ");

            BookValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Year of Service: ");

            Year = Convert.ToInt32(Console.ReadLine());

            Console.Write("In Service from: (xxxx)");

            YearForm = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Year of Time: ");

            //Future = Convert.ToInt32(Console.ReadLine());

            //var FutureTime = (DateTime.Now.Year + Year);

            RemainingBalance = BookValue - ((BookValue / Year) * (DateTime.Now.Year - YearForm));
            Console.WriteLine("Value of Remaining Balance: {0}", RemainingBalance);

            //for(int i=FutureTime; i<=DateTime.Now.Year; i--)
            //{
            //StaticBalance = (BookValue - 0)/Year;
            //RemainingBalance = BookValue - StaticBalance;

            // Console.WriteLine("Value of Remaining Balance: {0}", RemainingBalance);
            // }

        }

        public void DoubleDeclining()
        {
            Console.Write("Enter your Asset Value: ");
            decimal bookValue = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter total planned service year: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter purchase year: ");
            int purchaseYears = Convert.ToInt32(Console.ReadLine());

            decimal doubleDepreciationRate = (((decimal)1 / years) * 100 * 2);
            int yearOfService = DateTime.Now.Year - purchaseYears;

            for (int i = 0; i < yearOfService; i++)
            {
                decimal depreciationAmount = (decimal)(bookValue * doubleDepreciationRate) / 100;
                Console.Write("Depreciation Amount of year ");
                Console.Write(i + 1);
                Console.Write(" - ");
                Console.WriteLine(depreciationAmount);
                bookValue = bookValue - depreciationAmount;
            }

            Console.Write("Current bookvalue: ");
            Console.WriteLine(bookValue);

            Console.ReadLine();
        }

    }
    
}
