using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        NumOperation numop = new NumOperation();
        Console.WriteLine("Введите номер задания: ");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                {
                    Console.WriteLine("Задание 1");
                    Console.WriteLine("Вывести дробную часть числа");

                    Console.WriteLine("Введите дробное число: ");
                    double number_1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Дробная часть числа - " + numop.Fraction(number_1));


                    Console.WriteLine("Задание 3");
                    Console.WriteLine("Преобразование символа в число");

                    Console.WriteLine("Введите цифру от 0 до 9: ");
                    char number_3 = char.Parse(Console.ReadLine());


                    Console.WriteLine("Преобразованное число - " + numop.CharToNum(number_3));


                    Console.WriteLine("Задание 5");
                    Console.WriteLine("Проверка на двузначность числа");

                    Console.WriteLine("Введите число: ");
                    int number_5 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введенное число двузначное - " + numop.is2Digits(number_5));


                    Console.WriteLine("Задание 7");
                    Console.WriteLine("Входит ли число в диапазон");

                    Console.WriteLine("Введите левую границу диапазона: ");
                    int a_border = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите правую границу диапазона: ");
                    int b_border = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число: ");
                    int number_7 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Число принадлежит диапазону - " + numop.isInRange(a_border, b_border, number_7));


                    Console.WriteLine("Задание 9");
                    Console.WriteLine("Верны ли три числа");

                    Console.WriteLine("Введите первое число: ");
                    int number_9_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int number_9_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число: ");
                    int number_9_3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Все три числа равны - " + numop.isEqual(number_9_1, number_9_2, number_9_3));

                    break;
                }
            case 2:
                {
                    Console.WriteLine("Задание 1");
                    Console.WriteLine("Модуль числа");

                    Console.WriteLine("Введите число: ");
                    int number_1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Модуль числа - " + numop.abs(number_1));


                    Console.WriteLine("Задание 3");
                    Console.WriteLine("Делится ли число на 3 либо на 5");

                    Console.WriteLine("Введите число: ");
                    int number_3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Делится на 5 или на 3 - " + numop.is35(number_3));


                    Console.WriteLine("Задание 5");
                    Console.WriteLine("Максимальное из трех чисел");

                    Console.WriteLine("Введите первое число: ");
                    int number_5_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int number_5_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число: ");
                    int number_5_3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Максимально число - " + numop.max3(number_5_1, number_5_2, number_5_3));


                    Console.WriteLine("Задание 7");
                    Console.WriteLine("Сумма чисел (20, если из диапазона от 10 до 19)");

                    Console.WriteLine("Введите первое число: ");
                    int number_7_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int number_7_2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма чисел (если входит в диапазон 10 - 19, то вывод 20) - " + numop.sum2(number_7_1, number_7_2));


                    Console.WriteLine("Задание 9");
                    Console.WriteLine("День недели");

                    Console.WriteLine("Введите число: ");
                    int number_9 = int.Parse(Console.ReadLine());

                    Console.WriteLine("День недели - " + numop.day(number_9));

                    break;
                }
            case 3:
                {
                    Console.WriteLine("Задание 1");
                    Console.WriteLine("Массив от 0 до заданного числа");

                    Console.WriteLine("Введите число: ");
                    int number_1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Строка от 0 до заданного числа - " + numop.listNums(number_1));


                    Console.WriteLine("Задание 3");
                    Console.WriteLine("Массив четных чисел до заданного числа");

                    Console.WriteLine("Введите число: ");
                    int number_3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Строка четных чисел от 0 до заданного числа - " + numop.chet(number_3));


                    Console.WriteLine("Задание 5");
                    Console.WriteLine("Количество цифр в числе");

                    Console.WriteLine("Введите число: ");
                    long number_5 = long.Parse(Console.ReadLine());

                    Console.WriteLine("Количество знаков в числе - " + numop.numLen(number_5));


                    Console.WriteLine("Задание 7");
                    Console.WriteLine("Квадрат");

                    Console.WriteLine("Введите длину стороны квадрата: ");
                    int number_7 = int.Parse(Console.ReadLine());

                    numop.square(number_7);


                    Console.WriteLine("Задание 9");
                    Console.WriteLine("Правосторонний треугольник");

                    Console.WriteLine("Введите длину стороны треугольника: ");
                    int number_9 = int.Parse(Console.ReadLine());

                    numop.rightTriangle(number_9);

                    break;
                }
            case 4:
                {
                    features features = new features();


                    Console.WriteLine("Задание 1");
                    Console.WriteLine("Индекс первого вхождения");

                    Console.WriteLine("Введите размер массива: ");
                    int size_1 = int.Parse(Console.ReadLine());
                    int[] arr_1 = features.makeArray(size_1);

                    Console.WriteLine("Введите число: ");
                    int number_1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Первое вхождение " + number_1 + " - " + numop.findFirst(arr_1, number_1));


                    Console.WriteLine("Задание 3");
                    Console.WriteLine("Максимальное по модулю число");

                    Console.WriteLine("Введите размер массива: ");
                    int size_3 = int.Parse(Console.ReadLine());
                    int[] arr_3 = features.makeArray(size_3);

                    Console.WriteLine("Максимальное по модулю число - " + numop.maxAbs(arr_3));


                    Console.WriteLine("Задание 5");
                    Console.WriteLine("Объединить два массива");

                    Console.WriteLine("Введите размер первого массива: ");
                    int size_5_1 = int.Parse(Console.ReadLine());
                    int[] arr_5_1 = features.makeArray(size_5_1);

                    Console.WriteLine("Введите размер второго массива: ");
                    int size_5_2 = int.Parse(Console.ReadLine());
                    int[] arr_5_2 = features.makeArray(size_5_2);

                    Console.WriteLine("Введите позицию для вставки: ");
                    int number_5 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Новый массив: ");
                    features.printArray(numop.add(arr_5_1, arr_5_2, number_5));


                    Console.WriteLine("Задание 7");
                    Console.WriteLine("Обратный массив");

                    Console.WriteLine("Введите размер массива: ");
                    int size_7 = int.Parse(Console.ReadLine());
                    int[] arr_7 = features.makeArray(size_7);

                    Console.WriteLine("Обратный массив: ");
                    features.printArray(numop.reverseBack(arr_7));


                    Console.WriteLine("Задание 9");
                    Console.WriteLine("Создать массив индексов заданного числа");

                    Console.WriteLine("Введите размер массива: ");
                    int size_9 = int.Parse(Console.ReadLine());
                    int[] arr_9 = features.makeArray(size_9);

                    Console.WriteLine("Введите число: ");
                    int number_9 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Массив индексов всех вхождений " + number_9 + " - ");
                    features.printArray(numop.findAll(arr_9, number_9));

                    break;
                }
            default:
                {
                    Console.WriteLine("Попробуйте еще раз");
                    break;
                }
        } 


    }



}



