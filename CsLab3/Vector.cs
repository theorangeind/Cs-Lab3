using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsLab3
{
    class Vector
    {
        public float x, y, z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getLength()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public double getVectorDirCosine(int axis)
        {
            float[] ax = { this.x, this.y, this.z };

            if (this.getLength() == 0) return 0;

            return ax[axis] / this.getLength();
        }

        public void printVectorInfo(TextBox output)
        {
            output.Text += "xCoord: " + this.x + "\r\nyCoord: " + this.y + "\r\nzCoord: " + this.z;
            output.Text += "\r\nLength: " + this.getLength();
            output.Text += "\r\nxDirCos: " + this.getVectorDirCosine(0) + "\r\nyDirCos: " + this.getVectorDirCosine(1) + "\r\nzDirCos: " + this.getVectorDirCosine(2);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static double operator %(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }
    }
}
