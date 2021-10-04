using Microsoft.EntityFrameworkCore;
using RegistroAnimes.DAL;
using RegistroAnimes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnimes.BLL
{
    public class AnimesBLL
    {
        public static bool Guardar(Animes anime)
        {
            if (!Existe(anime.AnimeId))
                return Insertar(anime);
            else
                return Modificar(anime);
        }
        private static bool Insertar(Animes anime)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Animes.Add(anime);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Animes anime)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(anime).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var anime = contexto.Animes.Find(id);

                if (anime != null)
                {
                    contexto.Animes.Remove(anime);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Animes.Any(e => e.AnimeId == id);
            }                
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static Animes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Animes anime;

            try
            {
                anime = contexto.Animes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return anime;
        }

    }
}   
