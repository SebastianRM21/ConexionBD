using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace proyectoBD_Eraso_Rosero.AccesoDatos
{
    class Datos
    {
        //AQUI VA LA CADENA DE CONEXION

        String cadenaConexion = @"USER ID = PROYECTOBD; DATA SOURCE = 192.168.1.55:1521/xe; password=oracle";

        //metodo para ejecutar insert, update o delete
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            //paso 1: creo una
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //paso 2: creo un comando
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            //paso 3: abrir 1a conexion
            miConexion.Open();
            /*paso 4: ejecuto el comando, este me devuelve el
             * numero de files que se afectaron ya sea con el
             * insert, update o delete que llegaba en La consulta*/

            filasAfectadas = comando.ExecuteNonQuery();
            //cerrar conexion
            miConexion.Close();
            return filasAfectadas;
        }

        public DataSet ejecutarSELECT(string consulta)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
