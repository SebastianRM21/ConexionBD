using System;
using System.Data;
using proyectoBD_Eraso_Rosero.AccesoDatos;

namespace proyectoBD_Eraso_Rosero.Logica
{
    class Registro
    {
        Datos dt = new Datos();
        public int registrar(int codten, int codtor, String Fecha, String Hora)
        {
            
            int resultado;
            String consulta;
            consulta = "insert into tblRegistro(regCodTenista, regCodTorneo, regFecha, regHora)" +
                "values("+codten+","+codtor+", '"+Fecha+"', '"+Hora+"')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet consulta1(int cod,String fecha)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select tbltorneo.tornombre,tbltenista.tencod,tbltenista.tennombre,tbltenista.tenApellido, tblRegistro.regHora from tblRegistro " +
                "INNER JOIN tbltorneo on tbltorneo.torcod=tblRegistro.regCodTorneo INNER JOIN tbltenista on tblregistro.regcodtenista=tbltenista.tenCod " +
                "where tbltorneo.torcod="+cod+" and (tblRegistro.regfecha='"+fecha+"') ";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;

        }
    }
}
