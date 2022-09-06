{
    Console.WriteLine("task 41");

    Console.Write("Введите количество чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] arrNumbers = new int[m];

    void InputNumbers(int m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Введите {i + 1} число: ");
            arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }


    int Comparison(int[] arrNumbers)
    {
        int count = 0;
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            if (arrNumbers[i] > 0) count += 1;
        }
        return count;
    }

    InputNumbers(m);

    Console.WriteLine($"Чисел больше 0: {Comparison(arrNumbers)} ");
}

{
    Console.WriteLine("task 43");

    Console.WriteLine("введите значение b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    String GetPointOfIntersection(int a, int b, int c, int d)
    {

        float x = (float)(d - c) / (a - b);
        float z = (float)(d - c) / (a - b);
        float y = (float)((a * z) + c);
        return "(" + x + "; " + y + ")";
    }

    String result = GetPointOfIntersection(k1, k2, b1, b2);
    Console.WriteLine(result);

 

}