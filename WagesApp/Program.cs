namespace WagesApp;

class Program
{

    // global variables
    static List<string> DAYS = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };


    // Methods or Functions
    static void OneEmployee()
    {
        // localvariables
        string employeename;
        List<int> hoursWorked = new List<int>();

        // Input employee name
        Console.WriteLine("Enter The Employee's Name:\n");
        employeename = Console.ReadLine();


        // Input the number of hours worked for each day
        foreach (var day in DAYS)
        {
            Console.WriteLine($"Enter the hours worked on {day}:\n");
            hoursWorked.Add(int.Parse(Console.ReadLine()));
        }


        // Calculate total hours worked

        // Calculate weekly wages (total hours x pay rate)

        // Determine if employee qualifies for a bonus (>30 hours for the week)

        // If employee qualifies for a bonus, add bonus to weekly pay

        // Calculate tax (pay < 450, then tax = 7.5% else tax = 8%)

        // Display employees pay summary
    }

    // when run... 
    static void Main(string[] args)
    {

        DAYS.AsReadOnly();
        // Call OneEmployee Method
        OneEmployee();

        // Display total amount paid to all employees

        // Display employee pay summary


    }

}