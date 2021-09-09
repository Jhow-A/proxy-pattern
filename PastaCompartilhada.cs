using System;

namespace ProxyPattern
{
    //RealSubject: serviço real que será encapsulado pela classe Proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            Console.WriteLine(">>> Operação: Read & Write na pasta compartilhada");
        }
    }
}
