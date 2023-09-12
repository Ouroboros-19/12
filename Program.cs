class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 10;
        bool flag = true;
        int[] array = new int[a];
        int min, n = 0, k = array.Length, b;
        Console.Write("{0,3}", array[0] = r.Next(0, 10));
        min = 0;
        for (int i = 1; i < k; i++)
        {
            array[i] = r.Next(0, 10);
            Console.Write("{0,3}", array[i]);
            if (array[i] < array[min])
                min = i;
        }
        Console.WriteLine();
        while (true)
        {
            if (flag == true)
            {
                b = array[min];
                array[min] = array[n];
                array[n] = b;
                n++;
                flag = false;
            }
            else
            {
                b = array[min];
                array[min] = array[k - 1];
                array[k - 1] = b;
                k--;
                flag = true;
            }
            if (n >= k)
                break;
            min = n;
            for (int i = n; i < k; i++)
                if (array[i] < array[min])
                    min = i;
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write("{0,3}", array[i]);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        Console.ForegroundColor = ConsoleColor.White;
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}