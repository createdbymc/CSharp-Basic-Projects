Console.Write("notunuzu girin:");
int not = Convert.ToInt32(Console.ReadLine());

if(not >= 90){
  Console.Write("A");
}
else if(not >= 80) {
   Console.Write("B"); 
}
else if(not >= 60) {
   Console.Write("c"); 
}
else if(not >= 50) {
   Console.Write("D"); 
}
else {
   Console.Write("F"); 
}