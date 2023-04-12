// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;



// BOOOOOOONUUUUUUUSSSSS

string Title = "Clean Code";

string Autor = "Robert C. Martin";

string ISBN = "9780132350884";

int NumberPage = 431;

float WeightBook = 800;

float HeightBook = 17.78f;

float WidthBook = 2.79f;

float DepthBook = 23.37f;

int Reviews = 5415;

float RatingUser = 4.7f;

bool Kindle = true;

bool Flexible = true;


Console.WriteLine("-------- IL LIBRO DI OGGI: " + Title + " di " + Autor + "------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + NumberPage + " pagine");
Console.WriteLine("Peso del libro: " + WeightBook + " g");
Console.WriteLine("Dimensioni del libro: " + HeightBook + " cm x " + WidthBook + " cm x " + DepthBook + " cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + Reviews + " recensioni");
Console.WriteLine("Valutazione media: " + RatingUser + " stelline");
Console.WriteLine("Kindle disponibile: " + Kindle);
Console.WriteLine("Copertina flessibile disponibile: " + Flexible + "---------------------------------------------------------------------------");

