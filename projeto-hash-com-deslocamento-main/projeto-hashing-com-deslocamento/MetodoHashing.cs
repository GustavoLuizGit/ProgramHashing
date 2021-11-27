using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_hashing_com_deslocamento
{
    class MetodoHashing
    {
        private string chave;
        public int teste;
        int calc = 0;
        public MetodoHashing(string chave)
        {
            this.Chave = chave;
        }
        public string Chave { get => chave; set => chave = value; }

        public void MetodoHash()
        {
            for (int i = 0; i < Chave.Length; i++)
            {
                int asc = 0;
                if (i > 7)
                {
                    asc = (byte)(Chave[i] << i - 7);
                    calc += asc;
                }
                else
                {
                    asc = (byte)(Chave[i] << i);
                    calc += asc;
                }
            }
            teste = calc % 7;
        }
        public int testeretun()
        {
            return teste;
        }
        public string Mostra()
        {
            {
                switch (teste)
                {
                    case 0:
                        return " " + Chave + " - " + calc.ToString();
                    case 1:
                        return " " + Chave + " - " + calc.ToString();
                    case 2:
                        return " " + Chave + " - " + calc.ToString();
                    case 3:
                        return " " + Chave + " - " + calc.ToString();
                    case 4:
                        return " " + Chave + " - " + calc.ToString();
                    case 5:
                        return " " + Chave + " - " + calc.ToString();
                    case 6:
                        return " " + Chave + " - " + calc.ToString();
                }
                return "Sem Amostras";
            }
        }
    }
}
