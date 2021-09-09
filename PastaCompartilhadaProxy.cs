using System;

namespace ProxyPattern
{
    //Proxy: contém uma referência à classe RealSubject e pode acessar os membros da classe RealSubject conforme necessário
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private readonly Funcionario funcionario;
        private IPastaCompartilhada pasta;

        public PastaCompartilhadaProxy(Funcionario funci)
        {
            funcionario = funci;
        }
        public void OperacaoDeLeituraGravacao()
        {
            if (String.Equals(funcionario.Perfil, "CEO", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Proxy 'Pasta Compartilhada' sendo invocado apontando para o serviço real \n");

                pasta = new PastaCompartilhada();
                pasta.OperacaoDeLeituraGravacao();
            }
            else
                Console.WriteLine("Acesso negado para Proxy 'Pasta Compartilhada' \n");
        }
    }
}
