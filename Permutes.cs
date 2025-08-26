
class Program
{
    static void printArr(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    } 
    
    
    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Permutes(int[] arr, int start, int n)
    {
        if (start == n - 1)
        {
            printArr(arr);
        }
        for(int i = start; i < n; i++)
        {
            swap(arr, start, i);
            Permutes(arr, start + 1, n);
            swap(arr, start, i);
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            arr[i] = i;
        }
        
        Permutes(arr,0,n);
    }
    
}