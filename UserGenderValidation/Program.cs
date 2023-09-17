// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanimi
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr [kasutaja perekonnanimi] / //"Welcome, Mr [kasutaja perekonnanimi]"

Console.WriteLine("Please, select yor gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//Loeb konsoolist maha andmeid string (sõna) formaadis

Console.WriteLine("Please, enter last your name:");
string userLastName = Console.ReadLine();
 


if (userGender  == 'm')
{ Console.WriteLine($"Welcome, Mr. {userLastName} !"); }

else if (userGender == 'f')
{ Console.WriteLine($"Welcome, Ms. {userLastName}!"); }



else
{
    Console.WriteLine($"Welcome {userLastName}!");
}





