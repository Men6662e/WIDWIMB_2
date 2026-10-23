//=========================================================================================================================================================================================

//1. Базовые типы, операции и ввод-вывод

//=========================================================================================================================================================================================

//Console.WriteLine("Калькулятор ИМТ (Индекса массы тела)\n");
//Console.Write("Введите своё имя: "); string name = Convert.ToString(Console.ReadLine())!;
//Console.Write("Введите свой вес: "); double weight = Convert.ToDouble(Console.ReadLine())!;
//Console.Write("Введите свой рост: "); double height = Convert.ToDouble(Console.ReadLine())!;

//double IMT = weight / (height * height);

//Console.WriteLine($"Привет, {name}! Ваш ИМТ составляет {IMT}");

//=========================================================================================================================================================================================

//2. Условия, циклы и массивы

//=========================================================================================================================================================================================

//double[] temps = { 3.5, -2.0, 0.0, 7.2, -5.5, 4.0, 1.5 };

//Console.Write("Температуры: ");
//foreach (var temp in temps)
//{
//    Console.Write($"{temp} ");
//}
//Console.WriteLine();

//double sum = 0;
//double maxTemp = temps.Length > 0 ? temps[0] : 0;
//double minTemp = temps.Length > 0 ? temps[0] : 0;
//int belowZeroCount = 0;

//foreach (var temp in temps)
//{
//    sum += temp;

//    if (temp > maxTemp) maxTemp = temp;
//    if (temp < minTemp) minTemp = temp;

//    if (temp < 0) belowZeroCount++;
//}

//double average = temps.Length > 0 ? sum / temps.Length : 0;

//Console.WriteLine($"Средняя температура: {average:F2}°C");
//Console.WriteLine($"Самая высокая температура: {maxTemp}°C");
//Console.WriteLine($"Самая низкая температура: {minTemp}°C");
//Console.WriteLine($"Дней ниже нуля: {belowZeroCount}");

//Console.ReadLine();

//=========================================================================================================================================================================================

//3. Методы и параметры

//=========================================================================================================================================================================================

//double rubles = 5000;
//double rate = 92.5;

//Console.WriteLine($"Попытка 1: {rubles} руб. по курсу {rate}");
//if (TryConvert(rubles, rate, out double dollars))
//{
//    Console.WriteLine($"Конвертация успешна! Итоговая сумма: ${dollars:F2}");
//}
//else
//{
//    Console.WriteLine("Некорректные исходные данные");
//}

//bool TryConvert(double rubles, double usdRate, out double dollars)
//{
//    if (rubles > 0 && usdRate > 0)
//    {
//        dollars = rubles / usdRate;
//        return true;
//    }

//    dollars = 0;
//    return false;
//}

//Console.ReadLine();

//=========================================================================================================================================================================================

//4. Поразрядные операции и switch

//=========================================================================================================================================================================================

//Console.Write("Введите число от 0 до 7 (сумма ваших прав): "); int input = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("\nВаши права:");

//if ((input & (int)FileAccess.Read) > 0)
//{
//    Console.WriteLine("- Чтение");
//}

//if ((input & (int)FileAccess.Write) > 0)
//{
//    Console.WriteLine("- Запись");
//}

//if ((input & (int)FileAccess.Execute) > 0)
//{
//    Console.WriteLine("- Выполнение");
//}

//if (input == 0)
//{
//    Console.WriteLine("- Нет прав");
//}

//string status = input switch
//{
//    0 => "Гость",
//    7 => "Администратор",
//    _ => "Пользователь"
//};

//Console.WriteLine($"Статус: {status}");

//Console.ReadLine();

//enum FileAccess
//{
//    Read = 1,
//    Write = 2,
//    Execute = 4
//}

//=========================================================================================================================================================================================

//5. Двумерные массивы и задачи с ними

//=========================================================================================================================================================================================

//int[,] matrix = {
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 }
//};

//Console.WriteLine("Исходная матрица:");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{matrix[i, j]}\t");
//    }
//    Console.WriteLine();
//}

//int[,] transposedMatrix = new int[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        transposedMatrix[j, i] = matrix[i, j];
//    }
//}

//Console.WriteLine("\nТранспонированная матрица:");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{transposedMatrix[i, j]}\t");
//    }
//    Console.WriteLine();
//}

//=========================================================================================================================================================================================

//6. Продвинутые методы (params и рекурсия)

//=========================================================================================================================================================================================

//Analyze(5, 12, 3, 8);
//Analyze(1, 3, 5, 7);
//Analyze(2, 4, 6, 10, 11);

//void Analyze(params int[] numbers)
//{
//    int SumEvensRecursive(int index)
//    {
//        if (index < 0) return 0;

//        int currentNumber = numbers[index];
//        int currentContribution = (currentNumber % 2 == 0) ? currentNumber : 0;

//        return currentContribution + SumEvensRecursive(index - 1);
//    }

//    int totalSum = SumEvensRecursive(numbers.Length - 1);

//    Console.WriteLine($"Сумма чётных чисел в массиве: {totalSum}");
//}

//=========================================================================================================================================================================================