using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    internal class Ellipse
    {
        private double _majorRad;
        private double _minorRad;

       public double MajorRad
        {
            get { return _majorRad; }
            set { _majorRad = value; }
        }
     public double MinorRad
        {
            get { return _minorRad; }
            set { _minorRad = value; }    
        }

        public Ellipse()
        {
            MajorRad = 0;
            MinorRad = 0;
        }

        public double Area()
        {
            return Math.PI * _majorRad *_minorRad;
        }

        public double Circumference()
        {
            return Math.PI* ( _majorRad + _minorRad );
        }
    }
}
