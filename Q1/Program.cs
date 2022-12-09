Console.WriteLine("Введите 1 число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = numberA;
for (int i = 1; i<numberB; i++){
    sum *= numberA;
}
Console.WriteLine(sum);