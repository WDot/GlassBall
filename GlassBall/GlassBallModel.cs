using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassBall
{
    class GlassBallModel
    {
        private int radius;
        private R2<int,int> coords;
        private R2<double, double> vector;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public int CoordX
        {
            get { return coords.X1; }
            set { coords.X1 = value; }
        }
        public int CoordY
        {
            get { return coords.X2; }
            set { coords.X2 = value; }
        }

        public double VelocityMagnitude
        {
            get { return vector.X1; }
            set { vector.X1 = value; }
        }
        public double VelocityAngle
        {
            get { return vector.X2; }
            set { vector.X2 = value; }
        }

        public GlassBallModel(int _radius, int _coordX, int _coordY)
        {
            radius = _radius;
            CoordX = _coordX;
            CoordY = _coordY;
            VelocityMagnitude = 0;
            VelocityAngle = 0;
        }
    }
}
