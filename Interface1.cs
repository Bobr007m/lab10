﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public interface IInit
    {
        void Init();
        void RandomInit();
    }

    // Реализация интерфейса в классах
    public class GeometricFigure : IInit
    {
        // Реализация методов Init() и RandomInit() уже есть в классе
    }
}
