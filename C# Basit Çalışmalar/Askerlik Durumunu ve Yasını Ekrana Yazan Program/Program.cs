Console.Write("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.Write("Okula gidiyor musunuz? (evet, hayır): ");
string okulaGidiyorMu = Console.ReadLine().ToLower();

if (yas >= 18 && okulaGidiyorMu == "hayır") {
    Console.WriteLine("Askere gitme yaşınız geldi.");
} 
else if (yas >= 18 && okulaGidiyorMu == "evet") { 
    Console.WriteLine("Okulunuz bitince askere gideceksiniz.");
} 
else {
    Console.WriteLine("Askerlik yaşınız daha gelmedi.");
}
