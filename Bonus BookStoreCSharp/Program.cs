// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;



// BOOOOOOONUUUUUUUSSSSS

string Title = "Clean Code";

string Autor = "Robert C. Martin";

string ISBN = "9780132350884";

string NumberPageString = "431";
int NumberPage = int.Parse(NumberPageString);

string WeightBookString = "800";
float WeightBook = float.Parse(WeightBookString);

string HeightBookString = "17.78";
float HeightBook = float.Parse(HeightBookString);

string WidthBookString = "2.79";
float WidthBook = float.Parse(WidthBookString);

string DepthBookString = "23.37";
float DepthBook = float.Parse(DepthBookString);

string RatingUserString = "4.7";
float RatingUser = float.Parse(RatingUserString);

string ReviewsString = "5415";
int Reviews = int.Parse(ReviewsString);

string KindleString = "True";
bool Kindle = bool.Parse(KindleString);

string FlexibleString = "True";
bool Flexible = bool.Parse(FlexibleString);


Console.WriteLine("-------- IL LIBRO DI OGGI: " + Title + " di " + Autor + "------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + NumberPage + " pagine");
Console.WriteLine("Peso del libro: " + WeightBook + " kg");
Console.WriteLine("Dimensioni del libro: " + HeightBook + " cm x " + WidthBook + " cm x " + DepthBook + " cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + RatingUser + " recensioni");
Console.WriteLine("Valutazione media: " + Reviews + " stelline");
Console.WriteLine("Kindle disponibile: " + Kindle);
Console.WriteLine("Copertina flessibile disponibile: " + Flexible + "---------------------------------------------------------------------------");

