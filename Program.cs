string[] m;
Console.WriteLine("Введите массив строк через пробел: ");
            string storeArray = Console.ReadLine();
            m = storeArray.Split(' ');
            var result = new string[m.Length];
            var realSize = 0;
            foreach (var value in m )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);