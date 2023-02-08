﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1_TiffanyAguilarF
{
    public class Venta
    {
        private long id;
        private string comentarios;
        private long idUsuario;

        public Venta(long id, string comentarios, long idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }

        public long Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }

        public override string ToString()
        {
            return $"Id: {Id}\tComentarios: {Comentarios}\tId Usuario: {IdUsuario}";
        }
    }

}

