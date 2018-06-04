﻿using Controllers.Base;
using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AtividadesController : IBaseController<Atividade>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Atividade entity)
        {
            contexto.Atividades.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Atividade entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Atividade BuscarPorID(int id)
        {

            return contexto.Atividades.Find(id);
        }

        public void Excluir(int id)
        {
            Atividade a = BuscarPorID(id);
            if(a != null)
            {
                //forma 1
                //contexto.Atividades.Remove(a);
                //contexto.SaveChanges();

                //forma 2
                contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();

            }
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            //LINQ
            //var atividadesComNome = from a in contexto.Atividades
            //            where a.Nome == nome
            //            select a;

            //return atividadesComNome.ToList();

            //LAMBDA
            return contexto.Atividades.Where(a => a.Nome == nome).ToList();
        }

        public IList<Atividade> ListarTodos()
        {
            return contexto.Atividades.ToList();
        }

    }
}
