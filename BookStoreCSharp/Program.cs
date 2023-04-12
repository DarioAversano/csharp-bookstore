// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;

Console.Write("Inserisci il titolo del libro: ");
string Title = Console.ReadLine();

Console.Write("Inserisci il nome dell'autore: ");
string Autor = Console.ReadLine();

Console.Write("Inserisci ISBN del libro: ");
string ISBN = Console.ReadLine();

Console.Write("Inserisci il Numero di pagine: ");
string NumberPageString = Console.ReadLine();
int NumberPage = int.Parse(NumberPageString);

Console.Write("Inserisci il peso del libro: ");
string WeightBookString = Console.ReadLine();
int WeightBook = int.Parse(WeightBookString);

Console.Write("Inserisci la larghezza del libro: ");
string HeightBookString = Console.ReadLine();
int HeightBook = int.Parse(HeightBookString);
Console.Write("Inserisci altezza del libro: ");
string WidthBookString = Console.ReadLine();
int WidthBook = int.Parse(WidthBookString);
Console.Write("Inserisci profondita del libro: ");
string DepthBookString = Console.ReadLine();
int DepthBook = int.Parse(DepthBookString);

Console.Write("Inserisci la valutazione media degli utenti: ");
string RatingUserString = Console.ReadLine();
int RatingUser = int.Parse(RatingUserString);

Console.Write("Inserisci il numero di recensioni: ");
string ReviewsString = Console.ReadLine();
int Reviews = int.Parse(ReviewsString);

Console.Write("E disponibile la versione Kindle?");
string KindleString = Console.ReadLine();
bool Kindle = bool.Parse(KindleString);

Console.Write("La copertina flessibile è disponibile?");
string FlexibleString = Console.ReadLine();
bool Flexible = bool.Parse(FlexibleString);




Console.WriteLine($"-------- IL LIBRO DI OGGI: {Title} di {Autor} ------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine($"ISBN: {ISBN}");
Console.WriteLine($"Numero delle pagine: {NumberPage} pagine");
Console.WriteLine($"Peso del libro: {WeightBook} kg");
Console.WriteLine($"Dimensioni del libro: {HeightBook} cm x {WidthBook} cm x {DepthBook} cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine($"Numero di recensioni: {RatingUser} recensioni");
Console.WriteLine($"Valutazione media: {Reviews} stelline");
Console.WriteLine($"Kindle disponibile: {Kindle}");
Console.WriteLine($"Copertina flessibile disponibile: {Flexible} ---------------------------------------------------------------------------");

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

