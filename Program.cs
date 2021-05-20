using System;

namespace codelabs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Ragnablue");
            Console.WriteLine("Informe o nome do seu Heroi: ");
            Hero h1 = new Hero(Console.ReadLine());

            ExibirHero(h1);

            
            Console.WriteLine("Vamos começar nossa jornada, Bluemer!!");
            
           
            while (true)
            {
                Console.WriteLine("Escolha um monstro casca grossa para bater!! Ou saia do Game!! ");
                Console.WriteLine("1 - Orc Malvadão");
                Console.WriteLine("2 - Troll Trollador");
                Console.WriteLine("3 - Goblin Exterminador");
                Console.WriteLine("4 - Sou fraco e quero sair!");
                
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Monsters orc = new Monsters("Orc", h1.Level);
                        Round(orc, h1);
                        break;
                    case "2":
                        Monsters troll = new Monsters("Troll", h1.Level);
                        Round(troll, h1);
                        break;
                    case "3":
                        Monsters goblin = new Monsters("Goblin", h1.Level);
                        Round(goblin, h1);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }


        public static void ExibirHero(Hero h)
        {
            Console.WriteLine($"Atributos do Herói: {h.Nome}!");
            
            Console.WriteLine($"Ataque - {h.Ataque}");
            Console.WriteLine($"Vida - {h.Vida}");
            Console.WriteLine($"Nível - {h.Level}");
            Console.WriteLine($"Experiência - {h.Exp}");
            

        }

        public static void ExibirMonstro(Monsters m)
        {
            Console.WriteLine($"Atributos do Monstro: {m.nm}!");
            Console.WriteLine($"Ataque - {m.ataque}");
            Console.WriteLine($"Vida - {m.vida}");
            Console.WriteLine($"Experiência - {m.exp}");


        }

        public static bool LutarOuFugir()
        {
            Console.WriteLine("Vai encarar ou fugir?! HAHAHAHAHHA!!");
            Console.WriteLine("1 - Vou meter a porrada!!");
            Console.WriteLine("2 - Vou meter o pé!!");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void LutarMonstro(Hero h, Monsters m)
        {
            while(h.Vida > 0 && m.vida > 0)
            {
                m.vida -= h.Ataque;
                h.Vida -= m.ataque;
                if(h.Vida <= 0)
                {
                    Console.WriteLine("Você é fraco e morreu!!");
                    Environment.Exit(0);
                    break;
                }
                else if (m.vida <= 0)
                {
                    Console.WriteLine($"Vida do Heroi é: {h.Vida}");
                    Console.WriteLine($"Vida do Monstro é: 0 ");
                    Console.WriteLine($"Parabens, você matou o {m.nm} ganhou mais {m.exp} de experiência.");
                    break;
                }
                Console.WriteLine($"Vida do Heroi é: {h.Vida}");
                Console.WriteLine($"Vida do Monstro é: {m.vida} ");
                if (!LutarOuFugir())
                {
                    break;
                }

            }
            
            
        }


        public static void Round(Monsters m, Hero h)
        {
            ExibirMonstro(m);
            if (LutarOuFugir())
            {
                LutarMonstro(h, m);
                h.MaisExp(m.exp);
                
                ExibirHero(h);
            }
        }

    }

    
}
