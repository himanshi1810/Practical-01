string userResponse;
Console.WriteLine("Enter Your Name :- ");
userResponse = Console.ReadLine();
if(Convert.ToBoolean(int.Parse(userResponse)))
{
    Console.WriteLine("The entered value is a integer");
}
