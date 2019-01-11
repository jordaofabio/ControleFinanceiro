﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleFinanceiro.Controllers
{
    [Route("api/[controller]")]
    public class EntradaController : Controller
    {
        // GET: api/<controller>
        [HttpGet("{qtdParcelas}")]
        public string Get(int qtdParcelas)
        {
            int mesAtual = DateTime.Today.Month;
            int anoAtual = DateTime.Today.Year;

            int mesPrimeiraParcela = mesAtual + 1;
            int anoPrimeiraParcela = anoAtual;
            int mesUltimaParcela = (mesPrimeiraParcela + qtdParcelas) > 12 ? (mesPrimeiraParcela + qtdParcelas) - 12 : mesPrimeiraParcela + qtdParcelas;
            int anoUltimaParcela = qtdParcelas + mesPrimeiraParcela > 12 ? anoAtual + 1 : anoAtual;


            while (mesUltimaParcela > 12)
            {
                mesUltimaParcela = mesUltimaParcela - 12;
                anoUltimaParcela++;
            }

            return string.Format("Parcelas de {0}/{1} até {2}/{3} ", mesPrimeiraParcela, anoPrimeiraParcela, mesUltimaParcela, anoUltimaParcela);
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
