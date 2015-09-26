﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.math {
    class Vector2 {
        public double x { get; private set; }
        public double y { get; private set; }
        
        public Vector2(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public override string ToString() {
            return "(" + this.x + ", " + this.y + ")";
        }
    }
}
