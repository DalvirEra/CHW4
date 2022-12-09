Console.WriteLine("Введите 1 число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 9){
    sum += number%10;
    number = number/10;
}
sum += number;
Console.WriteLine(sum);