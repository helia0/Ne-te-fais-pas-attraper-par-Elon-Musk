using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;



#region Presentation

Console.WriteLine("Agent 007 : 'Bonjour Agent... ?'");
string agent = Console.ReadLine();
Console.WriteLine("Agent " + agent + " ? Ca sonne bien !");

Console.ReadKey();

Console.WriteLine("Agent " + agent + " nous avons une mission pour vous !");

Console.ReadKey();

Console.WriteLine("Mais avant de parler de cette mission !'\n'" +
    " Il faut absolument qu'on valide votre profil.");

Console.ReadKey();


Console.WriteLine(" Quelle est votre année de naissance ?");
string annee = Console.ReadLine();
int anneeActuel = 2023;
int? age = anneeActuel - Int32.Parse(annee);


Console.WriteLine(" Quel est votre genre?");
string genre = Console.ReadLine();

Console.WriteLine(" Quelle est votre ville de naissance ? ");
string ville = Console.ReadLine();

Console.ReadKey();

Console.WriteLine(" Tu as " + age + ", tu es un(e)" + genre + ", et tu es née à " + ville + "");

Console.ReadKey();



Console.WriteLine("Agent 007: 'Agent" + agent + ", voici votre mission ! '\n'" +
    "Bill GATES, créateur de Microsoft et ancien patron de cette même entreprise '\n'" +
    "à ete kidnapper. Et devinez qui est derriere tout ça ? ");


string reponseElon = Console.ReadLine();

if (reponseElon != "elon musk")
{
    Console.WriteLine(" Faux, c'est notre bon vieux Elon Musk !");
}

else
{
    Console.WriteLine("Exacte! Elon MUSK, l'homme le plus riche du monde");
}

Console.ReadKey();

Console.WriteLine("Agent 007 : 'Elon Musk à toujours voulu etre le number one mais '\n' " +
    " ayant marre que le monde se souviennent de Bill Gates comme etant celui '\n'" +
    " qui à toujours ete le numero un, malgré qu'il ne le soit plus. '\n'" +
    " Elon à decider de l'eliminer afin que le monde ne le compart plus avec Bill. '\n'" +
    " Apres plusieurs tentative, Elon a enfin mits la main sur Bill et c'est là que commence '\n'" +
    " votre mission !' Avant cela, acceptez-vous cette mision ?");


string validerlamission = Console.ReadLine();

if (validerlamission != "non")
{
    Console.WriteLine("Super, je vais vous expliquer vos instructions");
}

else

{
    Console.WriteLine("Mmmmh... n'oubliez pas de valider votre actualisation Pole emploi !");
}

Console.ReadKey();

Console.WriteLine("Afin de faire sortir Bill du piege, il faut lui donner 3 instructions : '\n', " +
    "'1-Avancer', '2-Droite' et '3-Gauche'. Il suffit juste de tapper les numeros d'instructions '\n'" +
    "afin de lui indiquer le chemin. Avez-vous compris ?");

string reponseComprehensions = Console.ReadLine();

switch (reponseComprehensions)
{
    case "oui":
        Console.WriteLine("A vous de jouer !");
        break;
    case "non":
        Console.WriteLine(" Mais t'es bete ou quoi ? Comment tu as reussie à passée l'éxamen d'entrée ?'\n'" +
               "Incroyable !!! Appuis seulement sur 1, 2, 3 ou 4 pour donner les directions à Bill");
        break;
}


Console.ReadKey();

#endregion


#region direction
string[] tableau = new string[6] { "Bill : Tres bien, j'avance !", "Bill : Tres bien, " +
    "je tourne à gauche !","Bill : Tres bien, je tourne à droite !", "Bill : Tres bien, je recule !"
,"Agent 007 : Attention!! Il y a un mur!", "Elon Musk : Bill Abandonne, je vais t'attrapper !"};

int choix = 0;
Random rand = new Random();
bool jeuFini = false;
while (!jeuFini)
{
    Console.WriteLine("Bill : Quelle direction dois-je prendre ?");
    choix = Int32.Parse(Console.ReadLine());
    switch(choix)
    {
        case 1:
        Console.WriteLine("avancer");
        break;
        case 2:
        Console.WriteLine("gauche");
        break;
        case 3:
        Console.WriteLine("droite");
        break;
        case 4:
        Console.WriteLine("reculer");
        break;
        default:
        Console.WriteLine("Bill : Je ne comprends pas ! ");
            jeuFini = true;
        break;

    }
    string phrases = tableau[rand.Next(0, 6)];
    Console.WriteLine(phrases);
}

#endregion



#region Coordonnées aleatoires 


//Le joueur peut passer
(int y, int x)[] couloirs = {(2,2), (2,3), (2,4), (3,4), (4,4), (5,4), (6,4), (6,2), (6,3), (7,2),(7,3),
(2,6),(2,8), (2,10), (2,11), (8,5), (8,6), (8,8), (11,3), (8,4), (9,4), (10,4), (11,4),(6,5), (7,5),
(8,5), (3,6), (3,7), (3,8), (3,10), (4,2), (4,3), (4,6), (4,8), (4,10), (4,11), (4,12), (5,4),(5,6),
(5,8),(5,12), (7,5), (7,6), (7,8), (6,5), (6,6),(6,8), (6,10),(6,11),(6,12), (7,10), (7,11), (7,12),
(8,9), (8,10),(8,11), (9,11), (9,12),(10,4), (10,6), (10,7), (10,9), (10,10), (10,11),(10,12), (11,3),
(11,4),(11,6), (11,7),(11,8),(11,9)};



//Joueur ne peut se balader !
(int y, int x)[] murs = {(1,1), (1,2),(1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9), (1,10),(1,11),
(1,12),(1,13), (1,1), (2,1), (3,1), (4,1), (5,1), (6,1), (7,1), (8,1), (9,1), (10,1),(11,1), (12,1),
(12,1),(12,2), (12,3),(12,4), (12,5), (12,6), (12,7), (12,8), (12,9), (12,10), (12,11), (12,12),(12,13),
(12,13),(11,13),(10,13),(9,13),(8,13),(7,13),(6,13),(5,13),(4,13),(3,13),(1,13)};

//Le joueur commence dans cette piece est doit trouver le MDP pour sortir
(int y, int x)[] pieceDebut = { (8, 2), (9, 2) };

//Le joueur fini dans cette piece est doit trouver le MDP pour finir le jeu
(int y, int x)[] pieceFin = { (2, 12) };

//Bill gates(le joueur)
(int y, int x)[] BillGates = { (8, 2) };

// position Elon
(int y, int x)[] ElonMusk = {(7,2)};


#endregion