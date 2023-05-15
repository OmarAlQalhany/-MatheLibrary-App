using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{



    public class Vector : PointVectorBase
    {

        public static  readonly Vector Zero = new Vector();
        public static readonly Vector One = new Vector(1, 1, 1);
        public static readonly Vector XDir = new Vector(1, 0, 0);
        public static readonly Vector YDir = new Vector(0, 1, 0);
        public static readonly Vector ZDir = new Vector(0, 0, 1);
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            }
        }

        public Vector(double x = 0, double y = 0, double z = 0) : base(x, y, z) { }
        public Vector(Vector sourceVector) : base(sourceVector) { }
        public Vector Add(params Vector[] addends)
        {
            return CalculateSum(addends).AsVector();


        }

        public Vector Subtract(params Vector[] subtrahends)
        {

            double SubX = 0;
            double SubY = 0;
            double SubZ = 0;

            foreach (Vector substrahend in subtrahends)
            {

                SubX -= substrahend.X;
                SubY -= substrahend.Y;
                SubZ -= substrahend.Z;


            }
            // it saves it in a new Vector
            return new Vector(SubX, SubY, SubZ);

        }


        // rakm madrob fe el3 
        public Vector MultiplyScalar(double ScalarFactor)
        {


            double SumMS = ScalarFactor * X + ScalarFactor * Y + ScalarFactor * Z;
            return new Vector(SumMS);



        }

        public Vector CrossProduct(Vector Vector)
        {
            double ReX = this.Y * Vector.Z - this.Z * Vector.Y;
            double ReY = this.Z * Vector.X - this.X * Vector.Z;
            double ReZ = this.X * Vector.Y - this.Y * Vector.X;
            return new Vector(ReX, ReY, ReZ);
        }

        // x ma3a elx y ma3a ely we egma3
        public Vector DotProduct(Vector b)

        {


            double DotP = this.X * b.X + this.Y * b.Y + this.Z * b.Z;
            return new Vector(DotP);



        }


        // normalis is that  you need to divide each of its components by the magnitude (length)
        // u = v/|V|
        public Vector Normalise()

        {

            double Magnitude = Math.Sqrt(X * X + Y * Y + Z * Z);

            double NormalisedX = X / Magnitude;
            double NormalisedY = Z / Magnitude;
            double NormalisedZ = Z / Magnitude;

            return new Vector(NormalisedX, NormalisedY, NormalisedZ);





        }

        //To determine if two vectors are collinear, you can check if they have the same or opposite directions
        // something in common / lins or point on the same line  two  points
        // A, b msalan b-a hydeek ector
        // (factorising )if you pulled out 2 you are left out with same v this is (same Direction)
        // Ab goes to b  ,, Bp comes from b that mesns they are collinear
        //




        //wo lines are collinear if scalar multiplication of two vectors equals absolute value of a multiplication their length
        //(it works in 3D).
        //Simply write a method that calculate scalar multiplication
        public bool AreCollinear(Vector b, double tolerance = PointVectorBase.Tolerance)
        {


            return this.CrossProduct(b).Length <= tolerance;

        }
    }

}



