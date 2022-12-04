using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace def
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new String[5];

            string[] animals =  {"Kedi","Köpek","Kuş","Kaplumbağa","Kaplan"};

            int[] dizi;
            dizi= new int[5];

            colors[3]= "Mavi";
            dizi[3]=10;

            Console.WriteLine(animals[3]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(colors[3]);
            
            Console.WriteLine("> bir sayı giriniz: ");
            int lenghtofarray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtofarray];
            for(int i = 0; i<lenghtofarray;i++){
                Console.WriteLine("Lütfen " + (i+1) + " sayısını giriniz");
                array[i] = int.Parse(Console.ReadLine());

            }
            int toplam =0;
            foreach(var sayi in array){
                toplam += sayi;
            }
            Console.WriteLine(toplam/lenghtofarray);
        }
    }
}