
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


//12



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
// bool test = int.TryParse(input, out nbNotes); // stock l'information pour savoir si ça s'est bien passé
// while (test || nbNotes < 1)
// {
//     Console.WriteLine("Combien de notes");
//     input = Console.ReadLine();
//     test = int.TryParse(input, out nbNotes);

// }
// int nbInput = 0;
// double sommeDesNotes = 0;
// while (nbInput < nbNotes)
// {
//     Console.WriteLine("Saisir une note entre 0 et 20");
//     input = Console.ReadLine();
//     double noteSaisie;
//     test = double.TryParse(input, out noteSaisie);
//     if (test || noteSaisie <= 0 || noteSaisie >= 20)
//     {
//         continue;
//     }
//     nbInput++;
//     sommeDesNotes += noteSaisie;
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

// double sumOfArray(double []tab){
//     double sum =0;

// for(int i=0;i<tab.Length;i++){

// sum += tab[i];
// }
// return sum;
// }
// int SumOfIntegerArray(int[]tab){
// int somme =0;

// for(int i =0; i<tab.Length;i++){
// int elementCourant = tab[i];
// somme += elementCourant;
// }




// return somme;

// }
// int[]tableauTest = new int[]{2,3,4,5,2};
// int result = SumOfIntegerArray(tableauTest);

// Console.WriteLine(result);
//Exo 40 : Écrire un algorithme plaçant dans un tableau int[] Tab; les valeurs 1, 2, . . . , 10

//int[] tab = new int[]{1,2,3,4,5,6,7,8,9,10};






// Exo 41 : écrire une fonction permettant de savoir si un élément est présent dans un tableau de string
// ex :
// Le tableau contient A, E, I, O, U, Y
// Si l’élément recherché est A la fonction renvoie true
// Si l’élément recherché est B la fonction renvoie false

// bool findElmement(string[]tab, string search){
//     bool result= false;
// for (int i = 0; i < tab.Length; i++)
// {
//     string elementCourant = tab[i];
//     if(search == elementCourant){
//         result= true;
//         break;
//     }
// }
//     return result;


// }
//Alternative

// bool findElmement(string[]tab, string search){
// for (int i = 0; i < tab.Length; i++)
// {
//     string elementCourant = tab[i];
//     if(elementCourant == search){
//         return true;

//     }
// }
//     return false;


// }




// Exo 42 : Écrire un programme demandant à l'utilisateur de saisir une valeur numérique positive n et affichant toutes les valeurs n, n − 1, . . . , 2, 1, 0
// (Avec les 3 boucles : while, do … while, for)

// Console.Writeline("Saisir un entier positif");
// int nb =0;
// string input =Console.Readline();
// bool result = uint.TryParse(input, out nb); //"u" est forcement positif
// while(!result){
//     Console.Writeline("Saisir un entier positif");
//     input =Console.Readline();
// result = uint.TryParse(input, out nb);
// }
// //Version While
// while(n > 0){
//     Console.WriteLine(n--);
//     //n--;
// }
// Console.WriteLine(n);

// //Version Do While

// do{

//     Console.WriteLine(n--);
// }
// while(n>0);
// Console.WriteLine(n);

// // for 1

// for (int i = 0; i >=0 ;i++){
//     Console.WriteLine(n-i);
// }

// // for 2

// for  (uInt i = n; 1>0;i--){

//     Console.WriteLine(i);
//     if(i==0){
//         break;
//     }
// }
//Exo 43 : Écrivez une fonction calculant la somme des nombres entiers compris entre 1 et un entier passé en paramètre
// ex: 
// pour 5 la fonction renverra 15 (1+2+3+4+5)
// pour 6 la fonction renverra 21 (1+2+3+4+5+6)
// Console.WriteLine("Nombre ?");
// int CalcSumInteger(int n){
//    int result =0;

// for( int i=1; i <= n;i++){
//     result+=i;
// }
// //While
// // int cpt = 0;
// // while(cpt <= maxi);
// // result += maxi;
// // cpt++;
//    return result;

// }
// int test1 =CalcSumInteger(5);
// int test2 = CalcSumInteger(6);



// Exo 44 : Écrivez une fonction calculant la factorielle d’un nombre entier positif passé en paramètre


// int CalcFactorielle(int n){
//    int result =1;

// for( int i=1; i <= n;i++){
//     result*=i;
// }

//    return result;

// }
// int test3 =CalcFactorielle(5);
// int test4 = CalcFactorielle(6);



//Exo 45 : essayer de refaire l'exo 35 en utilisant les tableaux (pour la partie 1 et 2 de l'exercice)

//int[] notes = new int[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};


// Exo 46 : Écrivez un algorithme constituant un nouveau tableau à partir de deux tableaux de même longueur préalablement définis. Le nouveau tableau contiendra la somme des éléments des deux tableaux de départ.
// ex : 
// tableau1 contient 1, 4, 17, 34, 16
// tableau2 contient 8,7,3,12,6
// nouveauTableau contiendra 9,11,20,46,22
// int[] tab1 = new int[]{1,4,17,34,16};
// int[] tab2 = new int[]{8,7,3,12,6};

// int[] sumValues(int[]tab1,int[]tab2){
// int[] result = new int[tab1.Length];
// for (int i = 0; i < result.Length; i++)
// {
//    result[i] = tab1[i] + tab2[i];
// }
// return result;

// }
// sumValues(tab1,tab2);


//bool test =true;









// Exo 47 : 
// Partie 1 -> Écrivez un algorithme permettant à l’utilisateur de saisir un nombre quelconque de valeurs entières, qui devront être stockées dans un tableau. L’utilisateur doit donc commencer par entrer le nombre de valeurs qu’il compte saisir. Il effectuera ensuite cette saisie. Enfin, une fois la saisie terminée, le programme affichera le nombre de valeurs négatives et le nombre de valeurs positives.
// Partie 2 -> Complétez l’algorithme précédent en indiquant également le nombre de valeurs paires et impaires
// Partie 3 -> Modifier l’algorithme précédent pour n’écrire dans la console que les valeurs paires et positives

// Console.WriteLine("Combien de valeurs dans ?");
// uint nbVal;
// string saisie = Console.ReadLine();
// bool saisieOk = uint.TryParse(saisie, out nbVal);
// while (!saisieOk)
// {
//     Console.WriteLine("Combiende valeurs? Merci de choisir un nombre");
//     saisie = Console.ReadLine();
//     saisieOk = uint.TryParse(saisie, out nbVal);
// }
// int[] tableauDeValeurs = new int[nbVal];
// for (int i = 0; i < tableauDeValeurs.Length; i++)
// {
//     Console.WriteLine($"Saisir la valeur{i + 1}");
//     int currentNumber;
//     saisie = Console.ReadLine();
//     saisieOk = int.TryParse(saisie, out currentNumber);
//     while (!saisieOk)
//     {
//         Console.WriteLine($"Saisir la valeur{i + 1}, un nb entier");
//         saisie = Console.ReadLine();
//         saisieOk = uint.TryParse(saisie, out nbVal);
//     }
//     tableauDeValeurs[i] = currentNumber;
// }
// int nbValeursPositives = 0;
// int nbValeursPaires = 0;
// int nbValeursImpaires = 0;
// for (int i = 0; i < tableauDeValeurs.Length; i++)
// {
//     if (tableauDeValeurs[i] >= 0)
//     {
//         nbValeursPositives++;

//     }

//     if (tableauDeValeurs[i] % 2 == 0)
//     {

//         nbValeursPaires++;
//     }
//     else
//     {
//         nbValeursImpaires++;
//     }

//     if (tableauDeValeurs[i] >= 0 && tableauDeValeurs[i] % 2 == 0){
//        Console.WriteLine("Le nombre " +tableauDeValeurs[i]+ "est pair et positif");

//     }

// }
// int nbValeursNegatives = tableauDeValeurs.Length - nbValeursPositives;

// Console.WriteLine("Le tableau comporte " + nbValeursPositives + " valeurs positives et " + nbValeursNegatives + " valeurs négatives");
// Console.WriteLine("Le tableau comporte " + nbValeursPaires + " valeurs paires et " + nbValeursImpaires + " valeurs impaires");
// // Console.WriteLine($"Le nombre de valeurs positives est {nbValeursPositives} et le nombre de valeurs positives est{nbValeursNegatives}");




// Exo 48 : écrire une fonction permettant de renvoyer la moyenne des éléments d’un tableau d’entiers passé en paramètres (sans utiliser de fonction prédéfinie de C# )
// double CalculMoyTab(int[]tableauEntiers){
//    double result =0;


//     for (int i = 0; i < tableauEntiers.Length; i++)
//     {
//         result += tableauEntiers[i]/tableauEntiers.Length;
//     }



//    return result;
// }




// Exo 49 : écrire une fonction permettant de renvoyer la valeur maximale des éléments d’un tableau d’entiers passé en paramètres  (sans utiliser de fonction prédéfinie de C# )

// int ValMaxTab(int[]tab){

// int max =int.MinValue;

// for (int i = 0; i < tab.Length; i++)
// {
//     if(tab[i]>max){

//         max= tab[i];
//         }
//         return max;
// }
// }


// Exo 50 : écrire une fonction permettant de renvoyer la valeur minimale des éléments d’un tableau d’entiers passé en paramètres (sans utiliser de fonction prédéfinie de C# )

// double ValMinTab(int[]tab){

// double min= int.MaxValue;

// for (int i = 0; i < tab.Length; i++)
// {
//     if(tab[i]<min){

//         min= tab[i];
//         }
//         return min;
// }
// }



// Exo 51 : écrire un algorithme permettant d’afficher dans la console le min, le max, la moyenne et le nombre d’élément d’un tableau (utiliser les fonctions précédemment créées)

// void writeResultInTheConsole(int[]tableauEntiers){
// Console.WriteLine($"Valeur min : {valMinTab(tab)});
// Console.WriteLine($"Valeur max : {valMaxTab(tab)});
// Console.WriteLine($"Valeur moy : {CalculMoyTab(tableauEntiers)});
// Console.WriteLine("Nb elts : " + tableauEntiers.Length);
// }


// Exo 52 : écrire un algorithme qui écrit lettre par lettre le contenu d’une variable de type string

// void Lettre(string str){

//     for (int i = 0; i < str.Length; i++)
//     {
//         Console.WriteLine(str[i]);
//     }
// }
// Lettre("bonjour");

// Exo 53 : écrire une fonction qui compte le nombre de voyelles dans un mot

// int CounterVoyelles(string mot){
// int voyelles=0;
//   for(int i = 0; i < mot.Length; i++) {
//            char c = mot[i]; 
//            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c =='y') { 
//                 voyelles++;
//            }
//   }

// return voyelles
// ;

// }

// Console.WriteLine($"Nbre voyelles = {CounterVoyelles("charrette")}");

// // Exo 54 : écrire une fonction qui compte le nombre de consonnes dans un mot

// void CounterConsonnes(string mot){
// int consonnes=0;
//   for(int i = 0; i < mot.Length; i++) {
//            char c = mot[i]; 
//            if(!(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c =='y')) { 
//                 consonnes++;
//            }
//   }
// return consonnes;


// }

// Console.WriteLine($"Nbre consonnes = {CounterConsonnes("charrette")}");




// Exo 55 : écrire une fonction qui compte le nombre de mots dans une phrase

// int motsPhrases(string phrase){
// int mots=0;
//   for(int i = 0; i < phrase.Length; i++) {
//            char c = phrase[i]; 
//            if(c == ' ' || c == ',' || c == '.' || c == '!' || c == '?' || c ==':' || c ==';') { 
//                 mots++;
//            }
//   }
// return mots;


// }

// Console.WriteLine($"Nbre mots = {motsPhrases("La charrette est avant les boeufs.Je Pense ou pas!Qu'est ce que j'en sais.")}");



// Exo 56 : écrire une fonction pour remplacer les voyelles accentuées dans un texte
// ex : “ à é è û ï ” devient “ a e e u i ”

// string ReplaceAccent(string str)
// {
//     string replace = "";
//     foreach (char item in str)
//     {
//         switch (item)
//         {
//             case 'à':
//                // replace += 'a';
//                // break;

//             case 'ä':
//                 //replace += 'a';
//                // break;

//             case 'â':
//                 replace += 'a';
//                 break;

//             case 'é':
//                 replace += 'e';
//                 break;

//             case 'è':
//                 replace += 'e';
//                 break;

//             case 'ë':
//                 replace += 'e';
//                 break;

//             case 'ê':
//                 replace += 'e';
//                 break;

//             case 'ö':
//                 replace += 'o';
//                 break;

//             case 'ô':
//                 replace += 'o';
//                 break;

//             case 'ü':
//                 replace += 'u';
//                 break;

//                 case 'î':
//                 replace += 'i';
//                 break;

//                 case 'ï':
//                 replace += 'i';
//                 break;

//             default:
//                 replace += item;
//                 break;
//         }
//     }
//     return replace;
// }
// Console.WriteLine(ReplaceAccent("Nöüs sômmés pärtïs très tàrd"));

// Exo 57 : écrire un programme qui génère un tirage de l’Euromillions aléatoirement
// (5 numéros compris entre 1 et 50 et tous différents + 2 étoiles comprises entre 1 et 12 différentes l’une de l’autre)

// Random random = new Random();
// List<int> boulesNum = new List<int>();
// List<int> boulesEto = new List<int>();

// for (int i = 1; i <=49; i++)
// {
//     boulesNum.Add(i);
// }

// for (int i = 1; i <=12; i++)
// {
//     boulesEto.Add(i);
// }

// string numbers= "";
// string stars= "";

// for (int i = 0; i < 5; i++)
// {
//     int index= random.Next(0, boulesNum.Count);
//     numbers +=index + " ";
//    // Console.WriteLine($"Numero: {boulesNum[index]}");
// boulesNum.Remove(boulesNum[index]);

// }

// Console.WriteLine("Numéros: ");
// Console.WriteLine("");
// Console.WriteLine(numbers);
// Console.WriteLine("");

// for (int i = 0; i < 2; i++)
// {
//     int index= random.Next(0, boulesEto.Count);
//     stars +=index + " ";
//    // Console.WriteLine($"Numero: {boulesNum[index]}");
// boulesEto.Remove(boulesEto[index]);
// }

// Console.WriteLine("Etoiles: ");
// Console.WriteLine("");
// Console.WriteLine(stars);
// Console.WriteLine("");



//Exo 58 : Ecrire un algorithme qui demande un nombre de départ, et qui ensuite écrit la table de multiplication de ce nombre dans la console, présentée comme suit (cas où l'utilisateur entre le nombre 5) 
// 5x1 = 5
// 5x2 = 10
// 5x3 = 15
// …
// 5x10 = 50

// Console.WriteLine("Choississez un nombre ");
// int nbsaisi =Convert.ToInt32(Console.ReadLine());
// int result =0;
// List<int> multi = new List<int>{0,1,2,3,4,5,6,7,8,9,10};

// for (int i = 0; i < 11; i++)
// {
//     result= nbsaisi*index[i];
// }

// Exo 59 : écrire une fonction qui calcule (et retourne) le nombre de jours entre 2 dates
// Exo 60 : écrire une fonction qui renvoie true si le mot qui lui est passé en paramètre est un Palindrome (false sinon)
// Exo 61 : écrire un algorithme qui réalise le tirage au sort du jeux “des chiffres et des lettres”
// Demander à l’utilisateur de choisir entre consonne et voyelle et lui afficher la lettre tirée au sort. Il faut faire un tirage de 9 lettres au total.

// string[] tableauConsonnes = new string[] {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"};
// string[] tableauVoyelles = new string[]{"a","e","y","u","i","o"}; 
// int counter = 0;
// while(counter <= 9){
// Console.WriteLine("Choisissez entre une consonne ou une voyelle");
// string choix = Console.ReadLine();
// if(choix == "c"){
//     string consonneAffichee = renvoieAleatoireLettre(tableauConsonnes);
//     Console.WriteLine(consonneAffichee);
// }else{
//     string voyelleAffichee = renvoieAleatoireLettre(tableauVoyelles);
//     Console.WriteLine(voyelleAffichee);
// }
// counter++;
// }


// string renvoieAleatoireLettre(string[] tab){
//     string result = "";
//     Random aleatoire = new Random();
//     int indice = aleatoire.Next(tab.Length);
//     result = tab[indice];

//     return result;
// }


// Exo 62 : Le Juste Prix
// Choisir un prix (entier) aléatoirement compris entre 0 et 1000€.
// L’utilisateur doit deviner le prix.
// Si le prix donné par l’utilisateur est trop bas, on lui écrit “+ cher”
// Si le prix donné par l’utilisateur est trop haut, on lui écrit “- cher”
// Quand il trouve le prix, on lui indique qu’il a gagné et on lui donne le nombre de tours qui lui a fallu pour trouver ce prix

// Random random = new Random();
// List<int> prix = new List<int> { };
// int prixATrouver = 0;


// for (int i = 0; i < 1000; i++)
// {
//     prix.Add(i);

// }

// for (int i = 0; i < 1; i++)
// {
//     int index = random.Next(0, prix.Count);
//     // Console.WriteLine(prix[index]);
//     prixATrouver = prix[index];
// }

// int nbSaisi = 0;
// int compt =1;

//  Console.WriteLine("Saississez un nombre entre 0 et 1000");
// Console.ReadLine();
// while(nbSaisi !=prixATrouver){
   
// if ( nbSaisi < prixATrouver ){
//     Console.WriteLine("plus cher");
//     Console.WriteLine("Saississez un nombre entre 0 et 1000");
//     compt++;
// }

// else if ( nbSaisi > prixATrouver ){
//     Console.WriteLine("moins cher");
//     Console.WriteLine("Saississez un nombre entre 0 et 1000");
//    compt++;
// }

//  nbSaisi = Convert.ToInt32(Console.ReadLine());

// }
// Console.WriteLine($"Le nombre de tours est {compt}");


// Exo 63 : Le Juste Prix inversé
// Inversez les rôles avec l’ordinateur
// Cette fois vous fixez un prix (le saisir en début de partie) et l’ordinateur doit trouver le prix
// A chaque réponse de l’ordinateur, vous devez lui dire si c’est + ou - (en saisissant + ou -)
// Si l’ordinateur trouve, un message s’affiche automatiquement avec le nombre de tour qu’il lui aura fallu pour trouver le prix

// Console.WriteLine("Fixer un prix compris entre 1 et 1000");
// int price; int.TryParse(Console.ReadLine(), out price);
// while (price < 1 || price > 1000)
// {
//     Console.WriteLine("Fixer un prix compris entre 1 et 1000");
//     int.TryParse(Console.ReadLine(), out price);
// }
// int counter = 1;
// int min = 1;
// int max = 1000;
// int mid = (min + max) / 2;
// Thread.Sleep(2000);
// Console.WriteLine("proposition ordi " + mid);
// while (mid != price)
// {
//     if (mid < price)
//     {
//         Console.WriteLine("plus cher");
//         min = mid;
//     }
//     if (mid > price)
//     {
//         Console.WriteLine("moins cher");
//         max = mid;
//     }
//     mid = (min + max) / 2;
//     counter++;
//     Thread.Sleep(1000);
//     Console.WriteLine("");
//     Console.WriteLine("proposition ordi " + mid);
// }
// Console.WriteLine("l'ordi a trouver en " + counter + " tours");





// Exo 64 : écrire un algorithme qui tri par ordre croissant un tableau d’entiers passé en paramètre (sans utiliser les méthode déjà existantes en C#) - Faire une recherche sur les tris en algorithmie …






//PROJET ALGO (avec david et thomas)

// // sélectionner un produit 
// //     liste de produits{}
// // CHOISIR dans produits
// List<string> produits = new List<string>() { "Chips", "Barre chocolatée", "eau minérale", "soda", "bonbons" };
// List<double> indexPrix = new List<double>() { 1.5, 2.00, 1.45, 1.75, 1.95 };
// // insérer la monnaie
// // controler les pièces données
// // liste pièces_acceptées{}
// // rendre la monnaie
// // SI fond_inssuffisant retour Monnaie

// // --- Corps du programme

// for (int i = 0; i < produits.Count; i++)
// {
//     Console.WriteLine($"{i+1} > {produits[i]}, {indexPrix[i]} €");
// }
// // monnaie choix : affichage

// Console.WriteLine();
// Console.WriteLine("Insérer la monnaie : ");
// Console.WriteLine($"Monnaie acceptée : 5- 0,05 euros ; 10- 0,10 euros ; 20- 0,20 euros ; 50- 0,50 euros ; 100- 1 euros; 200- 2 euros");

// // sélection monnaie
// double monnaie = 0;

// do
// {
//     // int choix = int.Parse(Console.ReadLine());

//     switch (Console.ReadLine())
//     {
//         case "5":
//             monnaie += .05;

//             break;
//         case "10":
//             monnaie += .1;

//             break;
//         case "20":
//             monnaie += .2;

//             break;
//         case "50":
//             monnaie += .5;

//             break;
//         case "100":
//             monnaie += 1;

//             break;
//         case "200":
//             monnaie += 2;

//             break;
//         default:
//         Console.WriteLine("erreur monnaie");
//         Console.WriteLine("Choississez une autre piece");
//             break;


//     }

//     Console.WriteLine($"Le distributeur a {monnaie} euros de monnaie"); 

// } while (monnaie >=0 && monnaie < 2);




// Console.WriteLine("");
// // monnaie choix : affichage

// // selection produit
// Console.WriteLine("Choississez un produit");
// double prix=0;
// double retour=0;

//   do{
//     //   int choix2 = int.Parse(Console.ReadLine());
//     switch (Console.ReadLine())
//     {
//         case "A1": //CHIPS
//             prix = 1.5;
//             break;
//         case "A2": //BARRE CHOCO
//             prix= 2;
//             break;
//         case "B1": //EAU
//             prix = 1.45;
//             break;
//         case "B2": //SODA
//             prix = 1.75;
//             break;
//         case "A3": //BONBONS
//             prix = 1.95;
//             break;
//         default:
//         Console.WriteLine("Ce produit n'existe pas");
//         Console.WriteLine("Choississez un autre produit");
//             break;
//     }
//         retour = (monnaie-prix);
//     Console.WriteLine($"Le distributeur rend {retour} euros");
// } while (true);


////////////////////////////////PENDU\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
// Créer un tableau de 10 mots d’au moins 7 lettres (pas d’accents ni de traits d’union)
// Tirer au sort un mot
// Afficher le mot caché à l’utilisateur (ex : pour le mot algorithme, on affiche - - - - - - - - - -) 
// Demander au joueur de saisir une lettre
// Si la lettre est présente dans le mot, remplacer les tirets correspondants par la lettre
// Sinon lui indiquer combien il lui reste de tours pour trouver le mot
// Recommencer jusqu'à ce que je joueur ait trouvé toutes les lettres du mots ou qu’il ait atteint le nombre maximal de tours
// Si le nombre de tour maximal est atteint avant que toutes les lettres du mot ne soient révélées, c’est perdu, sinon c’est gagné !
// Le nombre de tours est égale au double du nombre de lettres différentes présentes dans le mot (ex : pour le mot internet, il y a 5 lettres différentes, le nombre de tours maxi pour trouver le mot sera 10)

//Créer un tableau de 10 mots d’au moins 7 lettres (pas d’accents ni de traits d’union)
// string[] words =
// {
//     "INTERNET",
//     "ALGORITHME",
//     "APPLICATION",
//     "PROTOCOLE",
//     "JAVASCRIPT",
//     "WORLD WIDE WEB",
//     "ORDINATEUR",
//     "CLAVIER",
//     "INFORMATIQUE",
//     "PROGRAMME"
// };

// //Tirer au sort un mot
// int random = new Random().Next(0, 9);
// string wordToFind = words[random];

// //Le nombre de tours est égale au double du nombre de lettres différentes présentes dans le mot
// //(ex : pour le mot internet, il y a 5 lettres différentes, le nombre de tours maxi pour trouver le mot sera 10)
// Dictionary<char, int> alphabet = new Dictionary<char, int>();
// for (int i = 65; i <= 90; i++)
// {
//     alphabet.Add((char)i, 0);
// }

// foreach (char c in wordToFind)
// {
//     if (alphabet.ContainsKey(c))
//     {
//         alphabet[c]++;
//     }
// }
// int nbTour = alphabet.Count(item => item.Value > 0) * 2;

// Console.WriteLine($"Vous avez le droit à {nbTour} erreurs pour trouver le mot mystère");
// Thread.Sleep(500);

// //Afficher le mot caché à l’utilisateur (ex : pour le mot algorithme, on affiche _ _ _ _ _ _ _ _ _ _ )
// char[] displayedWord = new char[wordToFind.Length];
// for (int i = 0; i < wordToFind.Length; i++)
// {
//     char c = wordToFind[i];
//     if (c != ' ')
//     {
//         displayedWord[i] = '_';
//     }
//     else
//     {
//         displayedWord[i] = ' ';
//     }
// }
// Console.WriteLine(String.Join(' ', displayedWord));

// //Recommencer jusqu'à ce que je joueur ait trouvé toutes les lettres du mots ou qu’il ait atteint le nombre maximal de tours
// int tourCounter = 0;
// while (nbTour - tourCounter > 0)
// {
//     Thread.Sleep(500);//Demander au joueur de saisir une lettre
//     Console.WriteLine("Saisir une lettre");
//     string inputLetter = Console.ReadLine().Substring(0, 1);

//     bool foundLetter = false;
//     //Si la lettre est présente dans le mot, remplacer les tirets correspondants par la lettre
//     for (int i = 0; i < wordToFind.Length; i++)
//     {
//         char c = wordToFind[i];
//         if (c.ToString() == inputLetter.ToUpper())
//         {
//             displayedWord[i] = c;
//             foundLetter = true;
//         }
//     }
//     Thread.Sleep(1000);
//     if (foundLetter)
//     {
//         Console.WriteLine("Bien joué !");
//     }
//     else
//     {
//         //Sinon lui indiquer combien il lui reste de tours pour trouver le mot
//         Console.WriteLine("Pas de chance !");
//         Console.WriteLine($"Il vous reste {nbTour - ++tourCounter} chance(s) pour trouver le mot mystère ... ");
//     }

//     Console.WriteLine(String.Join(' ', displayedWord));

//     //Recommencer jusqu'à ce que je joueur ait trouvé toutes les lettres du mots ou qu’il ait atteint le nombre maximal de tours
//     if (displayedWord.Count(c => c == '_') == 0)
//     {
//         Console.WriteLine("Bravo ! Vous avez gagné !");
//         break;//C'est gagné
//     }


//     //bool stop = true;
// }
// if (nbTour - tourCounter == 0)//C'est perdu
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("Perdu ! Pendu !");
//     Console.WriteLine("Le mot mystère était : " + wordToFind);
// }









// Random random = new Random();
//string[] poker = new string[] { "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "Jh", "Qh", "Kh", "Ah", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "Jd", "Qd", "Kd", "Ad", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "Js", "Qs", "Ks", "As", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "Jc", "Qc", "Kc", "Ac" };

// int cards = random.Next(poker.Length);
// int cards2 = random.Next(poker.Length);
// int cards3 = random.Next(poker.Length);
// int cards4 = random.Next(poker.Length);
// int cards5 = random.Next(poker.Length);
// int cards6 = random.Next(poker.Length);
// int cards7 = random.Next(poker.Length);

// List<string> joueur = new List<string>();
// joueur.Add("joueur1");
// joueur.Add("joueur2");
// joueur.Add("joueur3");
// joueur.Add("joueur4");

// Console.WriteLine("Ajouter un joueur");
// Console.ReadLine(joueur);

// Console.WriteLine($"Le joueur 1 a {poker[cards]} et {poker[cards2]}");

// Console.WriteLine($"Le  board: {poker[cards3]}, {poker[cards4]}, {poker[cards5]}, {poker[cards6]}, {poker[cards7]},");




Random random = new Random();
List<string> cards = new List<string> { "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "Jh", "Qh", "Kh", "Ah", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "Jd", "Qd", "Kd", "Ad", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "Js", "Qs", "Ks", "As", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "Jc", "Qc", "Kc", "Ac" };
List<string> players = new List<string> {"P1","P2","P3","P4"};


string ajouter = "o";
string player="";
 while (ajouter == "o"){
 
  
Console.WriteLine("Tapez en suivant p1,p2,p3,p4");
player=Console.ReadLine();
  

    switch (player)
    {   

        case "p1": 
        

            for (int i = 0; i < 2; i++)
{
     int index = random.Next(0, cards.Count);

    Console.Write(cards[index] + " ");
    cards.Remove(cards[index]);
    Thread.Sleep(1000);
}   
players.Remove("p1");
Console.WriteLine("");
Console.WriteLine("Ajouter un nouveau joueur (o/n)"); 
ajouter = Console.ReadLine();
            break;

        case "p2": 
            ajouter= "p2";
             for (int i = 0; i < 2; i++)
{
     int index = random.Next(0, cards.Count);

    Console.Write(cards[index] + " ");
    cards.Remove(cards[index]);
    Thread.Sleep(1000);
}   
players.Remove("p2");
            Console.WriteLine("");
Console.WriteLine("Ajouter un nouveau joueur (o/n)"); 
ajouter = Console.ReadLine();
            break;
            
        case "p3":
            ajouter= "p3";
                         for (int i = 0; i < 2; i++)
{
     int index = random.Next(0, cards.Count);

    Console.Write(cards[index] + " ");
    cards.Remove(cards[index]);
    Thread.Sleep(1000);
}   
players.Remove("p3");
            Console.WriteLine("");
Console.WriteLine("Ajouter un nouveau joueur (o/n)"); 
ajouter = Console.ReadLine();
            break;

        case "p4": 
            ajouter= "p4";
                         for (int i = 0; i < 2; i++)
{
     int index = random.Next(0, cards.Count);

    Console.Write(cards[index] + " ");
    cards.Remove(cards[index]);
    Thread.Sleep(1000);
}   
players.Remove("p4");
            break;
       
        default:
        Console.WriteLine("Trop de joueur");
        break;
    }
     
}




Console.WriteLine("board:");

for (int i =0; i< 5; i++)

{
int index = random.Next(0, cards.Count);
    Console.Write(cards[index] + " ");
    cards.Remove(cards[index]);
    Thread.Sleep(2000);
}








