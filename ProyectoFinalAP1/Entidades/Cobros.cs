﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAP1.Entidades
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public Cobros()
        {
            CobroId = 0;
            PrestamoId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
        }
    }
}
