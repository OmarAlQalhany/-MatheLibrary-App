using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MathLibrary
{


    //*   Base class where the other classes inheirt from//+point vector bases are a fundamental tool in many areas of mathematics and physics, and are essential for understanding and working with vectors in three-dimensional space.
    //<<summary>> // it has the shared characteristic of points and vectors


    public  class PointVectorBase
    {


        //den Wert 10-10   for collinar Methode damit 0,9999999 =1 ist

        public const double Tolerance = 1E-10;
        // X,Y,Z  sie sind meine kooridnaten in the point and Vector no need to DRY 
        // their value  can  be returned or set
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }



        public PointVectorBase(double x = 0, double y = 0, double z = 0)
        {
            X = x; Y = y; Z = z; // meine eigenschaften /objekts XYZ werden auf parameters xyz gesetz 
            // parameter ha7othaly fe Values XYZ tany , dayman m7tag paramet 3shan ystlem

            // eleigenschaften werte  hya el ana badehalo mn el main 



        }

        //* Kopie von die eigenschaften  bekommt ein stift Z.B und kopiert das
        protected PointVectorBase(PointVectorBase sourcePvBase)
        {

            // Bekommt viele vektoren , sollen ein new PointVectorBase objekt(einfach kopie) zurückgeben 
            X = sourcePvBase.X; Y = sourcePvBase.Y; Z = sourcePvBase.Z;
            //Constructer mafehoosh return cuz X = akenha return
        }


        //Calculöate  the distance mn pvB L pvb (Could be a pont or a vector)

        protected double CalculateDistanceTo(PointVectorBase endPvBase)
        {

            //objekt  an dem die methode aufgerufen wird und  (X) - in dem die methode übegeben wird XendPvBAse
            double dis = Math.Sqrt(Math.Pow(X - endPvBase.X, 2) + Math.Pow(Y - endPvBase.Y, 2) + Math.Pow(Z - endPvBase.Z, 2));

            return (dis);



        }


        // calculate the Vectors /* params wenn the parameter is  array, noo3 el parameter beta3y vectors , addends the name of the parameter 
        // addends de elvectors kolha elly gayaly
        protected PointVectorBase CalculateSum(params Vector[] addends)
        {



            //initialising the sum Components and saving it in vaiables  (3 ) 3shan x bettgme3 ma3a x , y ma3a y
            double SumX = 0;
            double SumY = 0;
            double SumZ = 0;





            //hastlem vector v 3ayz agma3o mn Demn addends <parametr>>
            //+=  v.X egma3 el component betaa3 el X beta3 el elvector fe sum X
            foreach (Vector addend in addends)
            {

                SumX += addend.X;
                SumY += addend.Y;
                SumZ += addend.Z;
            }
            return new PointVectorBase(SumX, SumY, SumZ);


        }


        // return it as point
        public Point AsPoint()
        {




            return new Point(X, Y, Z);
        }

        public Vector AsVector()
        {




            return new Vector(X, Y, Z);
        }




        // weil Tostring ist schon im C# muss man überladen  
        //müssen wie es machen  dass Die objekte eigenschaften (wie farbe oder zu gezeigt würden nicht 
        //Console.WriteLine(S1)
        public override string ToString()
        {

            return $"({X},{Y},{Z})";



        }


    }
}
