using System;
using System.Collections.Generic;

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
                    Console.Write("Введите Фамилию: ");

                    temp = new Note();
                    temp.familya = Console.ReadLine();

                    if (temp.familya == "")
                    {
                        Console.WriteLine("Заполните обязательное поле(Фамилия)!!");
                    }

                    else
                    {

                        Console.Write("Введите Имя: ");
                        temp.name = Console.ReadLine();

                        if (temp.name == "")
                        {
                            Console.WriteLine("Заполните обязательное поле(Имя)!!");
                        }

                        else
                        {

                            Console.Write("Введите Отчество: ");
                            temp.ot4 = Console.ReadLine();

                            Console.Write("Введите телефон: ");
                            string buf = Console.ReadLine();

                            if (buf == "" || buf == " ")
                            {
                                Console.WriteLine("Заполните обязательное поле(телефон)!!");
                            }
                            else
                            {

                                temp.telefon = Convert.ToInt64(buf);

                                Console.Write("Введите страну: ");
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
                        Console.WriteLine("Редактирование записи:");
                        Console.Write("Записанные люди: ");

                        for (int j = 0; j < array.Count; j++)
                        {

                            Console.WriteLine(array[j].familya + "(" + j + ")");
                        }

                        Console.Write("Выберете номер пользователя: ");

                        int g = Convert.ToInt32(Console.ReadLine());


                        if (g > array.Count - 1 || g < 0)
                        {
                            Console.WriteLine("Введен номер несуществующего пользователя возврат в меню ");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.Write("1)изменение фамилии 2)изменение имени 3)изменение отчества 4)изменение телефона 5)изменение страны 6)изменение дня рождения 7)изменение месяца рождения 8)изменение года рождения 9)изменение организации 10)изменение должности 11)изменение заметки 12)возврат в меню: ");

                            int mode_1 = Convert.ToInt32(Console.ReadLine());


                            if (mode_1 == 1)

                            {
                                Console.Write("Введите Фамилию: ");

                                temp = new Note();
                                temp.familya = Console.ReadLine();
                                if (temp.familya == "")
                                {
                                    Console.WriteLine("Нужно заполнить поле(Фамилия)!!");
                                }

                                else
                                {
                                    array.Insert(g, temp);
                                    array.RemoveAt(g + 1);
                                }
                            }

                            else if (mode_1 == 2)
                            {
                                Console.Write("Введите Имя: ");

                                temp = new Note();
                                temp.name = Console.ReadLine();
                                if (temp.name == "")
                                {
                                    Console.WriteLine("Нужно заполнить поле(Имя)!!");
                                }

                                else
                                {
                                    array.Insert(g, temp);
                                    array.RemoveAt(g + 1);
                                }
                            }

                            else if (mode_1 == 3)
                            {
                                Console.Write("Введите Отчество: ");

                                temp = new Note();
                                temp.ot4 = Console.ReadLine();
                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);
                            }

                            else if (mode_1 == 4)
                            {
                                Console.Write("Введите телефон: ");

                                temp = new Note();
                                string buf = Console.ReadLine();

                                if (buf == "" || buf == " ")
                                {
                                    Console.WriteLine("Нужно заполнить обязательное поле (Телефон) ");
                                }

                                else
                                {
                                    temp.telefon = Convert.ToInt64(buf);
                                    array.Insert(g, temp);
                                    array.RemoveAt(g + 1);
                                }
                            }

                            else if (mode_1 == 5)
                            {
                                Console.Write("Введите страну: ");

                                temp = new Note();
                                temp.strana = Console.ReadLine();
                                if (temp.strana == "")
                                {
                                    Console.WriteLine("Нужно заполнить поле(Страна)!!");
                                }

                                else
                                {
                                    array.Insert(g, temp);
                                    array.RemoveAt(g + 1);
                                }
                            }

                            else if (mode_1 == 6)
                            {
                                Console.Write("Введите день рождения: ");

                                temp = new Note();
                                string buf = Console.ReadLine();

                                if (buf == "" || buf == " ")
                                {
                                    buf = "0";
                                }

                                temp.day = Convert.ToInt32(buf);

                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);

                            }

                            else if (mode_1 == 7)
                            {
                                Console.Write("Введите месяц рождения: ");
                                temp = new Note();
                                string buf = Console.ReadLine();

                                if (buf == "" || buf == " ")
                                {
                                    buf = "0";
                                }
                                temp.mes = Convert.ToInt32(buf);
                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);

                            }


                            else if (mode_1 == 8)
                            {
                                Console.Write("Введите год рождения : ");
                                temp = new Note();

                                string buf = Console.ReadLine();

                                if (buf == "" || buf == " ")
                                {
                                    buf = "0";
                                }
                                temp.god = Convert.ToInt32(buf);

                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);
                            }

                            else if (mode_1 == 9)
                            {
                                Console.Write("Введите организацию: ");
                                temp = new Note();
                                temp.organisation = Console.ReadLine();
                                array.Add(temp);
                            }

                            else if (mode_1 == 10)
                            {
                                Console.Write("Введите должность: ");
                                temp = new Note();
                                temp.doljnost = Console.ReadLine();
                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);
                            }

                            else if (mode_1 == 11)
                            {
                                Console.Write("Введите заметки: ");
                                temp = new Note();
                                temp.zametki = Console.ReadLine();
                                array.Insert(g, temp);
                                array.RemoveAt(g + 1);
                            }

                            else if (mode_1 == 12)
                            {
                                Console.Write("Возврат в меню ");
                            }

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

                        Console.Write("Записанные люди: ");

                        for (int j = 0; j < array.Count; j++)
                        {

                            Console.WriteLine(array[j].familya + "(" + j + ")");

                        }

                        Console.Write("Выберете номер пользователя: ");
                        int g = Convert.ToInt32(Console.ReadLine());
                        int p = g + 1;
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
                        Console.Write("Записанные люди: ");

                        for (int j = 0; j < array.Count; j++)
                        {

                            Console.WriteLine(array[j].familya + "(" + j + ")");
                        }

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


