using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_INICIARSESION
    {
        private CD_INICIARSESION objeto = new CD_INICIARSESION();
        private String _usuario;
        private String _contraseña;

        public string Usuario
        {
            set
            {
                if (value == "Usuario") { _usuario = "Ingrese un nombre de usuario"; }
                else { _usuario = value; }
            }
            get { return _usuario; }
        }


        public String Contraseña
        {
            set {
                if (value == "Contraseña") _contraseña = "Ingrese su contraseña";
            }
            get { return _contraseña; }
        }


        public CN_INICIARSESION() { } 

        public SqlDataReader IniciarSesion(){
            SqlDataReader Loguear;
            Loguear= objeto.IniciarSesion(Usuario,Contraseña);
            return Loguear;
        }
        }
    }

