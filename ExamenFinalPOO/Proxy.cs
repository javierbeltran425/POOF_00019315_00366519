﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPOO
{
    public class Proxy
    {
        public interface ISujeto
        {
            void Peticion();
        }

        public class ProxyUsuario : ISujeto
        {
            public void Peticion()
            {

            }
        }

        private class ProxyVigilante : ISujeto
        {
            internal delegate void MyDelegate();
            public static MyDelegate employee;

            public void Peticion()
            {

            }
        }

        public class ProxyGerente : ISujeto
        {
            public void Peticion()
            {

            }
        }
    }
}
