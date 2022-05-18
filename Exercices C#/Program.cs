
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
// Console.WriteLine("Saisir un nombre");
// int number1 = Convert.ToInt32(Console.ReadLine);
// Console.WriteLine("Saisir un diviseur");
// int diviser = Convert.ToInt32(Console.ReadLine);

// bool isDivisible(int number1, int diviser)
// {

//     if (diviser == 0)
//     {

//         return false;
//     }

//     bool resultat = number1 % diviser == 0;

//     return resultat;

//}
// bool resultat =isDivisible(); //faux (527)


//Exo 27 : écrire un algorithme qui demande un nombre à l’utilisateur et qui indique quels sont ses diviseurs compris entre 2 et 10
//ex : 
//si le nombre saisi est 60 ses diviseurs sont 2,3,4,5,6 et 10
//si le nombre saisi est 18, ses diviseurs sont 2,3,6,9
//si le nombre saisi est 13, il n’y a aucun diviseur

//(echec)

// int number = 0;


//  bool isDivisible(int number1, int diviser)
// {
//     bool result = false;

//     if(diviser == 2 || diviser == 3 || diviser == 4 || diviser == 5 || diviser == 5 || diviser == 6 || diviser == 7 || diviser == 8 || diviser == 9 || diviser == 10);
//         else if (number1%diviser ==0);

//     result = true;
//     return result;
// }

//Exo 28 : Créer une méthode (fonction) qui renvoie (return) le plus petit nombre parmis ses 2 paramètres de type entier

// int PlusPetit(int nombre1, int nombre2){

//     if (nombre1<nombre2){

//         return nombre1;
//     }

//     else{
//         return nombre2;
//     }

// }
// Console.WriteLine ("Saisir nombre 1");

// int nombre1 =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Saisir nombre 2");
// int nombre2 =Convert.ToInt32(Console.ReadLine());

// int mini = PlusPetit(nombre1, nombre2);
// Console.WriteLine ($"Le nombre mini est {mini}");


//Exo 29 : Créez une méthode RepeatString qui prend en paramètres str de type string et n de type int et qui écrit dans la console n fois str

// void ReapeatString(string str, int n){
//     for( int i =0; i<= n; i++){
//    Console.WriteLine(str + "");
//     };

// }


// ReapeatString("poires",20);

//Exo 30 : Créez une méthode FindNthDigit qui prend un nombre et un index comme paramètres et écrit dans la console le N-ème chiffre du nombre 
//(en comptant de droite à gauche et en commençant par 0)

// void FindNthDigit(int nombre, int index){
//     try{
// string nombreStr = nombre + ""; //converti int to string
// int length = nombreStr.Length;
// int indice = length - index -1; // taille tableau - index - 1
// char result = nombreStr[indice]; //[] tableau
// Console.WriteLine(result);   
//     }
// catch  (SystemException){
// Console.WriteLine("Autodestruction activée"); //blague

// }  

// }
// FindNthDigit(12345,2);
//Exo 31 : Écrivez une méthode Letterize(int number), qui lit un entier et l'écrire dans la console en mots en français selon les conditions ci-dessous :
//Écrivez en toutes lettres les centaines, les dizaines et les unités (et l'éventuel moins) en français.
//Si le nombre est supérieur à 999 , vous devez écrire dans la console " trop ​​grand ".
//Si le nombre est inférieur à -999 , vous devez écrire dans la console " trop ​​petit ".
//Si le nombre est négatif , vous devez écrire dans la console " moins " avant.
//Si le numéro n'est pas composé de trois chiffres, vous ne devez pas l'écrire dans la console.

// Exo 32 : Écrire un algo qui demande à l’utilisateur de saisir un nombre entier, afficher un message d’erreur si ce qui est saisi n’est pas un nombre entier.
// try {


// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Good");
// }
// catch(SystemException){
// Console.WriteLine("Fatal error");

// }


// Exo 33 : Écrire un algo qui demande à l’utilisateur de saisir une note (nombre compris entre 0 et 20), si la saisie n’est pas valide l’indiquer à l’utilisateur

// try
// {
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number >= 0 && number <= 20)
//     {
//         Console.WriteLine("ok");
//     }
//     else
//     {
//         Console.WriteLine(" pas ok");
//     }
// }
// catch (System.Exception)
// {

//     Console.WriteLine("Fatal error");
// }



// Exo 34 : Écrire un algo qui demande à l’utilisateur de saisir une note (nombre compris entre 0 et 20), tant que la saisie n’est pas valide l’indiquer à l’utilisateur et lui demander de saisir à nouveau une note
// Console.WriteLine("Saisir note");
// try
// {
//     int note = Convert.ToInt32(Console.ReadLine());
//     if (note >= 0 && note <= 20)
//     {
//         Console.WriteLine($"{note}/20");
//     }
//     else
//     {
//         while (true)
//         {
//             Console.WriteLine("pas ok ! saississez un autre chiffre");
//            // note = Convert.ToInt32(Console.ReadLine());
//             if (note >= 0 && note <= 20)
//             {
//                 Console.WriteLine($"{note}/20");
//                 break;
//             }
//         }
//     }
// }
// catch (System.Exception)
// {

//     Console.WriteLine("Fatal error");
// }
// //autre solution
// // Exo 35 :

// // 1. Écrire un algo qui permet de saisir les notes d’un élève pour en calculer la moyenne (Attention au contrôle de saisie)
// // On commence par demander à l’utilisateur combien de notes il souhaite saisir.
// // Puis on calcule et on affiche la moyenne une fois toutes la saisie effectuée.

// Console.WriteLine("Combien de notes");
// string input = Console.ReadLine();
// int nbNotes;
// bool test = int.TryParse(input, out nbNotes);
// while(test || nbNotes < 1){
//     Console.WriteLine("Combien de notes");
//     input = Console.ReadLine();
//     test = int.TryParse(input, out nbNotes);

// }
// int nbInput = 0;
// double sommeDesNotes = 0;
// while(nbInput < nbNotes){
// Console.WriteLine("Saisir une note entre 0 et 20");
// input = Console.ReadLine();
// double noteSaisie;
// test = double.TryParse(input, out noteSaisie);
// if(test || noteSaisie<=0 ||noteSaisie>=20){
// continue;
// }
// nbInput++;
// sommeDesNotes += noteSaisie;
// }
// double moyenne = sommeDesNotes/nbInput;
// Console.WriteLine($"La moyenne des {nbInput} notes saisies est {moyenne}");
// 2. Compléter l’algorithme précédent en affichant la note maxi et la note mini.

//Console.WriteLine("Combien de notes ?");
// string input = Console.ReadLine();
// int nbNotes;
// bool test = int.TryParse(input, out nbNotes);
// while(!test || nbNotes < 1){
//     Console.WriteLine("Combien de notes ?");
//     input = Console.ReadLine();
//     test = int.TryParse(input, out nbNotes);
// }
// int nbInputs = 0;
// double sommeDesNotes = 0;
// double min = 20;
// double max = 0;
// while(nbInputs < nbNotes){
//     Console.WriteLine("Saisir une note entre 0 et 20 SVP.");
//     input = Console.ReadLine();
//     double noteSaisie;
//     test = double.TryParse(input, out noteSaisie);
//     if(!test || noteSaisie < 0 || noteSaisie > 20){
//         Console.WriteLine("Boulet !");
//         continue;
//     }
//     nbInputs++;
//     sommeDesNotes += noteSaisie;
//     if(noteSaisie < min){
//         min = noteSaisie;
//     }
//     if(noteSaisie > max){
//         max = noteSaisie;
//     }
// }
// double moy = sommeDesNotes / nbInputs;
// Console.WriteLine("La moyenne des " + nbInputs + " note(s) saisie(s) est : " + moy);
// Console.WriteLine("La note minimale est : " + min + " et la note maximale est : " + max);

// 3. Modifier l’algorithme précédent en supprimant l’étape “demander à l’utilisateur combien de notes il souhaite saisir” 
// La saisie des notes continuera tant que l’utilisateur ne saisit pas la lettre m pour exécuter le calcul de la moyenne, il faudra également afficher le nombre de notes saisies, le min et le max.

// int nbInputs = 0;
// double sommeDesNotes = 0;
// double min = 20;
// double max = 0;
// string input;
// double noteSaisie = 0;
// bool test = false;
// Console.WriteLine("Saisir vos notes entre 0 et 20 SVP. Tapez 'm' pour valider ...");
// while(true){
//     Console.WriteLine("Saisir une note entre 0 et 20 SVP.");
//     input = Console.ReadLine();
//     test = double.TryParse(input, out noteSaisie);
//     if(test && noteSaisie >= 0 && noteSaisie <= 20){
//         nbInputs++;
//         sommeDesNotes += noteSaisie;
//         if(noteSaisie < min){
//             min = noteSaisie;
//         }
//         if(noteSaisie > max){
//             max = noteSaisie;
//         }
//     }
//     if(input == "m"){
//         break;
//     }
// }
// double moy = sommeDesNotes / nbInputs;
// Console.WriteLine("La moyenne des " + nbInputs + " note(s) saisie(s) est : " + moy);
// Console.WriteLine("La note minimale est : " + min + " et la note maximale est : " + max);


// Exo 36
// Écrire une fonction qui initialise un tableau de n valeurs de type int
// int[] JeReussiMonTableau(int nb){
//     return new int[nb];
// }
// int[] tab = JeReussiMonTableau(8);

// Exo 37
// Écrire le code nécessaire pour déclarer et remplir un tableau contenant les six voyelles de l’alphabet latin


//string[] voyelles = new string[]{"a","e","i","o","u","y"};

// Exo 38
// Écrire une fonction qui permet de créer et remplir un tableau de 7 valeurs numériques entières passées en paramètres

// int[] seven(int i1, int i2, int i3, int i4, int i5, int i6, int i7){
//     int[]reponse =  new int[7] {i1, i2, i3, i4, i5, i6, i7};
//     return reponse;
// }




// Exo 39
// Ecrivez un algorithme calculant la somme des valeurs d’un tableau

double sumOfArray(double []tab){

    double result =0;

}
return result;

//Exo 40 : Écrire un algorithme plaçant dans un tableau int[] Tab; les valeurs 1, 2, . . . , 10

// Exo 41 : écrire une fonction permettant de savoir si un élément est présent dans un tableau de string
// ex :
// Le tableau contient A, E, I, O, U, Y
// Si l’élément recherché est A la fonction renvoie true
// Si l’élément recherché est B la fonction renvoie false

// Exo 42 : Écrire un programme demandant à l'utilisateur de saisir une valeur numérique positive n et affichant toutes les valeurs n, n − 1, . . . , 2, 1, 0
// (Avec les 3 boucles : while, do … while, for)

//Exo 43 : Écrivez une fonction calculant la somme des nombres entiers compris entre 1 et un entier passé en paramètre
// ex: 
// pour 5 la fonction renverra 15 (1+2+3+4+5)
// pour 6 la fonction renverra 21 (1+2+3+4+5+6)
// Exo 44 : Écrivez une fonction calculant la factorielle d’un nombre entier positif passé en paramètre