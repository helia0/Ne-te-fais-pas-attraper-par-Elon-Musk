//calcule et retourne un int

//1) nom de la fonction
//2) paramètres avec type FACULTATIF
//3) return obligatoire
//4) réciser le type du retour

using System.Security.Cryptography.X509Certificates;

Console.Write("En quelle annee est tu nee ??");

int? anneeActuel = 2023;
string? annee = Console.ReadLine();
int? age = anneeActuel - Int32.Parse(annee);

Console.WriteLine("Tu as " + age + " ans ");


Console.WriteLine("Quel est ton nom ?");
string? prenom = Console.ReadLine();

Console.ReadKey();

Console.WriteLine("Enchanté" + prenom + "");

Console.WriteLine("On vas jouer a un jeu!" + prenom + "Est tu prêts? OUI ou NON?");

string? reponse = Console.ReadLine();


if (reponse == "oui") ;
{
    Console.WriteLine("Genial, on peut jouer !");
    // Bloc d'instructions si la condition est vraie
}
else 
{
    Console.WriteLine("Grave deçus !! BYE BYE");
    // Bloc d'instructions si la condition est fausse
}


Console.ReadKey(); 

Console.WriteLine(" Bienvenue" + prenom + "dans le plus grand labyrinthe du monde. Pas d'allies & pas d'aides", '\n',
    "tu seras tout seul ! Bonne Chance & essaye de pas crever !");

Console.ReadKey();

//The wall manage
int addWall = 5;
string wall;

// Movements
string avance;
string droite;
string gauche;
string recule;

// Characters
string joueur;
string elonmusk;
string billGates;

// Dead and life
string life;
string dead;

//Objects
int trapes = 1;
int voitureTesla = 1;

   








Console.ReadKey();

