
int[] inputs = { 1, 2, 3, 4, 5, 15, 55, 60, 100 };

for (int i = 0; i < inputs.Length; i++)
{
  Console.Write($"{inputs[i]} ");
  if(inputs[i] % 3 == 0)
  {
    Console.Write("Fizz");
  }
  if(inputs[i] % 5 == 0)
  {
    Console.Write("Buzz");
  }
  Console.Write("\n");
}