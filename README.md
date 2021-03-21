# Grupa2-HNEmatcher
# <p align="center"> love algorithm
  </p>

![logo](https://i.imgur.com/t21jclF.png)

## Tim:
* [Imamović Elvir](https://github.com/eimamovic2)
* [Pamuk Hena](https://github.com/hpamuk)
* [Skelić Nejla](https://github.com/nskelic)

## Opis teme: 
Tema ovog projekta je servis za spajanje samaca isključivo sa
njihovim idealnim partnerima, srodnim dušama po uzoru na Love Solutions
iz epizode Matchmaker sezone 1 serije "How I met your mother".
Aplikacija je namijenjena punoljetnim samcima koji traže ozbiljnog partnera za
potencijalni brak, a ne zabavu što je razlikuje od svih ostalih dating site-ova. 
Postojeće aplikacije su neobavezne, neozbiljne i ne obećavaju sigurnost korisnicima.
Naša aplikacija nudi pouzdanost i stvarnu kompaktibilnost i ništa manje od 
toga. Umorni ste od beznačajnog dopisivanja sa neprovjerenim korisnicima koji
troše vaše dragocjeno vrijeme? Spremni ste za pravu stvar? Dopustite nam da 
mi obavimo selekciju za Vas i spasimo Vas neprijatnosti i stalnih promašaja.
Prijavite se!

## Akteri: 
* Neregistrovani korisnik
* Registrovani korisnik
* VIP korisnik
* Administrator

## Funkcionalnosti:
#### Neregistrovani korisnik:
* Pristup statistici
* Čitanje feedback-a/bloga
* Mogućnost kontaktiranja administratora
* Registracija u vidu popunjavanja obrasca za prijavu (vremensko ograničenje za potvrdu prijave putem maila/telefona?)

#### Registrovani korisnik:
* Sve funkcionalnosti neregistrovanog korisnika
* Mogućnost plaćanja za pristup chat-u sa odabranim partnerom najveće kompaktibilnosti
* Pisanje feedback-a/bloga
* Ažuriranje računa
* Brisanje računa
* Ocjenjivanje servisa (alert prozor)
* Učestvovanje u nagradnoj igri

#### VIP korisnik:
* Sve funkcionalnosti registrovanog korisnika
* Mogućnost pisanja dodatnih zahtjeva administratoru prilikom popunjavanja obrasca
* Privilegija uvida u sve potencijalne korisnike sa određenim nivoom kompaktibilnosti i odabir najkompetentnijeg te pristup chat-u s istim

#### Administrator:
* Pregled prijavljenih korisnika
* Brisanje korisničkih računa po potrebi
* Ažuriranje procenta kompaktibilnosti na osnovu dodatnih zahtjeva
* Odobravanje pronađenih poklapanja
* Odgovaranje na mailove

## Vanjski uređaj:
- Mapa za označavanje prihvatljivog radijusa prilikom popunjavanja obrasca za prijavu
- Kartično plaćanje

## Nefunkcionalni zahtjevi:
* Korisnik mora biti punoljetan
* Obavezno odgovaranje na sva pitanja obrasca za prijavu

## Detaljna pojašnjenja: 
**Statistika** je javno vidljiva svima i prikazuje uspješnost servisa preko prosječnog vremena za pronalazak partnera i procenta parova spojenih našim algoritmom koji su stupili u brak u roku od godinu dana od spajanja. Ovo će biti obavljeno uz pomoć korisničkog ažuriranja bračnog statusa na profilu.

**Feedback/blog** je takođe javno dostupan svima te prikazuje ocjenu servisa od strane registrovanih i vip korisnika, te komentare istih.

**Registracija** neregistrovani korisnik popunjava obrazac čime se prijavljuje za traženje kompaktibilnog partnera. Ovo uključuje niz pitanja koja se dijele na pitanja za utvrđivanje važnih životnih stavova, te pitanja za određivanje karakternih osobina. Sva pitanja su obavezna i na kraju slijedi prazno polje za dodatne zahtjeve dostupne samo nakon kartičnog plaćanja kojim se postaje vip korisnik što uključuje dodatne mogućnosti koje ćemo specificirati naknadno. Prilikom slanja obrasca slijedi rok za potvrdu putem maila/telefona nakon čega se prijava prihvaća ili odbija ukoliko rok istekne. Samom registracijom korisnik postaje učesnik u nagradnoj igri koja svakom n-tom SPOJENOM paru omogućava besplatnu uslugu.

**Plaćanje za pristup chat-u** slijedi nakon što je pronađeno potencijalno podudaranje dva korisnika s tim da vip korisnici vide više mogućih partnera, a obični korisnici samo najkompaktibilniju osobu tj. onu s najvećim postotkom u podudarnosti.

**Brisanje korisničkih računa po potrebi** znači da administrator može ukloniti račun sa recimo neprikladnim fotografijama prilikom odobravanja pronađenih poklapanja čime se postiže da drugi korisnici nikako ne mogu vidjeti neprimjeren sadržaj.

**Ažuriranje procenta kompaktibilnosti** se takođe obavlja prilikom odobravanja pronađenih poklapanja i to na osnovu dodatnih zahtjeva vip korisnika ukoliko ih ima.



