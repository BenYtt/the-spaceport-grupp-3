﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpacePark
{
    public interface IPerson
    {
        int PersonID { get; set; }
        string Name { get; set; }
        int SpaceShipID { get; set; }
    }
}