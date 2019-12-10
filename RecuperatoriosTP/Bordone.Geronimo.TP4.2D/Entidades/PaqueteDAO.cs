﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection("Data Source=PC001\\SQLEXPRESS01;Initial Catalog=correo-sp-2017;Integrated Security=True");
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }

        public static bool Insertar(Paquete p)
        {
            bool returnValue = false;

            string sqlCommand;
            sqlCommand = "INSERT INTO Paquetes (direccionEntrega, trackingID, alumno) Values(";
            sqlCommand = sqlCommand + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','" + "Geronimo Bordone" + "')";
            PaqueteDAO.comando.CommandText = sqlCommand;
            PaqueteDAO.conexion.Open();
            PaqueteDAO.comando.ExecuteNonQuery();
            returnValue = true;

            PaqueteDAO.conexion.Close();
            return returnValue;
        }

    }
}