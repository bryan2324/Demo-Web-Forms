using DAL.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BS.Mantenimientos
{
   public  class MantCarro
    {

        private static MantCarro Instancia;

        public static MantCarro _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new MantCarro();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Actualizar(Cars cars)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimientos.MantCarro._Instancia.Actualizar(cars);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Cars cars)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimientos.MantCarro._Instancia.Eliminar(cars);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Cars cars)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimientos.MantCarro._Instancia.Insertar(cars);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Cars> Mostrar()
        {
            List<Cars> lista = new List<Cars>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Mantenimientos.MantCarro._Instancia.Mostrar();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

    }
}
