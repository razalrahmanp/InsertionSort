# InsertionSort

The code is implementing the Insertion Sort algorithm to sort an array of integers. 
 Here is a step-wise explanation of the code:
 1. The code starts with the declaration of the  `Program`  class.
 2. The  `Main`  method is the entry point of the program. It prompts the user to enter numbers to be sorted and reads the input from the console.
 3. The input string is then split by spaces and converted into an array of integers using the  `Array.ConvertAll`  method.
 4. The  `InsertionSort`  method is called with the array as the argument to sort the numbers.
 5. After sorting, the sorted array is printed to the console using a foreach loop.
 6. If any exception occurs during the execution of the code, it is caught in the  `catch`  block and an error message along with the exception message is printed to the console.
 7. The  `InsertionSort`  method is defined to perform the actual sorting. It takes an integer array as an argument.
 8. The method first checks if the array is null or empty. If it is, an  `ArgumentException`  is thrown.
 9. The length of the array is stored in the variable  `n` .
 10. The method then starts a loop from index 1 to  `n-1` .
 11. Inside the loop, the current element at index  `i`  is stored in a variable  `key` .
 12. Another variable  `j`  is initialized with the value  `i-1` .
 13. A while loop is started which continues as long as  `j`  is greater than or equal to 0 and the element at index  `j`  is greater than  `key` .
 14. Inside the while loop, the element at index  `j`  is shifted one position to the right by assigning  `array[j + 1]`  the value of  `array[j]` .
 15.  `j`  is decremented by 1.
 16. After the while loop ends, the  `key`  is inserted at the correct position by assigning  `array[j + 1]`  the value of  `key` .
 17. The  `InsertionSort`  method ends.
 18. The program execution ends after the  `Main`  method.
