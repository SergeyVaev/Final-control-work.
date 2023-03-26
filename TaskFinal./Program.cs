// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []





        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string[]ArrayInput = Console.ReadLine().Split(',');

        // Создание нового массива с длиной не более 3 символов
        string[] ArrayOutput = new string[ArrayInput.Length];
        int count = 0;
        for (int i = 0; i < ArrayInput.Length; i++) 
        {
            if (ArrayInput[i].Length <= 3) 
            {
                ArrayOutput[count] = ArrayInput[i];
                count++;
            }
        }

        // Вывод нового массива на экран
        Console.WriteLine("Новый массив:");
    
        for (int i = 0; i < count; i++) 
        {
            Console.Write(ArrayOutput[i]+". ");
        }

        Console.ReadKey();



