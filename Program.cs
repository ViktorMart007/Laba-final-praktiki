using System;
using System.Collections.Generic;
using System.Linq;

namespace proba_finala
{


    struct Note
    {
        public string familya;
        public string name;
        public string ot4;
        public long telefon;
        public string strana;
        public int day;
        public int mes;
        public int god;
        public string organisation;
        public string doljnost;
        public string zametki;



    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Note> array = new List<Note>();
            Note temp;
            while (true)
            {
                Console.Write("1) Создание записи 2)Редактирование записи 3) Удаление записи  4) Просмотр записи");
                Console.Write(" 5) просмотр всех записей с краткой информацией 6) выход) : ");

                string buf_1 = Console.ReadLine();

                if (buf_1 == "" || buf_1 == " ")
                {
                    buf_1 = "0";
                }

                long mode = Convert.ToInt64(buf_1);

                if (mode == 1)
                {
                    Console.WriteLine("!!!!ВНИМАНИЕ ЗАПИСИ НЕ ДОЛЖНЫ СОДЕРЖАТЬ ОДИНАКОВЫХ ПОЛЕЙ ИМЯ И ФАМИЛИЯ В ПРОТИВНОМ СЛУЧАЕ РАБОТОСПОСОБНОСТЬ СПОСОБА ПОИСКА ИНДЕКСА ПО ФАМИЛИИ И ИМЕНИ РАБОТАТЬ НЕ БУДЕТ!!!!");
                    temp = new Note();

                    Console.Write("Введите Фамилию(Обязательное поле): ");

                    temp.familya = Console.ReadLine();

                    if (temp.familya == "")
                    {
                        Console.WriteLine("Заполните обязательное поле(Фамилия)!!");
                    }

                    else
                    {

                        Console.Write("Введите Имя(обязательное поле): ");
                        temp.name = Console.ReadLine();

                        if (temp.name == "")
                        {
                            Console.WriteLine("Заполните обязательное поле(Имя)!!");
                        }

                        else
                        {

                            Console.Write("Введите Отчество: ");
                            temp.ot4 = Console.ReadLine();

                            Console.Write("Введите телефон(обязательное поле): ");
                            string buf = Console.ReadLine();

                            if (buf == "" || buf == " ")
                            {
                                Console.WriteLine("Заполните обязательное поле(телефон)!!");
                            }
                            else
                            {

                                temp.telefon = Convert.ToInt64(buf);

                                Console.Write("Введите страну(обязательное поле): ");
                                temp.strana = Console.ReadLine();

                                if (temp.strana == "")
                                {
                                    Console.WriteLine("Нужно заполнить поле(Страна)!!");
                                }

                                else
                                {
                                    Console.Write("Введите день рождения: ");
                                    buf = Console.ReadLine();

                                    if (buf == "" || buf == " ")
                                    {
                                        buf = "0";
                                    }

                                    temp.day = Convert.ToInt32(buf);

                                    Console.Write("Введите месяц рождения: ");
                                    buf = Console.ReadLine();

                                    if (buf == "" || buf == " ")
                                    {
                                        buf = "0";
                                    }
                                    temp.mes = Convert.ToInt32(buf);

                                    Console.Write("Введите год рождения : ");
                                    buf = Console.ReadLine();


                                    if (buf == "" || buf == " ")
                                    {
                                        buf = "0";
                                    }
                                    temp.god = Convert.ToInt32(buf);

                                    Console.Write("Введите организацию: ");
                                    temp.organisation = Console.ReadLine();

                                    Console.Write("Введите должность: ");
                                    temp.doljnost = Console.ReadLine();

                                    Console.Write("Введите заметки: ");
                                    temp.zametki = Console.ReadLine();

                                    array.Add(temp);

                                }
                            }
                        }
                    }
                }
                else if (mode == 2)
                {
                    if (array.Count == 0)
                    {
                        Console.Write("нет пользователей,возврат в меню");
                        Console.ReadKey();
                    }

                    else
                    {
                        while (true)
                        {

                            Console.WriteLine("Редактирование записи:");
                            Console.Write("1)Поиск индекса записи по фамилии и имени 2)поиск индекса выводом всех записей 3)Редактирование пользователя (нужно знать Индекс) 4)Выход :");

                            int mode1 = Convert.ToInt32(Console.ReadLine());

                            if (mode1 == 1)
                            {

                                Console.Write("Введите Фамилию: ");
                                var needle = Console.ReadLine();
                                Console.Write("Введите Имя: ");

                                var needle1 = Console.ReadLine();

                                int index = array.FindIndex(s => string.Equals(s.familya, needle, StringComparison.CurrentCultureIgnoreCase));

                                Console.WriteLine("Предполагаемый индекс контакта(фамилия)" + index);

                                int index1 = array.FindIndex(s => string.Equals(s.name, needle1, StringComparison.CurrentCultureIgnoreCase));

                                Console.WriteLine("Предполагаемый индекс контакта(имя)" + index1);
                                Console.WriteLine("ЕСЛИ ОДИН ИНДЕКС Меньше другого,ВЫБИРАЙТЕ БОЛЬШИЙ индекс (если не введены ошибки при вводе");
                                Console.WriteLine("ЕСЛИ ОБА ИНДЕКСА равны -1 то пользователя не существует)");
                                Console.WriteLine("ЕСЛИ ИНДЕКСЫ  СОВПАДАЮТ(но не -1) то ИНДЕКС пользователя НАЙДЕН)");
                                Console.WriteLine("ЕСЛИ ИНДЕКС РАВЕН -1 ОШИБКА ПРИ ВВОДЕ");

                            }

                            else if (mode1 == 2)
                            {
                                for (int j = 0; j < array.Count; j++)
                                {

                                    Console.WriteLine(array[j].familya + " " + array[j].name + "(" + j + ")");
                                }
                            }

                            else if (mode1 == 3)

                            {

                                Console.Write("Выберете номер пользователя: ");

                                int g = Convert.ToInt32(Console.ReadLine());


                                if (g > array.Count - 1 || g < 0)
                                {
                                    Console.WriteLine("Введен номер несуществующего пользователя возврат в меню ");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    while (true)
                                    {
                                        Console.Write("1)изменение фамилии 2)изменение имени 3)изменение отчества 4)изменение телефона 5)изменение страны 6)изменение дня рождения 7)изменение месяца рождения 8)изменение года рождения 9)изменение организации 10)изменение должности 11)изменение заметки 12)возврат в меню: ");

                                        int mode_1 = Convert.ToInt32(Console.ReadLine());

                                        if (mode_1 == 1)

                                        {
                                            Console.Write("Введите Фамилию: ");

                                            Note str = array[g];
                                            str.familya = Console.ReadLine();
                                            if (str.familya == "")
                                            {
                                                Console.WriteLine("Нужно заполнить поле(Фамилия)!!");
                                            }
                                            else
                                            {
                                                array[g] = str;

                                            }
                                        }

                                        else if (mode_1 == 2)
                                        {
                                            Console.Write("Введите Имя: ");

                                            Note str = array[g];
                                            str.name = Console.ReadLine();
                                            if (str.name == "")
                                            {
                                                Console.WriteLine("Нужно заполнить обязательное поле(Имя)!!");
                                            }
                                            else
                                            {
                                                array[g] = str;

                                            }
                                        }

                                        else if (mode_1 == 3)
                                        {
                                            Console.Write("Введите Отчество: ");

                                            Note str = array[g];
                                            str.ot4 = Console.ReadLine();
                                            array[g] = str;

                                        }

                                        else if (mode_1 == 4)
                                        {
                                            Console.Write("Введите телефон: ");

                                            string buf = Console.ReadLine();

                                            if (buf == "" || buf == " ")
                                            {
                                                Console.WriteLine("Заполните обязательное поле(телефон)!!");
                                            }
                                            else
                                            {
                                                Note str = array[g];
                                                str.telefon = Convert.ToInt64(buf);
                                                array[g] = str;
                                            }
                                        }

                                        else if (mode_1 == 5)
                                        {
                                            Console.Write("Введите страну: ");

                                            Note str = array[g];
                                            str.strana = Console.ReadLine();
                                            if (str.strana == "")
                                            {
                                                Console.WriteLine("Нужно заполнить обязательное поле(Страна)!!");
                                            }
                                            else
                                            {
                                                array[g] = str;

                                            }
                                        }

                                        else if (mode_1 == 6)
                                        {
                                            Console.Write("Введите день рождения: ");

                                            string buf = Console.ReadLine();

                                            if (buf == "" || buf == " ")
                                            {
                                                buf = "0";
                                            }
                                            else
                                            {
                                                Note str = array[g];
                                                str.day = Convert.ToInt32(buf);
                                                array[g] = str;
                                            }
                                        }

                                        else if (mode_1 == 7)
                                        {
                                            Console.Write("Введите месяц рождения: ");
                                            string buf = Console.ReadLine();

                                            if (buf == "" || buf == " ")
                                            {
                                                buf = "0";
                                            }
                                            else
                                            {
                                                Note str = array[g];
                                                str.mes = Convert.ToInt32(buf);
                                                array[g] = str;
                                            }
                                        }

                                        else if (mode_1 == 8)
                                        {
                                            Console.Write("Введите год рождения : ");
                                            string buf = Console.ReadLine();

                                            if (buf == "" || buf == " ")
                                            {
                                                buf = "0";
                                            }
                                            else
                                            {
                                                Note str = array[g];
                                                str.god = Convert.ToInt32(buf);
                                                array[g] = str;
                                            }
                                        }

                                        else if (mode_1 == 9)
                                        {
                                            Console.Write("Введите организацию: ");

                                            Note str = array[g];
                                            str.organisation = Console.ReadLine();

                                            array[g] = str;

                                        }

                                        else if (mode_1 == 10)
                                        {
                                            Console.Write("Введите должность: ");

                                            Note str = array[g];
                                            str.doljnost = Console.ReadLine();

                                            array[g] = str;
                                        }

                                        else if (mode_1 == 11)
                                        {
                                            Console.Write("Введите заметки: ");

                                            Note str = array[g];
                                            str.zametki = Console.ReadLine();

                                            array[g] = str;
                                        }

                                        else if (mode_1 == 12)
                                        {
                                            Console.Write("Возврат в меню ");
                                            break;
                                        }
                                    }
                                }
                            }

                            else if (mode1 == 4)
                            { break; }

                        }

                    }
                }

                else if (mode == 3)
                {
                    if (array.Count == 0)
                    {
                        Console.Write("нет пользователей,возврат в меню");
                        Console.ReadKey();

                    }

                    else
                    {
                        while (true)
                        {

                            Console.WriteLine("Удаление Записи:");
                            Console.Write("1)Поиск индекса записи по фамилии и имени 2)поиск индекса выводом всех записей 3)Удаление пользователя (нужно знать Индекс) 4)Выход :");

                            int mode1 = Convert.ToInt32(Console.ReadLine());

                            if (mode1 == 1)
                            {
                                if (mode1 == 1)
                                {

                                    Console.Write("Введите Фамилию: ");
                                    var needle = Console.ReadLine();
                                    Console.Write("Введите Имя: ");

                                    var needle1 = Console.ReadLine();



                                    int index = array.FindIndex(s => string.Equals(s.familya, needle, StringComparison.CurrentCultureIgnoreCase));



                                    Console.WriteLine("Предполагаемый индекс контакта(фамилия)" + index);



                                    int index1 = array.FindIndex(s => string.Equals(s.name, needle1, StringComparison.CurrentCultureIgnoreCase));

                                    Console.WriteLine("Предполагаемый индекс контакта(имя)" + index1);
                                    Console.WriteLine("ЕСЛИ ОДИН ИНДЕКС Меньше другого,ВЫБИРАЙТЕ БОЛЬШИЙ индекс (если не введены ошибки при вводе");
                                    Console.WriteLine("ЕСЛИ ОБА ИНДЕКСА равны -1 то пользователя не существует)");
                                    Console.WriteLine("ЕСЛИ ИНДЕКСЫ  СОВПАДАЮТ(но не -1) то ИНДЕКС пользователя НАЙДЕН)");
                                    Console.WriteLine("ЕСЛИ ИНДЕКС РАВЕН -1 ОШИБКА ПРИ ВВОДЕ");

                                }
                            }

                            else if (mode1 == 2)
                            {
                                Console.Write("Записанные люди: ");

                                for (int j = 0; j < array.Count; j++)
                                {
                                    Console.WriteLine(array[j].familya + " " + array[j].name + "(" + j + ")");
                                }

                            }


                            else if (mode1 == 3)
                            {
                                Console.Write("Выберете номер пользователя: ");
                                int g = Convert.ToInt32(Console.ReadLine());

                                if (g > array.Count - 1 || g < 0)
                                {
                                    Console.WriteLine("Введен номер несуществующего пользователя возврат в меню ");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    array.RemoveAt(g);
                                }
                            }
                            else if (mode1 == 4)
                            { break; }
                        }
                    }
                }

                else if (mode == 4)
                {
                    if (array.Count == 0)
                    {
                        Console.Write("нет пользователей,возврат в меню");
                        Console.ReadKey();
                    }

                    else
                    {
                      
                        while (true)
                        {
                            Console.WriteLine("Просмотр записи");
                            Console.Write("1)Поиск индекса записи по фамилии и имени 2)поиск индекса выводом всех записей 3)Просмотр записи (нужно знать Индекс) 4)Выход :");

                            int mode1 = Convert.ToInt32(Console.ReadLine());

                            if (mode1 == 1)

                            {
                                Console.Write("Введите Фамилию: ");

                                var needle = Console.ReadLine();

                                Console.Write("Введите Имя: ");

                                var needle1 = Console.ReadLine();

                                int index = array.FindIndex(s => string.Equals(s.familya, needle, StringComparison.CurrentCultureIgnoreCase));

                                Console.WriteLine("Предполагаемый индекс контакта(фамилия)" + index);

                                int index1 = array.FindIndex(s => string.Equals(s.name, needle1, StringComparison.CurrentCultureIgnoreCase));

                                Console.WriteLine("Предполагаемый индекс контакта(имя)" + index1);
                                Console.WriteLine("ЕСЛИ ОДИН ИНДЕКС Меньше другого,ВЫБИРАЙТЕ БОЛЬШИЙ индекс (если не введены ошибки при вводе");
                                Console.WriteLine("ЕСЛИ ОБА ИНДЕКСА равны -1 то пользователя не существует)");
                                Console.WriteLine("ЕСЛИ ИНДЕКСЫ  СОВПАДАЮТ(но не -1) то ИНДЕКС пользователя НАЙДЕН)");
                                Console.WriteLine("ЕСЛИ ИНДЕКС РАВЕН -1 ОШИБКА ПРИ ВВОДЕ");
                            }

                            else if (mode1 == 2)
                            {
                                Console.WriteLine("Записанные люди");
                                for (int j = 0; j < array.Count; j++)
                                {

                                    Console.WriteLine(array[j].familya + " " + array[j].name + "(" + j + ")");
                                }
                            }

                            else if (mode == 3)
                            {

                                Console.Write("Выберете номер пользователя: ");
                                int g = Convert.ToInt32(Console.ReadLine());

                                if (g > array.Count - 1 || g < 0)
                                {
                                    Console.WriteLine("Введен номер несуществующего пользователя возврат в меню ");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    Console.Write("Фамилия: ");
                                    Console.Write(array[g].familya);
                                    Console.WriteLine();

                                    Console.Write("Имя: ");
                                    Console.Write(array[g].name);
                                    Console.WriteLine();

                                    Console.Write("Отчество: ");
                                    Console.Write(array[g].ot4);
                                    Console.WriteLine();

                                    Console.Write("Телефон: ");
                                    Console.Write(array[g].telefon);
                                    Console.WriteLine();

                                    Console.Write("Страна: ");
                                    Console.Write(array[g].strana);
                                    Console.WriteLine();

                                    Console.Write("День рождения: ");
                                    Console.Write(array[g].day);
                                    Console.WriteLine();

                                    Console.Write("Месяц рождения: ");
                                    Console.Write(array[g].mes);
                                    Console.WriteLine();

                                    Console.Write("Год рождения: ");
                                    Console.Write(array[g].god);
                                    Console.WriteLine();

                                    Console.Write("Организация : ");
                                    Console.Write(array[g].organisation);
                                    Console.WriteLine();

                                    Console.Write("Должность : ");
                                    Console.Write(array[g].doljnost);
                                    Console.WriteLine();

                                    Console.Write("Заметка : ");
                                    Console.Write(array[g].zametki);
                                    Console.WriteLine();

                                }

                            }
                            else if (mode == 4)
                            {
                                break;
                            }
                        }
                    }
                }

                else if (mode == 5)
                {
                    if (array.Count == 0)
                    {
                        Console.Write("нет пользователей,возврат в меню");
                        Console.ReadKey();

                    }

                    else
                    {
                        for (int i = 0; i < array.Count; i++)
                        {

                            Console.Write("Фамилия: ");
                            Console.Write(array[i].familya);
                            Console.WriteLine();

                            Console.Write("Имя: ");
                            Console.Write(array[i].name);
                            Console.WriteLine();

                            Console.Write("Телефон: ");
                            Console.Write(array[i].telefon);
                            Console.WriteLine();
                        }
                    }
                }
                else if (mode == 6)
                {
                    break;
                }
            }
        }
    }
}


