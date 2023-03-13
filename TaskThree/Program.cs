string[] studentsG1 = { "Damjan", "Marko", "Zarko", "Slave", "Elena" };
string[] studentsG2 = { "Dana", "Petre", "Kiril", "Mario", "Dejan" };
Console.WriteLine("Please insert: 1 or 2");
int printGroup =Convert.ToInt32 (Console.ReadLine());
switch (printGroup)
{
    case 1:
        {
            Console.WriteLine("The students of G1 are: ");
            foreach (string studentFromG1 in studentsG1)
            {
                Console.WriteLine(studentFromG1);
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("The students of G2 are: ");
            foreach (string studentFromG2 in studentsG2)
            {
                Console.WriteLine(studentFromG2);
            }
            break;
        }
    default:
        Console.WriteLine("ERROR!");
        break;
}