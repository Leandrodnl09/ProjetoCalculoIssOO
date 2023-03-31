using System.Globalization;

namespace PrejetoBepecor.Entities
{
    public class Seguradoras
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public double Valor { get; set; }
        public string Municipios { get; set; }

        public Seguradoras(int id, string nome, string cnpj, double valor, string municipios)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Valor = 0;
            Municipios = municipios;
        }

        public Seguradoras()
        {

        }

        public string Municipio()
        {
            if (Id == 10 || Id == 3)
            {
                return " DE OUTRO MUNICIPIO";
            }
            else
            {
                return " DO MUNICIPIO";
            }
        }

        public override string ToString()
        {
            return "---------------------------------------------------------------------------\n"
                    + "SEGURADORA -  "
                    + Nome
                    + Municipio()
                    + " (CNPJ: "
                    + Cnpj
                    + ") R$ "
                    + Valor.ToString("F3", CultureInfo.InvariantCulture)
                    + "!\n"
                    + "\n---------------------------------------------------------------------------\n";
        }

        static private DateTime Data()
        {
            return DateTime.Now;
        }
        public string TextoParaNota()
        {
            return "Comissão refente à competència "
            + Data().ToString("MM/yyyy")
            + ". Empresa optante pelo Simples Nacional. (tributação aprox. 6%).";
        }

    }
}