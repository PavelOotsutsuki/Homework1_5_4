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
            Dictionary<string, string> dossiers = new Dictionary<string, string>();

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
                        AddDossier(dossiers);
                        break;
                    case CasePrintAllDossier:
                        PrintAllDossier(dossiers);
                        break;
                    case CaseRemoveDossier:
                        RemoveDossier(dossiers);
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

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void PrintAllDossier(Dictionary <string, string> dossiers)
        {
            int fileNumber = 1;

            foreach (var file in dossiers)
            {
                Console.WriteLine(fileNumber + ". " + file.Key + " - " + file.Value);
                fileNumber++;
            }
        }

        static void AddDossier(Dictionary <string, string> dossiers)
        {
            Console.Write("Введите ФИО: ");
            string fullname = Console.ReadLine();
            Console.Write("Введите должность: ");
            string post = Console.ReadLine();

            if (dossiers.ContainsKey(fullname) == false)
            {
                dossiers.Add(fullname, post);
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

        static void RemoveDossier(Dictionary <string, string> dossiers)
        {
            Console.Write("Введите ФИО досье, которое хотите удалить: ");
            string fullname = Console.ReadLine();

            if (dossiers.ContainsKey(fullname))
            {
                dossiers.Remove(fullname);
            }
            else
            {
                Console.WriteLine("Такой фамилии нет");
            }
        }
    }
}

