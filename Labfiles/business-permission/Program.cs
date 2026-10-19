
string permission = "Manager";
int level = 55;


if (level > 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if(level <= 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}
else if(level >= 20 && permission.Contains("Manager"))
{
  Console.WriteLine("Contact and Admin for access.");
}
else
{
  Console.WriteLine("You do not have sufficient privileges.");
}
