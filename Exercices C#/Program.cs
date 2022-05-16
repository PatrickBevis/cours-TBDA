
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//1 Déclarer var type string nommée texte
// string texte;
//2 
// int number = 0;
//3Déclarer var type string 
// byte counter;
//4
// counter = 1;
//5
// Boolean test = 0 == 1;
//6
// int a = 7, b = 3;

// int sum = a + b;
// int diff = a - b;
// int prod = a * b;
// int quot = a / b;
// int modulo = a % b;

//7

// string texte2 = Console.ReadLine();


// Console.WriteLine("Veuillez saisir votre nom");
// string nom = Console.ReadLine();

// Console.WriteLine("Veuillez saisir votre nom");
// string prenom = Console.ReadLine();

// Console.WriteLine("Veuillez saisir votre age");
// string agesaisi = Console.ReadLine();
// int age = Convert.ToInt32(agesaisi);

// if (age < 18) {
//     Console.WriteLine("mineur");
// }
// else
// {
//     Console.WriteLine("majeur");
// }

// Console.WriteLine("Veuillez saisir un nombre");
// string nbSaisi = Console.ReadLine();
// int nb = Convert.ToInt32(nbSaisi);

// if (nb >= 0)
// {
//     Console.WriteLine("positif");
// }
// else
// {
//     Console.WriteLine("negatif");
// }

// Console.WriteLine("Veuillez saisir un nombre");
// string nbSaisi = Console.ReadLine();
// int nb = Convert.ToInt32(nbSaisi);

// if (nb > 0)
// {
//     Console.WriteLine("positif");
// }
// else if (nb < 0)
// {
//     Console.WriteLine("negatif");

// }
// else
// {

//     Console.WriteLine("vaut 0");
// }



// Console.WriteLine("Veuillez saisir un premier nombre");
// string a1 = Console.ReadLine();
// int a = Convert.ToInt32(a1);

// Console.WriteLine("Veuillez saisir un second nombre");
// string b1 = Console.ReadLine();
// int b = Convert.ToInt32(b1);

// Console.WriteLine("Choississez une opération");
// string operation = Console.ReadLine();

// if (operation == "sum"){
// int result = a + b;
// Console.WriteLine("Le résultat est de "+ result);
// }
// if (operation == "diff"){
// int result = a - b;
// Console.WriteLine("Le résultat est de "+ result);
// }
// if (operation == "quot"){
// int result = a / b;
// Console.WriteLine("Le résultat est de "+ result);
// }
// if (operation == "prod"){
// int result = a * b;
// Console.WriteLine("Le résultat est de "+ result);
// }

//11

// Console.WriteLine("Veuillez saisir un premier nom");
// string nom1 = Console.ReadLine();
// Console.WriteLine("Veuillez saisir un second nom");
// string nom2 = Console.ReadLine();
// Console.WriteLine("Veuillez saisir un troisieme nom");
// string nom3 = Console.ReadLine();

// if (nom1.CompareTo(nom2) == 0)
// {
//     Console.WriteLine("Meme nom");
// }
// else if (nom1.CompareTo(nom2) < 0)
// {
//     Console.WriteLine("Le" + nom1 + "precede" + nom2);
// }
// else if (nom1.CompareTo(nom2) > 0)
// {
//     Console.WriteLine("Le " + nom1 + " suit " + nom2);
// }


// if (nom2.CompareTo(nom3) == 0)
// {
//     Console.WriteLine("Meme nom");}
//             else if (nom2.CompareTo(nom3) < 0){
//         Console.WriteLine("Le " + nom2 + " precede " + nom3);}
//     else if (nom2.CompareTo(nom3) > 0){
//         Console.WriteLine("Le " + nom2 + " suit " + nom3);
// }

// if (nom1.CompareTo(nom3) == 0)
// {
//     Console.WriteLine("Meme nom");}
//             else if (nom1.CompareTo(nom3) < 0){
//         Console.WriteLine("Le " + nom1 + " precede " + nom3);}
//     else if (nom1.CompareTo(nom3) > 0){
//         Console.WriteLine("Le " + nom1 + " suit " + nom3);
// }






//Ex 13
// void Addition(int nb1, int nb2){
//     int result = nb1 + nb2;
//     Console.WriteLine(result);

// }

// Addition (1, 2);
// Addition(7, 15);
// Addition(8,155);

// void Soustraction(int nb1, int nb2){
//     int result = nb1 - nb2;
//     Console.WriteLine(result);

// }

// Soustraction(25,8);
// Soustraction(2, 58);
// Soustraction(154,155);

// void Multiplication(int nb1, int nb2){
//     int result = nb1 * nb2;
//     Console.WriteLine(result);

// }

// Multiplication(10,8);
// Multiplication(2, 25);
// Multiplication(4,124);

// void Division(int nb1, int nb2){
//     int result = nb1 / nb2;
//     Console.WriteLine(result);

// }

// Division(498,125);
// Division(155, 4);
// Division(2022,124);

// int Addition(int nb1, int nb2){
//     int result = nb1 + nb2;
//     return result;
// }

// int sum = Addition(5,6);
// Console.WriteLine(sum);

//13
// int Triangle(int Base, int Hauteur)
// {
//     int resultSurface = (Base * Hauteur) / 2;
//     return resultSurface;
// }

// int surface = Triangle(5, 6);
// Console.WriteLine(surface);

//14
// Console.WriteLine("Age ?");
// string saisie = Console.ReadLine();
// int age = Convert.ToInt32(saisie);
// DisplayCategoryOfThePlayer(age); //Afficher catégorie
// void DisplayCategoryOfThePlayer(int ageParam)
// {
//     string category = "";

//     if (age < 5)
//     {
//         category = "no way!";
//     }
//     if (age == 5 || age == 6)
//     {
//         category = "baby foot";

//     }
//     //...
//     if (age == 15 || age == 16 || age == 17)
//     {
//         category = "junior";
//     }
//     if (age >= 18)
//     {
//         category = "Va avec les grands";

//     }
//     Console.WriteLine(category);
// }

//15


// Console.WriteLine("Combien de photocopies voulez-vous ?");
// string saisie1 = Console.ReadLine();
// int nb = Convert.ToInt32(saisie1);

// double prix =0;




// if (nb <=10){
//     prix= nb*0.10;
//     

//     }

//     if (nb >10 && nb <= 30){
//     prix= (nb-10)*0.09+1;
//      

//     }

//     if (nb > 30){
//     prix= (nb-30)*0.08+1+1.80;
//      

//     }
//Console.WriteLine("Le montant est de " + prix +"€");
//Ex16

//string texte = Console.ReadLine();

//int nombre = -1;
//Ex 18
// Console.WriteLine("Saississez un nombre?");
//  string saisie = Console.ReadLine();
// int nombre = Convert.ToInt32(saisie);

// if (nombre % 2  == 0)
// {
//     Console.WriteLine("Le " + nombre+ " est pair");

// }
// else {
//     Console.WriteLine("Le " + nombre+ " est impair");
// }

// Ex 19
//  Console.WriteLine("Saississez un nombre?");
// string saisie = Console.ReadLine();
//  int nombre = Convert.ToInt32(saisie);
// int result = 0;

// result = nombre*nombre;

// Console.WriteLine($"Le carré de {nombre} est {result}");

//Ex20 
// Console.WriteLine("Saississez un nombre d'article");
//   string saisie = Console.ReadLine();
//  int nombre = Convert.ToInt32(saisie);

//int nombre = Convert.ToInt32(Console.ReadLine); //simplification de la conversion

// Console.WriteLine("Saississez un prix HT");
//   string saisie1 = Console.ReadLine();
//  int prixHT = Convert.ToInt32(saisie1);

//  Console.WriteLine("Saississez une tva");
//   string saisie2 = Console.ReadLine();
//  double tva = Convert.ToDouble(saisie2);

//  double prixTTC = 0;

//  prixTTC = nombre *(prixHT*tva+prixHT);
// Console.WriteLine($"Le montant total est de {prixTTC}€");

//alternative ex 20

// double CalcPrixTTC(int nbArt, double prixHT, double txTva){
// double result = nbArt * (prixHT + prixHT * txTva / 100);
// return result;
// }



// Console.WriteLine("Saississez un nombre d'article");
//   string saisie = Console.ReadLine();
//  int nbArt = Convert.ToInt32(saisie);

// Console.WriteLine("Saississez un prix HT");
//   string saisie1 = Console.ReadLine();
//  double prixHT = Convert.ToDouble(saisie1);

//  Console.WriteLine("Saississez une tva");
//   string saisie2 = Console.ReadLine();
//  double txTva = Convert.ToDouble(saisie2);

// double prixTTC = CalcPrixTTC (nbArt,prixHT,txTva);
// Console.WriteLine(prixTTC);


//Exo 21 : Écrire une fonction qui prend un nombre entier de minutes et le convertit en secondes 

//int CalcSecs(int minutes){
//int result = minutes * 60;
//return result;
//}
//
//int secondes = CalcSecs(minutes);
//Console.WriteLine(secondes);
//
//Exo 22 : Écrire un algorithme permettant d’échanger les valeurs de deux variables de type string v1 et v2, et ce quel que soit leur contenu préalable (demander à l’utilisateur de saisir successivement les 2 valeurs avant de procéder à l’échange)
//(echec)

// string v1, v2;
// void intervertir (string v1, string v2){

// string temp = v1;
// v1 = v2;
// v2 = temp;

// Console.WriteLine("Apres echenge :"); //swap
// Console.WriteLine($"La variable 1 est :{v1}");
// Console.WriteLine($"La variable 2 est :{v2}");
// //
// }
// Console.WriteLine("Saisissez une premiere variable ?");
// v1 = Console.ReadLine();

// Console.WriteLine("Saisissez une deuxieme variable ?");
// v2 = Console.ReadLine();

// intervertir(v1,v2);
// 
// string a, b;
// void intervertir(string a, string b)
// {
//    string temp = a;
//    a = b;
//    b = temp;
//    Console.WriteLine($"\n«a» contient maintenant : {a}");
//    Console.WriteLine($"«b» contient maintenant : {b}\n");

// }
// Console.Write("Entrer une phrase dans la boite «a» : ");
// a = Console.ReadLine();

// Console.Write("Entrer une phrase dans la boite «b» : ");
// b = Console.ReadLine();


// intervertir(a, b);


//Exo 23 : Écrire un algorithme qui demande 3 nombres et affiche lequel est le plus grand et aussi petit

//int max(int nb1, int nb2, int nb3){
//  int result = Math.Max(nb1,Math.Max(nb2,nb3));
//  return result;
//}
//
//Console.Write("Entrer nombre 1");
// nb1 = Console.ReadLine();

//Console.Write("Entrer nombre 2");
// nb2 = Console.ReadLine();

//Console.Write("Entrer nombre 3");
// nb3 = Console.ReadLine();

//int maxi =max(nb1,nb2,nb3);
//Console.WriteLine(maxi);
//
//int min(int nb1, int nb2, int nb3){
//  int result = Math.Min(nb1,Math.Min(nb2,nb3));
//  return result;
//}
//
//int mini =min(nb1,nb2,nb3);
//Console.WriteLine(mini);

//alternative

//Console.Write("Entrer nombre 1");
// nb1 = Console.ReadLine();

//Console.Write("Entrer nombre 2");
// nb2 = Console.ReadLine();

//Console.Write("Entrer nombre 3");
// nb3 = Console.ReadLine();




//Exo 24 : Écrire un algorithme qui demande 3 nombres et les affiche ensuite triés par ordre croissant
// Console.WriteLine("v1");
// int vSaisi = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("v2");
// int vSaisi2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("v3");
// int vSaisi3 = Convert.ToInt32(Console.ReadLine());

// void tries(int nb1, int nb2, int nb3){
// int[] tab = new int[] {nb1,nb2,nb3};
// Array.Sort(tab);
// for (int i = 0; i < tab.Length; i++)
// {
//     Console.WriteLine(tab[i]);
// }
// }

// tries(vSaisi, vSaisi2, vSaisi3);

//Exo 25 : Écrire un algorithme qui après avoir demandé un numéro de jour, de mois et d'année à l'utilisateur, renvoie true s'il s'agit d'une date valide (Attention aux années bissextiles)
// bool dateIsValid(int day, int month, int year)
// {
//     bool result = false;
//     //31 jours : 1 3 5 7 8 10 12
//     if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
//     {
//         if (day > 0 && day <= 31)
//         {
//             result = true;
//         }
//     }
//     //30 jours : 4 6 9 11
//     else if (month == 4 || month == 6 || month == 9 || month == 11)
//     {
//         if (day > 0 && day <= 30)
//         {
//             result = true;
//         }
//     }
//     else if (month == 2)
//     {
//         bool isBisextil = (year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
//         //isBisextil = year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0));

//         //29 jours : 2 && bs
//         if (isBisextil && day == 29)
//         {
//             result = true;
//         }
//         //28 jours : 2 && !bs
//         if (!isBisextil && day == 28)
//         {
//             result = true;
//         }

//     }

//     return result;
// }

// dateIsValid(20, 13, 2020);




//Exo 26 : écrire une fonction qui renvoie true si son premier argument est divisible par le second

int number1 = Convert.ToInt32(Console.ReadLine);
int diviser = Convert.ToInt32(Console.ReadLine);

bool isDivisible(int number1, int diviser)
{

    if (diviser == 0)
    {

        return false;
    }

    bool resultat = number1 % diviser == 0;

    return resultat;

}
 isDivisible(number1,diviser);



//Exo 27 : écrire un algorithme qui demande un nombre à l’utilisateur et qui indique quels sont ses diviseurs compris entre 2 et 10
//ex : 
//si le nombre saisi est 60 ses diviseurs sont 2,3,4,5,6 et 10
//si le nombre saisi est 18, ses diviseurs sont 2,3,6,9
//si le nombre saisi est 13, il n’y a aucun diviseur

