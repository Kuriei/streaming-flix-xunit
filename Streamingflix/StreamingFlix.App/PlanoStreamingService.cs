namespace StreamingFlix.App
{
    public class PlanoStreamingService
    {
        // Retorna a classificação com base na quantidade de ecrãs/telas.
        public string ObterClassificacaoPorQualidade(int telasSimultaneas)
        {
            if (telasSimultaneas == 1) return "BÁSICO";
            if (telasSimultaneas == 2) return "PADRÃO";
            if (telasSimultaneas >= 4) return "PREMIUM";
            
            return "INVÁLIDO";
        }

        // Aplica 10% de desconto entre 6 e 11 meses, e 20% para 12 meses ou mais[cite: 15].
        public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
        {
            if (mesesContratados >= 12)
            {
                return valorBase - (valorBase * 20 / 100);
            }
            if (mesesContratados >= 6 && mesesContratados <= 11)
            {
                return valorBase - (valorBase * 10 / 100);
            }
            
            return valorBase; // Sem desconto para contratos inferiores a 6 meses
        }

        // Retorna true apenas se for maior de idade E o controlo parental estiver desligado (false)[cite: 15].
        public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
        {
            return idade >= 18 && controleParentalAtivo == false;
        }
    }
}