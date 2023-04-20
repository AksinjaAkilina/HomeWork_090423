// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int [] array = new int[8]; 

FillArray(array);   

PrintArray(array);

void FillArray(int[] collection)    
{
int length = collection.Length; 
int index = 0;                   
    while (index < length)
    {
    collection[index] = new Random().Next(0, 99); 
    index++;
    }
}

void PrintArray(int[] col)     
{
int length = col.Length; 
int index = 0;       
    while (index < length)
    {
    Console.Write($"{col[index]} ");  
    index++;
    }
}
 
