//Вводим размер массива

Console.WriteLine("Введите длину массива строк");

int arraySize = Convert.ToInt32(Console.ReadLine());
String[] Arr = new String[arraySize];

//Вводим строчные элементы массива 

Console.WriteLine($"Введите строки в количестве {arraySize}-ти");
for(int i = 0; i < arraySize; i++) {

Arr[i] = Console.ReadLine();

}

//метод печати ненулевого массива

void printArray (String[] ar) {
foreach (var item in ar)
{
    if (item != null) Console.Write(item + "; ");
}
Console.WriteLine(" ");
}
printArray(Arr);

//Главный метод

String[] methodLengthOfThree(String[] array)

{

String[] ArrayOfThree = new String[array.Length]; 

for (int it = 0; it < array.Length; it++)
{
    if(array[it].Length <= 3) ArrayOfThree[it] = array[it];
} 

return ArrayOfThree;


}