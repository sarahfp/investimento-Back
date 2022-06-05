namespace investimento_back.Model
{
    public class Investimento
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal valor { get; set; }

        public Investimento (int id, string? name, string? description, decimal valor)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.valor = valor;
        }
    }
}
