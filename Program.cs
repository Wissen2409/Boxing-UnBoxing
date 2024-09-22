
// Boxing ve Unboxing konuları, değişken tiplerinin birbirini kapsaması yada kapsayamaması konusudur.

// 15 adet değişken tipi var, 

// birde .net içeisinde, tüm tiplerden daha üstün olan bir tip var bu tipin adı object

// Object, .net içerisindeki önceden tanımlı olan 15 tipi ve aynı zamanda, bizim ileride yazacağımız
// kendi tiplerimizi de kapsar.

// Özetle: c#'ın en tepedeki tipi object'dir.


object o =10;
// object tipinde bir değişken, int tipinde bir değeri taşıdı

object o1 ="Merhaba";
// object tipinde bir değişken, string tipinde bir değeri taşıdı

object o2='A';
// object tipinde bir değişken, char tipinde bir değeri taşıdı

object o3 =true;
// object tipinde bir değişken, bool tipinde bir değeri taşıdı


/*object o5=10;
object o6=50;
Console.WriteLine((o5+o6).ToString());
*/

// iki adet object tanımlayıp içerisinde int değer verdik. Bu int değeri toplama yapmaya çalıştık
// ancak object tipinde + operatörü kullanılamıyor diye hata aldık 


// demekki, diğer değişkenler yerine object kullanamıyormuşuz

int a =10;
object o7 = a;
// yukarıdaki işlemin adı boxing


// boxlanan int tipini geri dışarı çıkartabilirim

// unboxing
int b =(int)o7;
Console.WriteLine(b);


// boxing int verdik ve int aldık

// peki int verip, başka tip olarak alabilir miyiz ?

// örnek int verip byte alalım

byte bite = (byte)o7;

// yukarıdaki kod bloğu çalıştığında, uygulama hata verecektir.
// çünkü boxing yapılan tip int tipidir. Farklı bir tip unboxing yapamaz

// bu iş için önce kutudan int'i çıkartıp, sonrasında tip dönüşümü yapıp, almak istediğimiz tipe almalıyız

byte bite2 = (byte)(int)o7;


// object her tipi alabildiği için, random tipinide boxing yaptık

object randomBoxing = new Random();


// Geri alalımn
Random rnd2  = (Random)randomBoxing;
// 


// ileri c#'da bu konuyu başka tipler üzeirnden tekrar konuşacaz.

