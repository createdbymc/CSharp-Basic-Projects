Console.Write("Yaşınızı girin:");

int yas = Convert.ToInt32(Console.ReadLine());
if(yas >= 18 ){
    Console.Write("Giriş Yapabilirsiniz.");
    }
else if(yas <= 0) {
    Console.Write("Yanlış Değer girildi.");
}
else {
 Console.Write("Siteye Giriş yapamazsınız.");
}
