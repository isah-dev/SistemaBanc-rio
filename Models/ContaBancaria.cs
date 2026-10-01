namespace SistemaBancario.Models
{
    // clases abstratas só podem ser herdadas. E não instanciada

    //existem 3 tipos de modificadores:
    //publi = todos acessam
    // privada = só o dono acessa
    //protect = sós os filhos acessam ("quem tiver herdado", com acesso)
    

    //Pilar: Abstração Classe abstrata
    public abstract class ContaBancaria
    {
        // Pilar Encapsulamento : Campos privados protegidos por propriedades públicas
        //Campos
        private string _numeroConta;
        private decimal _saldo;

  
        //propriedades 
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value; 
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value; 
        }
        
        public string NomeTitular { get; set; }
        public List<string> ExtratoTransacoes {  get; set; } = new List<string>();

        //Construtor da classe base
        protected ContaBancaria(string numeroConta, string nomeTittular, decimal saldoInicial)

        {
            NumeroConta = numeroConta;
            NomeTitular  = nomeTittular;
            Saldo=saldoInicial;
            ExtratoTransacoes.Add($"Conta Criada com saldo inicial de : R${saldoInicial:F2}");

        }
    }
}
