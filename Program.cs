using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("libarraylib.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern double findMin(double[] array, int size);

    [DllImport("libarraylib.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void findMinAndIndex(double[] array, int size, out double min, int[] indices);

    [DllImport("libarraylib.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void readArray(double[] array, int size);

    [DllImport("libarraylib.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void printArray(double[] array, int size);

    static void Main()
    {
        int size = 35;
        double[] array = new double[size];

        Console.WriteLine("Enter " + size + " numbers:");
        readArray(array, size);

        Console.WriteLine("Array:");
        printArray(array, size);

        double min;
        int[] indices = new int[size];
        findMinAndIndex(array, size, out min, indices);
        Console.WriteLine("Min: " + min + ", Indices: " + string.Join(", ", indices));
    }
}