using System;
using proyectoBD_Eraso_Rosero.AccesoDatos;
using System.Data;

namespace proyectoBD_Eraso_Rosero.Logica
{
    class Tenista
    {
        Datos dt = new Datos();

        public int ingresarTenista(int cod, String nom, String apel, String cat)
        {
            int resultado;
            String consulta;
            consulta = "insert into tblTenista(tenCod,tenNombre,tenapellido,tencategoria) values(" +
                cod + ",'" + nom + "','" + apel + "','" + cat + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet validarCodigoTen(int cod)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from tblTenista where tenCod="+cod;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;

        }

        public DataSet consulta2()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select count(tenCod) cuenta from tblTenista where tencategoria = 'SENIOR'";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
    }
}
