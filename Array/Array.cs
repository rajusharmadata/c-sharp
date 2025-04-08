public class Arr {
    public void PrintArray() {
        string[,] Arr = new string[3,3]
            {
            { "a", "b" ,"c" },
            { "d", "e", "f" },
            { "g", "h", "i" }
              };

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(Arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
