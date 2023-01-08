

using Employee;

Employees employees = new();

List<Employees> employess = new List<Employees>();




List<Employees> GetAll()
{
    List<Employees> employees = new List<Employees>();

    Employees employe1 = new Employees()
    {
        Name = "Shaiq",
        Surname = "Kazimov",
        Birthday = new DateTime(1995,05,05),
        Salary = 2500      
    };

    employees.Add(employe1);


    Employees employe2 = new Employees()
    {
        Name = "Aqshin",
        Surname = "Hummetov",
        Birthday = new DateTime(1995,05,05),
        Salary = 2200      
    };

    employees.Add(employe2);


    Employees employe3 = new Employees()
    {
        Name = "Cavid",
        Surname = "Ismayilzade",
        Birthday = new DateTime(1999,03,03),
        Salary = 100
    };

    employees.Add(employe3);

   
    Employees employe4 = new Employees()
    {
        Name = "Alakbar",
        Surname = "Hasanov",
        Birthday = new DateTime(2002, 05, 05),
        Salary = 1100
    };

    employees.Add(employe4);

    return employees;

}


DateTime startBirthday = new DateTime(1994, 05, 05);
DateTime endBirthday = new DateTime(2002, 05, 05);
double salary = 2000;


int GetEmployeesSalary(DateTime startBirthday, DateTime endBirthday, double salary)
{
    var employees = GetAll().FindAll(m => m.Birthday > startBirthday && m.Birthday < endBirthday && m.Salary > salary);

    return employees.Count;
    
}


Console.WriteLine(GetEmployeesSalary(startBirthday, endBirthday, salary));
