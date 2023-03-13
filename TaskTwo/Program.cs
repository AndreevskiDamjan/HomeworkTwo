Console.WriteLine("Please input 6 numbers.");
int[] newArray = new int[6];
int sum = 0;
for (int i = 0; i < 6; i++)
{
    newArray[i] = Convert.ToInt32(Console.ReadLine());
    if (newArray[i] %2 == 0)
    {
      sum += newArray[i];
    }
 }
Console.WriteLine("The sum of the even numbers from your input is: " + sum);
