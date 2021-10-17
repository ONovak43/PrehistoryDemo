namespace PrehistoryMethodApp.Data
{
    public class TasksDataService
    {
        private static readonly Card[] taskOne = new[]
        {
            new Card {FirstWord = "mamut", SecondWord ="Předmostí u Přerova", Advices = "Zkuste se zamyslet, kudy mamuti putovali na našem území.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Mamuti u nás putovali přes Předmostí u Přerova."},
            new Card {FirstWord = "člověk vzpřímený (Homo erectus)", SecondWord ="oheň", Advices = "Člověku vzpřímenému se také přezdívá Prometheus lidstva. Pokud někdo z Vás četl Staré řecké báje a pověsti, možná Vám díky tomu napoví.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Člověk vzpřímený byl náš první předek, který začal používat oheň."},
            new Card {FirstWord = "pterodactylus", SecondWord ="ptakoještěr", Advices = "Možná Vám napoví, že pterodactylus znamená \"křídelní prst\".", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Pterodactylus byl ptakoještěr. Rozpětí jeho křídel mohlo být i přes dva metry."},
            new Card {FirstWord = "řecký název pro starší dobu kamennou", SecondWord ="paleolit", Advices = "Velkou nápovědou pro Vás je, že řecky se starý řekne \"palaios\" a kámen \"lithios\".", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Starší dobu kamennou označujeme řecky jako paleolit."},
            new Card {FirstWord = "největší nalezené oppidum v Čechách", SecondWord ="Závist", Advices = "Tady by se Vám hodil někdo, kdo zná aspoň trochu Bibli. Toto oppidum se totiž nazývá jako jeden ze smrtelných hříchů.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Naším největším oppidem je Závist (nachází se kousek od Prahy)."},
            new Card {FirstWord = "germánský bůh", SecondWord ="Ódin", Advices = "Viděli jste některý film od Marvelu (třeba Thor)? Pokud ano, tak Vám odpověď musí být jasná.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Hlavním germánským bohem byl Ódin, jeho jiná jména jsou jsou například Woden či Wotan."},
        };

        private static readonly Card[] taskTwo = new[]
        {
            new Card {FirstWord = "Albis (bílá řeka)", SecondWord ="Labe", Advices = "Současné názvy jsou těm keltským velmi podobné. Zkuste si všechna slova přečíst pořádně.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Albis je řeka Labe."},
            new Card {FirstWord = "Vultava (divoká řeka)", SecondWord ="Vltava", Advices = "Současné názvy jsou těm keltským velmi podobné.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Vultava je řeka Vltava, nejdelší řeka u nás."},
            new Card {FirstWord = "Agara (řeka, která má rychlý tok)", SecondWord ="Ohře", Advices = "Současné názvy jsou těm keltským velmi podobné.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Agara je řeka Ohře."},
            new Card {FirstWord = "Isara (bystrá řeka)", SecondWord ="Jizera", Advices = "Současné názvy jsou těm keltským velmi podobné.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Isara je řeka Jizera."},
        };

        private static readonly Card[] taskThree = new[]
{
            new Card {FirstWord = "Tyranosaurus rex", SecondWord ="trex.jpg", Advices = "Takhle TYRANOSAURUS REX nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
            new Card {FirstWord = "Triceratops ", SecondWord ="triceratops.jpg", Advices = "Takhle TRICERATOPS nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
            new Card {FirstWord = "Stegosaurus", SecondWord ="stegosaurus.jpg", Advices = "Takhle STEGOSAURUS nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
            new Card {FirstWord = "Velociraptor", SecondWord ="velociraptor.jpg", Advices = "Takhle VELOCIRAPTOR nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
            new Card {FirstWord = "Iguanodon", SecondWord ="iguanodon.jpg", Advices = "Takhle IGUANODON nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
        };

        public static Card[] TaskOne { get => taskOne; }

        public static Card[] TaskTwo { get => taskTwo; }
        public static Card[] TaskThree { get => taskThree; }

    }
}
