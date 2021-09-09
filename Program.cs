using System;

namespace ProxyPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;
            PastaCompartilhadaProxy proxy;

            // Programador
            Console.WriteLine("Perfil 'Programador' acessando o proxy da pasta compartilhada");
            funcionario = new Funcionario("Jhonathan", "numsey", "Programador");
            proxy = new PastaCompartilhadaProxy(funcionario);
            proxy.OperacaoDeLeituraGravacao();

            // Usuário
            Console.WriteLine("Perfil 'Usuário' acessando o proxy da pasta compartilhada");
            funcionario = new Funcionario("Lucas", "numsey", "Usuario");
            proxy = new PastaCompartilhadaProxy(funcionario);
            proxy.OperacaoDeLeituraGravacao();

            // CEO
            Console.WriteLine("Perfil 'CEO' acessando o proxy da pasta compartilhada");
            funcionario = new Funcionario("Bill Gates", "numsey", "CEO");
            proxy = new PastaCompartilhadaProxy(funcionario);
            proxy.OperacaoDeLeituraGravacao();

        }
    }
}
