﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SyMath;
using System.ComponentModel;

namespace Circuit
{
    /// <summary>
    /// Ground component, V = 0.
    /// </summary>
    [Category("Standard")]
    [DisplayName("Ground")]
    public class Ground : OneTerminal
    {
        public Ground() { Name = "GND1"; }

        public override void Analyze(Analysis Mna)
        {
            // Nodes connected to ground have V = 0.
            Mna.AddEquation(Terminal.V, 0);
            // Ground doesn't care about current.
            Mna.AddTerminal(Terminal, null);
        }

        public override void LayoutSymbol(SymbolLayout Sym)
        {
            base.LayoutSymbol(Sym);

            Sym.AddLoop(EdgeType.Black,
                new Coord(-10, 0),
                new Coord(10, 0),
                new Coord(0, -10));
        }
    }
}
