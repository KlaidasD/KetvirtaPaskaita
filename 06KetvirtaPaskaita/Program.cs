/*Aprašymas
Sukurkite restorano užsakymų valdymo sistemą, kuri leis sekti klientų užsakymus ir užsakytų patiekalų būseną.
Sukurkite klasę Patiekalas su šiais laukais:
Id (int)
Pavadinimas (string)
Kaina (double)
Busena (string) – gali būti "Laukiama", "Ruošiama", "Paruošta"

Sukurkite klasę Uzsakymas su šiais laukais:
Id (int)
Klientas (string)
Patiekalai (List<Patiekalas>)
Sukurkite klasę Restoranas, kuri turės metodus:
PridetiPatiekalaIPateikalauSarasa(Patiekalas patiekalas): Prideda patiekalą į restorano meniu.
RodytiVisusPatiekalus(): Išspausdina visų patiekalų sąrašą.
PridetiUzsakyma(Uzsakymas uzsakymas): Prideda naują užsakymą.
KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena): Keičia patiekalo būseną užsakyme.
RodytiVisusUzsakymus(): Išspausdina visų užsakymų sąrašą.
RodytiUzsakyma(int uzsakymoId): Išspausdina konkretaus užsakymo informaciją.
Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus
(pvz., pridėti patiekalą į meniu, rodyti visus patiekalus, pridėti užsakymą, keisti patiekalo būseną, rodyti visus užsakymus, rodyti konkretaus užsakymo informaciją).*/