//Вводим размер массива

Console.WriteLine("Введите длину массива строк");

int arraySize = Convert.ToInt32(Console.ReadLine());
String[] Arr = new String[arraySize];

//Вводим строчные элементы массива 

Console.WriteLine($"Введите строки в количестве {arraySize}-ти");
for(int i = 0; i < arraySize; i++) {

Arr[i] = Console.ReadLine();

}
