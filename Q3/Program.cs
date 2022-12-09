int[] array = new int[10];
for (int i = 0; i < 10;){
    int numberOrig = new Random().Next(10,1001);
    int number = numberOrig;
    int sum = 0;
    int mult = 1;
    while (number > 9){
        sum += number%10;
        mult *= number%10;
        number = number/10;
    }
    sum += number;
    mult *= number;
    if (mult%sum == 0){
        array[i] = numberOrig;
        i++;
    }
}
ArrayPrint(array);

void ArrayPrint(int[] array){
    Console.WriteLine("Массив: ");
    foreach (int a in array){
        Console.Write(a + " ");
    }
}