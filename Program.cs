// fungsi digunakan sebagai fungsi aritmatika biasa pada umumnya, maulai dari pertambahan, perkalian, perngurangan, pembagian, dan modulo
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
       // var penjumalahan = 10 + 5;
        //var pengurangan = 10 - 5;
        //var penkalian = 10 * 5;
        //var pembagian = 10 / 5;
       // var modulo = 10 % 5;

        //Console.WriteLine(penjumalahan);
        //Console.WriteLine(pengurangan);
        //Console.WriteLine(penkalian);
        //Console.WriteLine(pembagian);
       // Console.WriteLine(modulo);

        //tak jauh berbeda dengan diatas fungsi ini juga mimiliki artian sama sebagai alat penghitung aritmatika pada umumnya
        var angka = 10;
        angka += 5;
        Console.WriteLine("Hasilnya: " + angka);
        angka -= 5;
        Console.WriteLine("Hasilnya: " + angka);
        angka *= 5;
        Console.WriteLine("Hasilnya: " + angka);
        angka /= 5;
        Console.WriteLine("Hasilnya: " + angka);
        angka %= 5;
        Console.WriteLine("Hasilnya: " + angka);

        //increment dan Decrement, logika paling mudahnya tak jauh berbeda dengan penambahan dan penjumlahan biasa, hanya saja penggunaannya beberda biasa fungsi ini dugunakan untuk dijalankna antara seteah dan sebelum program membaca deklarasi variable
        int b = 5;
        Console.WriteLine("Nilai +b = " + +b);
        Console.WriteLine("Nilai ++b = " + ++b);
        Console.WriteLine("Nilai b++ = " + b++);

        Console.WriteLine("Nilai -b = " + -b);
        Console.WriteLine("Nilai --b = " + --b);
        Console.WriteLine("Nilai b-- = " + b--);

        //oprator perbandingan biasa digunakan dalam program yang membutuhkan seuatu kondisi seperti percabangan atau perulangan. biasa digunakan untuk menentukan nilai, apakah sautu nilai bisa kitakan sama, lebih, atau sebuah nilai bisa dikatan benar atau salah
        int c = 10;
        int d = 5;

        Console.WriteLine(c != d);
        Console.WriteLine(c == d);
        Console.WriteLine(c > d);
        Console.WriteLine(c < d);
        Console.WriteLine(c >= d);
        Console.WriteLine(c <= d);

        //percabangan menggunakan if, percabangan biasa digunakan ketika program diminta menjalankan lebih dari satu kemungkinan dalam banyak kondisi
        int a = 10;

        if (a == 10)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

        //if juga bisa ditambahkan menjadi lebih dari satu percabangan menggunakan kode else if, dengna fungsi yang sama jadi pengguna bisa menentukan kondisi berbeda dari dalam satu program if
        if (a == 10)
        {
            Console.WriteLine("true");
        }
        else if (a != 10)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("false");
        }

        //swtich sama halnya dengan if switch adalah sebuah program percabangan, yang membedakan switch tidak bisa menggunakan kondisi dan berbasis pada tipe data
        switch (a)
        {
            case 10:
                Console.WriteLine("true");
                break;
            default:
                Console.WriteLine("false");
                break;
        }

        //ternary sama halnya dengan if dan swtich ternary juga dimanfaatkan sebagai percabangan, hanya saja dengan kode lebih simpel, maka dianjutkan dalam menggunakan ternery hanya menambahkan 2 percabangan saja
        string k = a == 10 ? "true" : "false";
        Console.WriteLine(k);

        //array biasa digunakan agar suatu deklarasi variable bisa menyimpan lebih dari satu data, dimana setiap data yang masuk ke array akan diberi index yang dapat dipanggil mengikuti urutan dari array
        string[] nama = { "Budi", "ahmad", "Valarad" };
        Console.WriteLine(nama[0]);

        //untuk array total mimiliki 3 dimensi semakin banyak dimensi semakin banyak pula data yang bisa disimpan namun disini saya hanya akn fokus pada satu demensi saja

        //list sama halnya dengan array list juga digunakan untuk menyimpan lebih dari satu data hanya saja list menggunakan urutan lebih terperinci, dan pengguna bisa menambahkan menghapus isi dari list
        var names = new List<string> { "Kamiyama", "Touma", "Sintosa" };
        //dalam penggunaan list juga menggunakan program dikenal sebagai loop atau perulangan dimana loop akan otomatis memanggil isi dari list 
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        //sama halnya dengan for while juga digunakan sebagai loop 
        int j = 0;
        while (1 < 3)
        {
            Console.WriteLine(j);
            j++;
        }

        //
        int l = 0;

            do
            {
                Console.WriteLine(l);
                l++;
            }
            while (1 < 3);
        
    }
}