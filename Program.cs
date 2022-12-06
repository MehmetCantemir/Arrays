namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };
            int[] array;
            array=new int[5];


            //Dizilere değer atama ve erişim

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalaması

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[diziUzunlugu];
            int toplam = 0;
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0} sayısını giriniz: ",i+1);
                sayilar[i]=Convert.ToInt32(Console.ReadLine());
                
            }

            foreach (var item in sayilar)
            {
                toplam += item;
            }

            int average = toplam / diziUzunlugu;
            Console.WriteLine("Girilen Sayıların Ortalaması = {0}",average);
            



        }
    }
}