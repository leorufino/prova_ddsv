using System;
using System.Collections.Generic;

namespace API.Models
{
    public class FormaDePagamento
    {
        public FormaDePagamento() => CriadoEm = DateTime.Now;
        public int FormaDePagamentoId { get; set; }
        public string TipoDePagamento { get; set; }
        public string Parcelas { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}