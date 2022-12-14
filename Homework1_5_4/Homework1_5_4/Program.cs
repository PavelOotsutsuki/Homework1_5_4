using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_5_4
{
    class Program
    {
        const string CaseAddDossier = "1";
        const string CasePrintAllDossier = "2";
        const string CaseRemoveDossier = "3";
        const string CaseExit = "4";

        static void Main(string[] args)
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>();

            Work(dossier);

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void Work(Dictionary <string, string> dossier)
        {
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case CaseAddDossier:
                        AddDossier(ref dossier);
                        break;
                    case CasePrintAllDossier:
                        PrintAllDossier(dossier);
                        break;
                    case CaseRemoveDossier:
                        RemoveDossier(ref dossier);
                        break;
                    case CaseExit:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Неверная команда");
                        break;
                }

                Console.ReadKey();
            }
        }

        static void PrintAllDossier(Dictionary <string, string> dossier)
        {
            int fileNumber = 1;

            foreach (var file in dossier)
            {
                Console.WriteLine(fileNumber + ". " + file.Key + " - " + file.Value);
                fileNumber++;
            }
        }

        static void AddDossier(ref Dictionary <string, string> dossier)
        {
            Console.Write("Введите ФИО: ");
            string fullname = Console.ReadLine();
            Console.Write("Введите должность: ");
            string post = Console.ReadLine();

            if (dossier.ContainsKey(fullname) == false)
            {
                dossier.Add(fullname, post);
                Console.WriteLine("Досье добавлено");
            }
            else
            {
                Console.WriteLine("Досье не добавлено. Такое ФИО уже существует");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine(CaseAddDossier + " - добавить досье");
            Console.WriteLine(CasePrintAllDossier + " - вывод всех досье");
            Console.WriteLine(CaseRemoveDossier + " - удалить досье");
            Console.WriteLine(CaseExit + " - выход");
            Console.WriteLine();
        }

        static void RemoveDossier(ref Dictionary <string, string> dossier)
        {
            Console.Write("Введите ФИО досье, которое хотите удалить: ");
            string fullname = Console.ReadLine();

            if (dossier.ContainsKey(fullname))
            {
                dossier.Remove(fullname);
            }
            else
            {
                Console.WriteLine("Такой фамилии нет");
            }
        }
    }
}

