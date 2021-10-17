namespace PrehistoryMethodApp.Data
{
    public class TasksDataService
    {
        private static readonly Card[] taskOne = new[]
        {
            new Card {FirstWord = "mamut", SecondWord ="Pøedmostí u Pøerova", Advices = "Zkuste se zamyslet, kudy mamuti putovali na našem území.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Mamuti u nás putovali pøes Pøedmostí u Pøerova."},
            new Card {FirstWord = "èlovìk vzpøímenı (Homo erectus)", SecondWord ="oheò", Advices = "Èlovìku vzpøímenému se také pøezdívá Prometheus lidstva. Pokud nìkdo z Vás èetl Staré øecké báje a povìsti, moná Vám díky tomu napoví.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Èlovìk vzpøímenı byl náš první pøedek, kterı zaèal pouívat oheò."},
            new Card {FirstWord = "pterodactylus", SecondWord ="ptakoještìr", Advices = "Moná Vám napoví, e pterodactylus znamená \"køídelní prst\".", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Pterodactylus byl ptakoještìr. Rozpìtí jeho køídel mohlo bıt i pøes dva metry."},
            new Card {FirstWord = "øeckı název pro starší dobu kamennou", SecondWord ="paleolit", Advices = "Velkou nápovìdou pro Vás je, e øecky se starı øekne \"palaios\" a kámen \"lithios\".", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Starší dobu kamennou oznaèujeme øecky jako paleolit."},
            new Card {FirstWord = "nejvìtší nalezené oppidum v Èechách", SecondWord ="Závist", Advices = "Tady by se Vám hodil nìkdo, kdo zná aspoò trochu Bibli. Toto oppidum se toti nazıvá jako jeden ze smrtelnıch høíchù.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Naším nejvìtším oppidem je Závist (nachází se kousek od Prahy)."},
            new Card {FirstWord = "germánskı bùh", SecondWord ="Ódin", Advices = "Vidìli jste nìkterı film od Marvelu (tøeba Thor)? Pokud ano, tak Vám odpovìï musí bıt jasná.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Hlavním germánskım bohem byl Ódin, jeho jiná jména jsou jsou napøíklad Woden èi Wotan."},
        };

        private static readonly Card[] taskTwo = new[]
        {
            new Card {FirstWord = "Albis (bílá øeka)", SecondWord ="Labe", Advices = "Souèasné názvy jsou tìm keltskım velmi podobné. Zkuste si všechna slova pøeèíst poøádnì.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Albis je øeka Labe."},
            new Card {FirstWord = "Vultava (divoká øeka)", SecondWord ="Vltava", Advices = "Souèasné názvy jsou tìm keltskım velmi podobné.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Vultava je øeka Vltava, nejdelší øeka u nás."},
            new Card {FirstWord = "Agara (øeka, která má rychlı tok)", SecondWord ="Ohøe", Advices = "Souèasné názvy jsou tìm keltskım velmi podobné.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Agara je øeka Ohøe."},
            new Card {FirstWord = "Isara (bystrá øeka)", SecondWord ="Jizera", Advices = "Souèasné názvy jsou tìm keltskım velmi podobné.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì. Isara je øeka Jizera."},
        };

        private static readonly Card[] taskThree = new[]
{
            new Card {FirstWord = "Tyranosaurus rex", SecondWord ="trex.jpg", Advices = "Takhle TYRANOSAURUS REX nevypadá.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì.", IsImage = true},
            new Card {FirstWord = "Triceratops ", SecondWord ="triceratops.jpg", Advices = "Takhle TRICERATOPS nevypadá.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì.", IsImage = true},
            new Card {FirstWord = "Stegosaurus", SecondWord ="stegosaurus.jpg", Advices = "Takhle STEGOSAURUS nevypadá.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì.", IsImage = true},
            new Card {FirstWord = "Velociraptor", SecondWord ="velociraptor.jpg", Advices = "Takhle VELOCIRAPTOR nevypadá.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì.", IsImage = true},
            new Card {FirstWord = "Iguanodon", SecondWord ="iguanodon.jpg", Advices = "Takhle IGUANODON nevypadá.", WrongAnswer = "Bohuel jste pojem pøiøadili špatnì.", IsImage = true},
        };

        public static Card[] TaskOne { get => taskOne; }

        public static Card[] TaskTwo { get => taskTwo; }
        public static Card[] TaskThree { get => taskThree; }

    }
}
