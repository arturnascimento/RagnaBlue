using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codelabs2
{
    public class Hero
    {
        public Hero(string nome)
        {
            this.nome = nome;
            this.level = 1;
            this.exp = 0;
            this.vida = 10;
            Random attack = new Random();
            this.ataque = attack.Next() % 10 + 1;

        }

        private string nome;
        public string Nome
    {
            get { return nome; }
            set { nome = value; }
        }

        private int level;
        public int Level
    {
            get { return level; }
            set { level = value; }
        }

        private int ataque;
        public int Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }

        private int vida;

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

    private int exp;

        public int Exp
    {
            get { return exp; }
            set { exp = value; }
        }

        public void MaisExp(int expRecebida)
        {
            exp += expRecebida;
            int expUpar = (exp / 10) +1;
            Console.WriteLine(expUpar);
            if (expUpar > 0)
            {
                while(expUpar > level)
                {
                    UparLevel();

                }
            }
            
        }
        
        public void UparLevel()
        {
            level += 1;
            vida = level * 10;
            ataque += level;
            Console.WriteLine($"Parabens, o Herói {nome} subiu para o nível {level}");
        }



    }
}
