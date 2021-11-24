using System.Collections.Generic;

namespace PrehistoryMethodApp.Data
{
    public class TasksDataService
    {
        private static readonly Card[] taskOne = new[]
        {
            new Card {FirstWord = "mamut", SecondWord ="Předmostí u Přerova", Advices = "Zkuste se zamyslet, kudy mamuti putovali na našem území.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Mamuti u nás putovali přes Předmostí u Přerova."},
            new Card {FirstWord = "člověk vzpřímený<br>(Homo erectus)", SecondWord ="oheň", Advices = "Člověku vzpřímenému se také přezdívá Prometheus lidstva. Pokud někdo z Vás četl Staré řecké báje a pověsti, možná Vám díky tomu napoví.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Člověk vzpřímený byl náš první předek, který začal používat oheň."},
            new Card {FirstWord = "Keltové", SecondWord ="Závist", Advices = "Tady by se Vám hodil někdo, kdo zná aspoň trochu Bibli. Toto oppidum se totiž nazývá jako jeden ze smrtelných hříchů.", WrongAnswer = "Bohužel jste pojem přiřadili špatně. Naším největším oppidem je Závist (nachází se kousek od Prahy)."},
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
            new Card {FirstWord = "Velociraptor", SecondWord ="velociraptor.jpg", Advices = "Takhle VELOCIRAPTOR nevypadá.", WrongAnswer = "Bohužel jste pojem přiřadili špatně.", IsImage = true},
        };

        private static readonly Card[] taskEight= new[]
{
            new Card {FirstWord = "doba římská", Position = 1, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "mladší doba železná<br>(Latén) ", Position = 2, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "starší doba železná<br>(Halštat)", Position = 3, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "doba bronzová", Position = 4, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "pozdní doba kamenná<br>(eneolit)", Position = 5, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "mladší doba kamenná<br>(neolit)", Position = 6, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "střední doba kamenná<br>(mezolit)", Position = 7, Advices = "", WrongAnswer = ""},
            new Card {FirstWord = "starší doba kamenná<br>(paleolit)", Position = 8, Advices = "", WrongAnswer = ""},
        };

        private static readonly Question[] taskFour = new[]
        {
            new Question {
                Text = "Jak se nazývá muzeum v přírodě s historickými stavbami?",
                Answers = new() {
                    new Answer {Text = "oppidum", RightAnswer = false},
                    new Answer {Text = "skandál", RightAnswer = false},
                    new Answer {Text = "skanzen", RightAnswer = true},
                    new Answer {Text = "amulet", RightAnswer = false},
                },
                Advices = "",
                WrongAnswer = "",
            },
            new Question {
                Text = "Jak se nazývá období, které následuje po době ledové?",
                Answers = new() {
                    new Answer { Text = "doba meziledová", RightAnswer = true },
                    new Answer { Text = "doba horká", RightAnswer = false },
                    new Answer { Text = "doba slunečná", RightAnswer = false },
                    new Answer { Text = "doba oteplování", RightAnswer = false },
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "V jakém období se stavěly \"dlouhé domy\"?", 
                Answers = new() {
                    new Answer { Text = "doba bronzová", RightAnswer = false },
                    new Answer { Text = "starší doba kamenná (paleolit)", RightAnswer = false },
                    new Answer { Text = "mladší doba kamenný (neolit)", RightAnswer = true },
                    new Answer { Text = "mladší doba železná (laténská)", RightAnswer = false },
                },
                Advices = "",
                WrongAnswer = ""
            },
        };

        private static readonly Question[] taskFive = new[]
        {
            new Question {
                Text = "Hliněná nádoba, v níž byl do hrobu uložen popel z těla zemřelého se nazývá ...",
                Answers = new() {
                    new Answer {Text = "milodar", RightAnswer = false},
                    new Answer {Text = "popelnice", RightAnswer = true},
                    new Answer {Text = "monoxyl", RightAnswer = false},
                    new Answer {Text = "mohyla", RightAnswer = false},
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "Mladší doba kamenná (neolit) je důležitá proto, že v ní bylo vynalezeno ...",
                Answers = new() {
                    new Answer { Text = "oppidum", RightAnswer = false },
                    new Answer { Text = "kovotepectví", RightAnswer = false },
                    new Answer { Text = "bojování", RightAnswer = false },
                    new Answer { Text = "zemědělství", RightAnswer = true },
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "Prvním doloženým předkem člověka, který opustil Afriku byl ...",
                Answers = new() {
                    new Answer { Text = "člověk vzpřímený (Homo erectus)", RightAnswer = true },
                    new Answer { Text = "člověk zručný (Homo habilis)", RightAnswer = false },
                    new Answer { Text = "člověk moudrý (Homo sapiens)", RightAnswer = false },
                    new Answer { Text = "člověk dnešního typu (Homo sapiens sapiens)", RightAnswer = false },
                },
                Advices = "",
                WrongAnswer = ""
            },
        };

        private static readonly Question[] taskSix = new[]
        {
            new Question {
                Text = "Co sem nepatří?",
                Answers = new() {
                    new Answer {Text = "menhir", RightAnswer = false},
                    new Answer {Text = "doba bronzová", RightAnswer = false},
                    new Answer {Text = "srstnatý nosorožec", RightAnswer = true},
                    new Answer {Text = "Stonehenge", RightAnswer = false},
                },
                Advices = "",
                WrongAnswer = "",
                Background = "/images/stonehenge.jpg"
            },
            new Question {
                Text = "Co sem nepatří?",
                Answers = new() {
                    new Answer { Text = "druid", RightAnswer = false },
                    new Answer { Text = "Bójové", RightAnswer = false },
                    new Answer { Text = "oppidum", RightAnswer = false },
                    new Answer { Text = "Thor", RightAnswer = true },
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "Co sem nepatří?",
                Answers = new() {
                    new Answer { Text = "mamut", RightAnswer = false },
                    new Answer { Text = "medvěd jeskynní", RightAnswer = false },
                    new Answer { Text = "lev jeskynní", RightAnswer = true },
                    new Answer { Text = "brachiosaurus", RightAnswer = true },
                },
                Advices = "",
                WrongAnswer = ""
            },
        };

        private static readonly Question[] taskSeven = new[]
        {
            new Question {
                Text = "Člověk dnešního typu (Homo sapiens sapiens) se mohl setkat s člověkem zručným (Homo habilis).",
                Answers = new() {
                    new Answer {Text = "pravda", RightAnswer = false},
                    new Answer {Text = "nepravda", RightAnswer = true},
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "Germánští kněží se nazývali druidové.",
                Answers = new() {
                    new Answer { Text = "pravda", RightAnswer = false },
                    new Answer { Text = "nepravda", RightAnswer = true },
                },
                Advices = "",
                WrongAnswer = ""
            },
            new Question {
                Text = "Keltský kmen Bojů dal název naší vlasti – Bohemia.",
                Answers = new() {
                    new Answer { Text = "pravda", RightAnswer = true },
                    new Answer { Text = "nepravda", RightAnswer = false },
                },
                Advices = "",
                WrongAnswer = ""
            },
        };

        private static readonly Dictionary<string, State> taskOneState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Pravěká spojovačka",
                    Text = "Úkolem v tomto stanovišti je spojit pojmy, které k sobě patří.<br> Přesouvejte pojmy (přidržte na něm prst, pak přesuňte) z levého sloupce do pravého.<br> Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>X</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste 2x špatně.",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskTwoState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Učíme se keltsky",
                    Text = "Z doby Keltů nám zůstalo mnoho zeměpisných názvů. Úkolem v tomto stanovišti je spojit keltské názvy řek (levý sloupec) s názvy českými (pravý sloupec), které k sobě patří.<br> Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>G</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste 2x špatně.",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskThreeState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Poznáváme dinosaury",
                    Text = "Dinosauři vyhynuli již před 65 miliony let. Úkolem v tomto stanovišti je spojit názvy druhů dinosaurů (levý sloupec) s jejich ilustracemi (pravý sloupec).<br> Přesouvejte názvy (přidržte na něm prst a přesuňte) z levého sloupce Postupujte velmi opatrně! Na tomto stanovišti nesmíte udělat <b>ŽÁDNOU</b> chybu, aby se Vám podařilo jeho záhadu rozluštit."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>T</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně.",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskFourState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Co je správně?",
                    Text = "Úkolem v tomto stanovišti je označit správnou odpověď.<br> Postupujte ale opatrně! Abyste rozluštili záhadu tohoto stanoviště, nesmíte udělat <b>ŽÁDNOU</b> chybu."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>M</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskFiveState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Pravěká doplňovačka",
                    Text = "Úkolem v tomto stanovišti je doplnit správně větu.<br> Postupujte ale opatrně! Abyste rozluštili záhadu tohoto stanoviště, nesmíte udělat <b>ŽÁDNOU</b> chybu."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>V</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskSixState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Patří, patří, nepatří!",
                    Text = "Úkolem v tomto stanovišti je označit termín, který nepatří mezi ostatní.<br> Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>U</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskSevenState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Pravda, nebo lež?",
                    Text = "Úkolem v tomto stanovišti je rozhodnout, zda je věta pravdivá.<br> Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>Q</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };

        private static readonly Dictionary<string, State> taskEightState = new()
        {
            {
                "default",
                new State()
                {
                    Headline = "Jak to šlo po sobě",
                    Text = "Úkolem v tomto stanovišti je seřadit jednotlivá období chronologicky (1. bude nejmladší období, 8. bude nejstarší období).<br> Přesouvejte (přidržte na pojmu prst a pak posuňte) názvy jednotlivých období na příslušné pořadí (box s číslem).<br> Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
                }
            },
            {
                "success",
                new State()
                {
                    Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
                    Text = "Zapiště si písmeno <b>C</b> a pokračujte prosím na další stanoviště."
                }
            },
            {
                "fail",
                new State()
                {
                    Headline = "Odpověděli jste chybně",
                    Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
                }
            }
        };


        public static Card[] TaskOne { get => taskOne; }

        public static Card[] TaskTwo { get => taskTwo; }
        public static Card[] TaskThree { get => taskThree; }
        public static Question[] TaskFour { get => taskFour; }
        public static Question[] TaskFive { get => taskFive; }
        public static Question[] TaskSix { get => taskSix; }
        public static Question[] TaskSeven { get => taskSeven; }
        public static Card[] TaskEight { get => taskEight; }

        public static Dictionary<string, State> TaskOneState { get => taskOneState; }

        public static Dictionary<string, State> TaskTwoState { get => taskTwoState; }
        public static Dictionary<string, State> TaskThreeState { get => taskThreeState; }
        public static Dictionary<string, State> TaskFourState { get => taskFourState; }
        public static Dictionary<string, State> TaskFiveState { get => taskFiveState; }
        public static Dictionary<string, State> TaskSixState { get => taskSixState; }
        public static Dictionary<string, State> TaskSevenState { get => taskSevenState; }
        public static Dictionary<string, State> TaskEightState { get => taskEightState; }
    }
}
