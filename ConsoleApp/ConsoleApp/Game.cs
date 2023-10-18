﻿using System;

namespace ConsoleApp
{
    class Game
    {
        // метод отображения лучших игровов
        public static string[,] BestPlayers()
        {
            string[,] result = new string[Data.Counter(), 2]; //сделать таблицу в виде двумерного массива, 2 столбца будет - имя и рейтинг, размерность [кол-во игроков][2]
            //инициализация массива
            result = Data.Rating(result);
            //создать в методе в классе Дата массив и заполнить его рейтингами всех игроков, потом отсортировать его
            //дальше берем первый элемент в массиве (максимальный рейтинг) и ищем в бд имя пользователя с таким рейтингом, заносим в наш двумерный массив и тд
            //только тогда надо продумать логику, что делать, если рейтинги каких-то игроков будут повторяться (счётчик повторений возможно
            //ввести и если в отсортированном массиве два одиноковых рейтинга подряд, то первого пользователя в бд с таким рейтингом пропускаем, ищем следующего и добаляем)
            return result;
        }
        // метод создания нового пользвоателя в бд*/
        // метод авторизации/ регистрации пользователя 
        public static void User(ref Info info)
        {
            Data.CheckUser(ref info);
        }
        // Метод генерации рандомного числа 
        public static int GeneratingNumber()
        {
            Random random = new Random();
            int n;
            while (true)
            {
                n = random.Next(1000, 10000); // генерация рандомного четырехзначного числа 
                if (CheckUnique(n.ToString())) { break; }
            }
            return n;
        }

        // Метод, проверяющий подходит ли число пользователя под условия игры ( проверка явл ли четырехзначным и цифры уникальными)
        public static bool CheckUnique(string trial)
        {
            //Distinct() -  возвращает последовательность, содержащую только уникальные элементы из исходной последовательности.
            // Можно попробовать вручную , но пока пусть будет так. Проанализовать скорость работы !!!!!!!!!!
            return trial.Distinct().Count()==trial.Length;
        }

        // Игра быки и коровы . ПРОПИСАТЬ ИГРУ , КОТОРАЯ ВЫЧИСЛЯЕТ КОЛ-ВО БЫКОВ И КОРОВ
        public static void BullsАndCowsGame(string trial, string number, out int bull, out int cow)
        {
            bull = 0;
            cow = 0;
            for (int i = 0; i < 4; i++) //бежим по числу (строке)
            {
                // если полное совпадение, то бык
                if (trial[i] == number[i])
                {
                    bull++;
                }
                // если позиция не совпадает, но такая цифра есть в числе
                // number.Contains(trial[i]) - метод типа bool. Возвращает значение, указывающее, встречается ли указанный символ внутри этой строки.
                else if (number.Contains(trial[i]))
                {
                    cow++;
                }

            } 
        }
        public static void Update(Info info) //зачем это?
        {
            Data.Update(info);
        }
    }
}
