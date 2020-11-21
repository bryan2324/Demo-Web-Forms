using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mantenimientos
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
        public void Actualizar(Cars car)
        {
            try
            {
                using ( VehiculosEntities entities = new VehiculosEntities())
                {
                    entities.Entry(car).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        public void Eliminar(Cars car)
        {
            try
            {
                VehiculosEntities entities = new VehiculosEntities();
                var result = entities.Cars.Find(car.Car_Id);
                entities.Cars.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Cars car)
        {
            try
            {
                VehiculosEntities entities = new VehiculosEntities();
                entities.Cars.Add(car);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Cars> Mostrar()
        {
            //Inicializamos
            List<Cars> lista = new List<Cars>();

            try
            {
                VehiculosEntities entities = new VehiculosEntities();
                lista = entities.Cars.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

    }
}
