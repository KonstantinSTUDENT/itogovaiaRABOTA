Console.Clear();
        Console.WriteLine("Введите значение массива");
            string stroka = Console.ReadLine();
            a = stroka.Split(' ');
            var result = new string[a .Length];
            var realSize = 0;
            foreach (var value in a )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);