using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codelabs2
{
    class Monsters
    {
        public Monsters(string nome, int level)
        {
            this.nm = nome;
            this.lvl = level;

            CriarMonstro(this.nm, this.lvl);
            
            

        }

        public string nm { get; }
        public int lvl { get; }
        public int ataque { get; set; }
        public int vida { get; set; }
        public int exp { get; set; }


        public void CriarOrc(int lvl)
        {
            ataque  = lvl;
            vida = lvl * 2;
            exp = ataque +vida;
        }

        public void CriarTroll(int lvl)
        {
            ataque = lvl * 2;
            vida = lvl * 5;
            exp = ataque + vida;
        }

        public void CriarGoblin(int lvl)
        {
            ataque = lvl * 4;
            vida = lvl * 10;
            exp = ataque + vida;
        }

        public void CriarMonstro(string nome, int level)
        {
            if (nome == "Orc")
            {
                CriarOrc(level);

            } else if (nome == "Troll")
            {
                CriarTroll(level);

            } else if (nome == "Goblin")
            {
                CriarGoblin(level);
            }
        }
    }


}
