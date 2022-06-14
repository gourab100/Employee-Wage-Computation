using System;

Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");

int workinghours = 0;
int wagesperhours = 20;
double totalwage = 0;
const int present = 2;
const int parttime = 1;
int daliy_wage = 0;
const int workingday = 20;
for (int i = 0; i < workingday; i++)
{

    Random random = new Random();
    int employee = random.Next(0, 3);


    switch (employee)
    {
        case parttime:

            const int parttimeperhours = 4;
            Console.WriteLine("parttimer");
            daliy_wage = parttimeperhours * wagesperhours;
            totalwage += daliy_wage;
            Console.WriteLine("daliy employee wage :" + daliy_wage);
            break;
        case present:
            const int fulldayperhours = 8;
            Console.WriteLine("present");
            daliy_wage = fulldayperhours * wagesperhours;
            totalwage += daliy_wage;
            Console.WriteLine("daliy employee wage :" + daliy_wage);
            break;
        default:
            Console.WriteLine("Absent");
            break;
    }

}
Console.WriteLine("total wage: " + totalwage);
