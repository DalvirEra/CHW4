Console.WriteLine("Введите 1 число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOrig = number;
int sum = 0;
while (number > 10){
    if ((numberOrig)%(number%10) == 0){
        sum += number%10;
    }
    number = number/10;
}
if ((number%10)%number == 0){
        sum += number%10;
    }
Console.WriteLine(sum);