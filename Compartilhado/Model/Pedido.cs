﻿using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Model
{
    [DynamoDBTable("pedidos")]
    public class Pedido
    {
        [DynamoDBProperty("id")]
        public string? Id { get; set; }
        public decimal? ValorTotal { get; set; }
        public DateTime? DataDeCriacao { get; set; }
        public List<Produto> Produtos { get; set; }
        public Cliente Cliente { get; set; }
        public Pagamento Pagamento { get; set; }
        public string? Justificativa { get; set; }
        public string? Status { get; set; }
        public bool? Pago { get; set; }
        public bool? Faturado { get; set; }
    }
}