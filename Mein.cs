using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Mein
    {
        public static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Esimene");
            //arrayList.Add("Teine");
            //arrayList.Add("Kolmas");
            //if (arrayList.Contains("Teine"))
            //{
            //    Console.WriteLine("Sõna Teine on olemas");
            //    Console.WriteLine("Teine asub kohal " + arrayList.IndexOf("Teine"));
            //}
            //else
            //{
            //    Console.WriteLine("Otsitav sõna puudub");
            //}
            //Console.WriteLine("Kokku järjendis on "+arrayList.Count+" elemente");
            //arrayList.Insert(3, "Neljas");
            //arrayList.Insert(4, "Viies");
            //arrayList.Sort();
            //foreach (string item in arrayList)
            //{
            //    Console.Write(item + ", ");
            //}
            //arrayList.RemoveAt(0);
            //arrayList.Remove("Viies");
            //arrayList.Clear();

            //List<Inimene> list = new List<Inimene>();
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //list.Add(inimene);
            //list.Add(new Inimene() { Nimi = "Kati" });

            //foreach (Inimene item in list)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //Dictionary<int, string> dic = new Dictionary<int, string>(5);
            //dic.Add(1, "Üks");
            //dic.Add(2, "Kaks");
            //dic[3] = "Kolm";
            //dic.Add(4, "Neli");
            //dic.Add(5, "Viis");
            //foreach (KeyValuePair<int,string> keyValue in dic)
            //{
            //    Console.WriteLine(keyValue.Key+" - "+keyValue.Value);
            //}

            //Dictionary<int, Inimene> õpilased = new Dictionary<int, Inimene>(3);
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //Inimene inimene2 = new Inimene();
            //inimene2.Nimi = "Kati";
            //inimene2.Vanus = 35;
            //õpilased.Add(1, inimene);
            //õpilased.Add(2, inimene2);
            //õpilased.Add(3, new Inimene() {Nimi = "Marina", Vanus = 100});
            //foreach (Inimene item in õpilased.Values)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //foreach (KeyValuePair<int, Inimene> item in õpilased)
            //{
            //    Console.WriteLine(item.Key +": "+item.Value.Nimi);
            //}

            //try
            //{
            //    StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt",true);
            //    string lause = "Lisan failisse lause\n";
            //    text.WriteLine(lause);
            //    text.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //try
            //{
            //    StreamReader text = new StreamReader(@"..\..\..\TextFile.txt", true);
            //    string laused = text.ReadToEnd();
            //    text.Close();
            //    Console.WriteLine("Failis on jägrmine informatsion: \n");
            //    Console.WriteLine(laused);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //List<string> list_failist = new List<string>();
            //try
            //{
            //    foreach (string rida in File.ReadAllLines(@"..\..\..\TextFile.txt"))
            //    {
            //        list_failist.Add(rida);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}
            //foreach (var rida in list_failist)
            //{
            //    Console.WriteLine(rida);
            //}


            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Varjuta Backspace");
            //    nupp=Console.ReadKey();
            //} while (nupp.Key !=ConsoleKey.Backspace);

            //double aritm = Alamprogramm.Keskmine(2);
            //Console.WriteLine(aritm);

            //string kassid = Alamprogramm.Kassi_kalkulaator(25,35,'+');
            //Console.WriteLine(kassid);

            //Alamprogramm.Stars(20);

            //Alamprogramm.NStars(5);

            List<string> list_failist = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\Eesti.txt"))
                {
                    list_failist.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga");
                throw;
            }
            foreach (var rida in list_failist)
            {
                Console.WriteLine(rida);
            }


            var dict = list_failist.ToDictionary(x => x);
            
            Console.WriteLine(dict);

        }


    }
}
