﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Soldado
    {
        protected IArma arma;

        //Constructor recibe como parámetro una instancia de arma
        public Soldado(IArma _arma)
        {
            this.arma = _arma;
        }

        //Método para cambiar el arma donde recibimos como parámetro una instancia de arma y llamamos a la función que imprime el cambio por pantalla
        public void CambiarArma(IArma _arma)
        {
            this.arma = _arma;
            var cambioArma = new CambiosArma("soldado", _arma);
        }

        //Método disparar que llama a la método Disparar de la instancia de arma creada
        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }

    //Clase Revolver y su método Disparar
    public class Revolver : IArma
    {
        public string Disparar()
        {
            return "Pum Pum ..";
        }
    }

    //Clase Rifle y su método Disparar
    public class Rifle : IArma
    {
        public string Disparar()
        {
            return "Pum pum pum pum pum ..";
        }
    }

    //Clase Escopeta y su método Disparar
    public class Escopeta : IArma
    {
        public string Disparar()
        {
            return "pum PUMMM !! ..";
        }
    }

    //Clase Gatling y su método Disparar
    public class Gatling : IArma
    {
        public string Disparar()
        {
            return "PU PU PU PU PU PU PU PU PU PU PU PU PU PU PU PUPU PU PU PU PU PU PU PU PUUUUMMMM !! ..";
        }
    }
}
