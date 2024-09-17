Console.WriteLine("välj en rikte där du vill gå till höger,vänster eller rakt fram?");
string direction = Console.ReadLine();

if (direction.ToLower() == "vänster")
{
   Console.WriteLine("här så hittar du allt möjligt");
   Console.WriteLine("välj en vara");
   string produkt = Console.ReadLine();
   if (produkt == "bil")
   {

   }
   
}
else if (direction.ToLower() == "höger")
{
   Console.WriteLine("här så kan du hitta alla vardadgs varor vad än du vill ha här så får du välja ändast 3 varor för vardags rumet");
   Console.WriteLine("välj en av de varorna. soffa,tv,fötölje eller bord?");
   string produkt = Console.ReadLine();
    if (produkt == "soffa")
    {

    }
}
else if (direction.ToLower() == "rakt fram")
{
    Console.WriteLine("här så hittar du alla badrums varor vad än du vill ha till badrumet till ditt hus");
    Console.WriteLine("välj en av de varorna. badkar,skåp och toalet?");
   string produkt = Console.ReadLine();
    if (produkt == "skåp")
    {

    }
}
Console.ReadLine();