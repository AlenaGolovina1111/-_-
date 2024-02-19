//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.

using System; 
 
namespace ArrayOfShortStrings 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            // Ввод массива строк 
            Console.WriteLine("ВВедите массив строк через запятую:"); 
            string[] inputArray = Console.ReadLine().Split(','); 
 
            // Инициализация пустого результирующего массива 
            string[] resultArray = new string[0]; 
 
            // Перебор строк в исходном массиве 
            foreach (string str in inputArray) 
            { 
                // Проверка длины строки 
                if (str.Length <= 3) 
                { 
                    // Добавление строки в результирующий массив 
                    Array.Resize(ref resultArray, resultArray.Length + 1); 
                    resultArray[resultArray.Length - 1] = str; 
                } 
            } 
 
            // Вывод результирующего массива 
            Console.WriteLine("Новый массив строк длиной не более 3 символов:"); 
            foreach (string str in resultArray) 
            { 
                Console.WriteLine(str); 
            } 
        } 
    } 
}