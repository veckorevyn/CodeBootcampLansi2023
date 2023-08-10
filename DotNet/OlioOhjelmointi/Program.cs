﻿using OlioOhjelmointi;
/*
string omaAutoMerkki = "Toyota";
string omaAutoVäri = "Musta";
int omaAutoNopeus = 0;

string naapurinAutoMerkki = "Nissan";
string naapurinAutoVäri = "keltainen";
int naapurinAutoNopeus = 50;
*/

/*
// perinteinen tapa
Auto oma = new Auto();
// uusi tapa
Auto oma = new();
*/

Auto oma = new();
oma.Merkki = "Toyota";
oma.Väri = "musta";
oma.Nopeus = 0;


oma.Sammuta();
oma.Jarruta();
oma.Jarruta();
oma.Jarruta();
Console.WriteLine(oma.Nopeus);





Auto naapurin = new();
naapurin.Merkki = "Nissan";
naapurin.Väri = "keltainen";
naapurin.Nopeus = 50;



/*
// ennen/ilman olio-ohjelmointia:
public void PiirräRuudulle(string merkki, string väri, int nopeus, ...)

// olio-ohjelminnissa:
public void PiirräRuudulle(Auto auto)
*/