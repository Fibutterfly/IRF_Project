BCE IRF évvégi beadandó

A kapott tételek:
1. Adatok importálása
	B) Adatbázis létrehozása, kapcsolódás és legalább egy tábla adatainak beolvasása
2. Adatfeldolgozás
	A) LINQ lekérdezés használata legalább egy WHERE feltétellel
3. Adatok exportálása / megjelenítése
	A) Írás CSV fájlba
4. Általános elemek
	D) Timer használata
	
Ötlet: Timer alkalmazás írása
	Egyszerre több Timert lehet használni, amik elnevezhetők. Amint lejár egy Timer az hanggal jelez. Név szerint kereshetőek a Timerek.
Cél: Úgy megírni, hogy késöbbiekben könnyedén fejleszhető legyen, mind új funkciók bevezetése tekintetében mind esetleges hibák, átgondolatlanságok tekintetében.
Funciók:
	1. Adatbázisban több Timer van, név szerint
	2. Adatbázisban lévő Timerek kilistázása, ahogyan a keresőmezőbe írunk, úgy dobálja ki a találatokat.
	3. Kiválasztott Timerek akitáválása
	4. Kiválasztottak elindítása, leállítása (szüneteltetése)
	5. Gomb nyomásra az adatbázis összes Timerének kimentése CSV fájlba
	6. Különböző Timerekhez különböző "Témákat" rendelni, amik most hangok lesznek
	7. Hátralévő idő kiírása