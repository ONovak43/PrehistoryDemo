namespace PrehistoryMethodApp.Data
{
    public class TasksDataService
    {
        private static readonly Card[] taskOne = new[]
        {
            new Card {FirstWord = "mamut", SecondWord ="P�edmost� u P�erova", Advices = "Zkuste se zamyslet, kudy mamuti putovali na na�em �zem�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Mamuti u n�s putovali p�es P�edmost� u P�erova."},
            new Card {FirstWord = "�lov�k vzp��men� (Homo erectus)", SecondWord ="ohe�", Advices = "�lov�ku vzp��men�mu se tak� p�ezd�v� Prometheus lidstva. Pokud n�kdo z V�s �etl Star� �eck� b�je a pov�sti, mo�n� V�m d�ky tomu napov�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. �lov�k vzp��men� byl n� prvn� p�edek, kter� za�al pou��vat ohe�."},
            new Card {FirstWord = "pterodactylus", SecondWord ="ptakoje�t�r", Advices = "Mo�n� V�m napov�, �e pterodactylus znamen� \"k��deln� prst\".", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Pterodactylus byl ptakoje�t�r. Rozp�t� jeho k��del mohlo b�t i p�es dva metry."},
            new Card {FirstWord = "�eck� n�zev pro star�� dobu kamennou", SecondWord ="paleolit", Advices = "Velkou n�pov�dou pro V�s je, �e �ecky se star� �ekne \"palaios\" a k�men \"lithios\".", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Star�� dobu kamennou ozna�ujeme �ecky jako paleolit."},
            new Card {FirstWord = "nejv�t�� nalezen� oppidum v �ech�ch", SecondWord ="Z�vist", Advices = "Tady by se V�m hodil n�kdo, kdo zn� aspo� trochu Bibli. Toto oppidum se toti� naz�v� jako jeden ze smrteln�ch h��ch�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Na��m nejv�t��m oppidem je Z�vist (nach�z� se kousek od Prahy)."},
            new Card {FirstWord = "germ�nsk� b�h", SecondWord ="�din", Advices = "Vid�li jste n�kter� film od Marvelu (t�eba Thor)? Pokud ano, tak V�m odpov�� mus� b�t jasn�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Hlavn�m germ�nsk�m bohem byl �din, jeho jin� jm�na jsou jsou nap��klad Woden �i Wotan."},
        };

        private static readonly Card[] taskTwo = new[]
        {
            new Card {FirstWord = "Albis (b�l� �eka)", SecondWord ="Labe", Advices = "Sou�asn� n�zvy jsou t�m keltsk�m velmi podobn�. Zkuste si v�echna slova p�e��st po��dn�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Albis je �eka Labe."},
            new Card {FirstWord = "Vultava (divok� �eka)", SecondWord ="Vltava", Advices = "Sou�asn� n�zvy jsou t�m keltsk�m velmi podobn�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Vultava je �eka Vltava, nejdel�� �eka u n�s."},
            new Card {FirstWord = "Agara (�eka, kter� m� rychl� tok)", SecondWord ="Oh�e", Advices = "Sou�asn� n�zvy jsou t�m keltsk�m velmi podobn�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Agara je �eka Oh�e."},
            new Card {FirstWord = "Isara (bystr� �eka)", SecondWord ="Jizera", Advices = "Sou�asn� n�zvy jsou t�m keltsk�m velmi podobn�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�. Isara je �eka Jizera."},
        };

        private static readonly Card[] taskThree = new[]
{
            new Card {FirstWord = "Tyranosaurus rex", SecondWord ="trex.jpg", Advices = "Takhle TYRANOSAURUS REX nevypad�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�.", IsImage = true},
            new Card {FirstWord = "Triceratops ", SecondWord ="triceratops.jpg", Advices = "Takhle TRICERATOPS nevypad�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�.", IsImage = true},
            new Card {FirstWord = "Stegosaurus", SecondWord ="stegosaurus.jpg", Advices = "Takhle STEGOSAURUS nevypad�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�.", IsImage = true},
            new Card {FirstWord = "Velociraptor", SecondWord ="velociraptor.jpg", Advices = "Takhle VELOCIRAPTOR nevypad�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�.", IsImage = true},
            new Card {FirstWord = "Iguanodon", SecondWord ="iguanodon.jpg", Advices = "Takhle IGUANODON nevypad�.", WrongAnswer = "Bohu�el jste pojem p�i�adili �patn�.", IsImage = true},
        };

        public static Card[] TaskOne { get => taskOne; }

        public static Card[] TaskTwo { get => taskTwo; }
        public static Card[] TaskThree { get => taskThree; }

    }
}
