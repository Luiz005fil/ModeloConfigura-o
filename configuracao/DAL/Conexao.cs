﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA;Intial Catalog=Configuracao;Data Source=.\SQLEXPRESS2019;Password=Senalab02";
            }
        }
    }
}