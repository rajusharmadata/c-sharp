public class Jagged{
    public void PrintArray() {
        int[][] arr = new int[3][] {new[]{ 1, 2, 3 },new[]{ 4, 5 },new[]{ 6, 7, 8, 9, 10 } }; // Added extra element to demonstrate dynamic array size};
        // arr[0] = new int[] { 1, 2, 3 };
        // arr[1] = new int[] { 4, 5, 6,5,3,7,6,7,5 };
        // arr[2] = new int[] { 8 };

        for (int i = 0; i < arr.Length; i++) {

        for (int j = 0; j < arr[i].Length; j++) {
            Console.Write(arr[i][j] + " ");
            }   
            Console.WriteLine();
            }
            }
}