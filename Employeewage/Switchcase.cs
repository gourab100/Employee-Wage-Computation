Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");

int fulldayperhours = 8;
int workinghours = 0;
int wagesperhours = 20;
const int present = 2;
const int parttime = 1;
int daliy_wage = 0;
Random random = new Random();
int employee = random.Next(0, 3);

switch (employee)
{
    case parttime:
        workinghours = workinghours + fulldayperhours;
        Console.WriteLine("parttimer");
        break;
    case present:
        workinghours = (fulldayperhours - workinghours) / 2;
        Console.WriteLine("present");
        break;
    default:
        Console.WriteLine("Absent");
        break;
}

daliy_wage = fulldayperhours * wagesperhours;
Console.WriteLine("daliy employee wage :" + daliy_wage);