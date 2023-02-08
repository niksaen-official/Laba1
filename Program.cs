using System;

public class Program {
    const int multipleOfThisNumber = 21;
    const int maxArrayLength = 1000;
    const int maxValueInArr = 10000;
    static void Main(string[] args) {
        int[] arr = new int[maxArrayLength];
        //array filling
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
            arr[i] = r.Next(0, maxValueInArr);

        //find value in array
        int minMultipleOfNumber = maxValueInArr;
        int minValueInArr = maxValueInArr;
        int result = 0;
        foreach(int currentItem in arr) {
            if (currentItem % multipleOfThisNumber == 0) minMultipleOfNumber = currentItem;//проверка на кратность
            if (currentItem < minValueInArr) minValueInArr = currentItem;// проверка на минимум
            if (currentItem < minMultipleOfNumber) minMultipleOfNumber = currentItem;
        }

        if (result < minMultipleOfNumber * minValueInArr)
            result = minMultipleOfNumber * minValueInArr;
        //output found element
        if (result == maxValueInArr)
            Console.WriteLine("-1");
        else
           Console.WriteLine(result.ToString());
            
        Console.ReadKey();
    }
}