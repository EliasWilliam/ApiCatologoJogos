using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}