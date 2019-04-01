using System;

namespace Basic_13
{
    class Program
    {   
        public static void PrintNumbers()
        {
            for(int i = 0; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        
        public static void PrintOdds()
        {
            for(int i = 0; i <= 255; i++){
                if(i%1==1){
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i <=255; i++){
                sum+=i;
                Console.WriteLine("i: "+i);
                Console.WriteLine("Sum: "+sum);
            }
        }
        
        public static void LoopArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            if(numbers.Length <= 0){
                return 0;
            }

             int max = numbers[0];
             for(int i = 1; i < numbers.Length; i++){
                 if(max < numbers[i]){
                     max = numbers[i];
                 }
             }
            Console.WriteLine("Max: "+max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for(int i =0; i < numbers.Length; i++){
                sum+= numbers[i];
            }
            Console.WriteLine("Average: "+sum/numbers.Length);
        }

        public static int[] OddArray()
        {
            int[] odds = new int[128];
            int j = 0;
            for(int i = 0; i <= 255; i++){
                if(i%2==1){
                    odds[j] = i;
                    j++;
                }
            }
            return odds;
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        }

        public static int GreaterThanY(int[] numbers, int y)
        {   
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0 ){
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);    
            }
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for(int i =0; i < numbers.Length; i++){
                sum += numbers[i];
                if(max < numbers[i]){
                    max = numbers[i];
                }
                if(min > numbers[i]){
                    min = numbers[i];
                }
            }
            Console.WriteLine("Max: "+ max + " Min: "+ min+" Average: "+sum/numbers.Length);
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        }

        public static void ShiftValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length-1; i++){
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            foreach(int num in numbers){
                Console.WriteLine(num);
            }
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];

            for (int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    newArr[i] = "Dojo";
                } else {
                    newArr[i] = numbers[i];
                }
            }
            foreach(object obj in newArr){
                Console.WriteLine(obj);
            }
            return newArr;
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // OddArray();
            // ShiftValues(new int[] {1, 5, 10, -2});
            // NumToString(new int[] {-1, -3, 2});
        }
    }
}
