using tabuleiro;
using System;

namespace excepcion
{
    class TabuleiroExcepcion : Exception
    {
        public TabuleiroExcepcion(string message) : base(message)
        {

        }
    }
}
