﻿using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Dominio.Contrato.WF
{
    public interface IEliminarPersonaWF
    {
        bool ejecutar(string persona);
    }
}
