Console.Write("Введите количество элементов массива ");
int n = int.Parse (Console.ReadLine());
string[] ArrayItem = new string[n];
for (int i = 0; i < n; i++)
 {
  Console.Write("Введите "+(i+1)+" элемент массива ");
  ArrayItem[i]  = Console.ReadLine();
 }
string [] NewArray = new string [ArrayItem.Length];
int NewIndex = 0;
for (int i = 0; i < ArrayItem.Length; i++)
 {
  if (ArrayItem[i].Length <= 3)
  {
    NewArray[NewIndex] = ArrayItem[i];
  NewIndex++;
  }
 }
 Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам: ");
 for (int j = 0; j < NewIndex; j++)
 {
  Console.Write(NewArray[j]);
  if (j < NewIndex - 1)
  {
    Console.Write(", ");
  }
 }
 Console.ReadLine();
