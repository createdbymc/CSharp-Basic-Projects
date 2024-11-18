Console.Write("Ehliyetiniz var mı? (Evet: e, Hayır: h)" );
string ehliyet = Console.ReadLine();

Console.Write("Arabanız var mı? (Evet: e, Hayır: h)" );
string araba = Console.ReadLine();

if (araba == "e" && ehliyet == "e") {
    Console.Write("Araç kullanmanızda sakınca yoktur");
}
else if (araba == "e" || ehliyet == "e") {
    Console.Write("Araba kullanmana çok az kaldı");
}
else {
    Console.WriteLine("Araç kullanamazsın");
}


