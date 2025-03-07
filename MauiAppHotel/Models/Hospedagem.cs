namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QuantidadeAdultos { get; set; }
        public int QuantidadeCrianca { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public decimal ValorTotal
        {
            get
            {
                decimal valorAdultos = QuantidadeAdultos * QuartoSelecionado.ValorDiariaAdulto;
                decimal valorCrianca = QuantidadeCrianca * QuartoSelecionado.ValorDiariaCrianca;

                decimal total = (valorAdultos + valorCrianca) * Estadia;

                return total;
            }
        }
    }
}
