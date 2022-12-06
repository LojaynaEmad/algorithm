using System;
class MergeSort {
    void Merge(int[] arr, int l, int m, int r)
    {
        int i , j ;

        int n1 = m - l + 1;
        int n2 = r - m;
 
        int[] L = new int[n1];
        int[] R = new int[n2];
 
        for (i = 0; i < n1; i++){
            L[i] = arr[l + i]; 
        }

        for (j = 0; j < n2; j++){
            R[j] = arr[m + 1 + j];
        }
    
        i = j = 0 ;

        int k = l;
        while (i < n1 && j < n2) {
            if (L[i] >= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
    void Sort(int[] arr, int l, int r)
    {
        if (l < r) {
            int m = l + (r - l) / 2;
 
            Sort(arr, l, m);
            Sort(arr, m + 1, r);
 
            Merge(arr, l, m, r);
        }
    }

    static void print(int[] arr)
    {
        for (int i = 0; i < arr.Length ; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    public static void Main(String[] args)
    {
        int[] arr = { 5, 15, 20, 8, 6, 12, 1 };
        Console.WriteLine("Given Array: ");
        print(arr);
        MergeSort ob = new MergeSort();
        ob.Sort(arr, 0, arr.Length - 1);
        Console.WriteLine("\nSorted array: ");
        print(arr);
    }
}
 
    