﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Permissao
    {
        public int Id { get; set; }
        public string Descricao { get; set; } 
        public List<GrupoUsuario> Grupos { get; set; }
    }
}
