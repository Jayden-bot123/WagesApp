namespace WagesApp;

class Program
{

    // Global Variables
    static List<string> DAYS = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

    // Constant Variable
    static readonly float PAYRATE = 22.00f, TAXA = 0.075f, TAXB = 0.08f;

    // Methods or Functions
    static string PaySummary(string name, List<int> hrsWorked)
    {
        return "----- Pay Summary -----\n" +
            $"Employee Name: {name}\n" +
            $"Hours Worked: {SumHoursWorked(hrsWorked)}\n" +
            $"Bonus Owed: {CalculateBonus(hrsWorked)}\n" +
            $"Gross Pay: {CalculateWages(hrsWorked) + CalculateBonus(hrsWorked)}\n" +
            $"Net Pay: ${CalculateWages(hrsWorked) + CalculateBonus(hrsWorked) - CalculateTax(hrsWorked)}";
    }

    // Calculate tax (pay < 450, then tax = 7.5% else tax = 8%)

    static float CalculateTax(List<int> hrsWorked)
    {

        if (CalculateWages(hrsWorked)+CalculateBonus(hrsWorked) < 450)
        {
            return (CalculateWages(hrsWorked) + CalculateBonus(hrsWorked)) * TAXA;
        }

        return (CalculateWages(hrsWorked) + CalculateBonus(hrsWorked)) * TAXB;
    }

    // Determine if employee qualifies for a bonus (>30 hours for the week)

    static float CalculateBonus(List<int> hrsWorked)
    {

        if (SumHoursWorked(hrsWorked) > 30)
        {
            return 5 * PAYRATE;
        }
        
        return 0;
    }

    // Calculate weekly wages (total hours x pay rate)

    static float CalculateWages(List<int> hrsWorked)
    {
        return (float)Math.Round(SumHoursWorked(hrsWorked) * PAYRATE,2);
    }

    // Calculate total hours worked

    static int SumHoursWorked(List<int> hrsWorked)
    {
        int sumHoursWorked = 0;

        foreach (int hour in hrsWorked)
        {
            sumHoursWorked += hour;
        }

        return sumHoursWorked;
    }
    static void OneEmployee()
    {
        // Local Variables
        string employeename;
        List<int> hoursWorked = new List<int>();

        // Input Employee Name
        Console.WriteLine("Enter The Employee's Name:\n");
        employeename = Console.ReadLine();


        // Input the number of hours worked for each day
        foreach (var day in DAYS)
        {
            Console.WriteLine($"Enter the hours worked on {day}:\n");
            hoursWorked.Add(int.Parse(Console.ReadLine()));
        }


        // Display employees pay summary
        Console.WriteLine(PaySummary(employeename, hoursWorked));
        
    }

    // When run... 
    static void Main(string[] args)
    {

        DAYS.AsReadOnly();
        // Call OneEmployee Method
        OneEmployee();

        // Display total amount paid to all employees

        // Display employee pay summary


    }

}