using System;
using System.Data;
using proyectoBD_Eraso_Rosero.AccesoDatos;

namespace proyectoBD_Eraso_Rosero.Logica
{
    class TorneoTenis
    {
        Datos dt = new Datos();
        public int ingresarTorneo(int cod, String nom)
        {
            int resultado;
            String consulta;
            consulta = "insert into tblTorneo(torCod,torNombre) values(" +
                cod + ",'" + nom + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet validarCodigoTor(int cod)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from tblTorneo where torCod=" + cod;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;

        }
    }
}
