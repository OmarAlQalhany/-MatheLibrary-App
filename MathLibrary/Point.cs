
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{


    //inheit from the PointVectorBase
    public class Point : PointVectorBase
    {
        //die ursprung Point braucht ein werte
        public static readonly Point Origin = new Point(0,0,0);


        //this constructer should inheite from my PointVEctorBAse Construructe
        //bases constructer soll verwendet base bentuze von die basis klasse 

        public Point(double x = 0, double y = 0, double z = 0) : base(x, y, z) { }

        // the point instance to be copied
        //: base(x, y, z): This is the constructor initializer, which calls the base class constructor with the specified arguments x, y, and z. It is used when the Point class inherits from another class,
        //ewretgh men el base elly elConstructer betaa3o leeh parameter wa7ed we estlmoo feh source Point
        public Point(Point sourcePoint) : base(sourcePoint) { }

        // take it from the method Calculate Distance TOelly 3amltaha
        public double DistanceTo(Point endPoint)
        {
            return CalculateDistanceTo(endPoint);
        }
        //Take it from PointVectorBase  but Zou need a new point take it from new Point
        public Point Add(params Vector[] addends)
        {
            return CalculateSum(addends).AsPoint();


        }




    }
    //{










    // me noo3 point cause it share the Point properties 

















}






//p

//        // creat instance of the class 
//        public readonly static Point Origin = new Point();


//        /// <summary>
//        /// wa in klammern dann es entscheidetnwelches objetk
//        /// </summary>


//        public Point(double x = 0, double y = 0, double z = 0) {

//           X = x;
//            Y = y;
//                Z = z;
//        }
//        // Constructer is a method to initialise value when objekt created  3shan generalizierung
//        // called automatically 

//        public Point(Point sourcePoint) {
//            x
//            
//            //kopieren  
//            // to be copied 
//            //warum sinvoll kopieren x} das man  wenn änderung machen wirll dann machet r keine änderung nan originale eigenschaften von objekt 
//            //This constructor is particularly useful when you want to create a new Point object that has the same property values as an existing Point object
//            X = sourcePoint.X;
//            Y = sourcePoint.Y;
//            Z = sourcePoint.Z;

//            // parameter
//            ///
//            // betb3t alrgument mn el main , beyro7 lelmthod betghyer feh  we betstkhdem elparameter fe elmethod

//            /* Default parameter ama teddeh value f elparameter , fa hateegy tenday 3al dala we tseeb elparamter
//             * () fady haydeek el defalt daah , masalan (String name = "Ahmed " ) aw momeken  argumenz as int x=70
//             * Motaghyer
//             * Law Hanb3t argument as variable to the parameter and we want that the value of the varibles also
//             * get chaged we put before the parameter ref and before the variblae ref 
//             * Multible parametr f2 mslan , fel Arguments lazem tedeelo etnen we mn nafs noo3 elparameter elly 
//             * 3arfnaah fel parameter Named arguments eltarteeeb mosh mohm bs 

//             * 
//             * 
//             * 
//             */
//            // tmrer byanat llemthod momken ykoon Qema aw mot8yer, (, tefsel paramet )












//        } 


//        public double DistanceTo(Point endPoint) {

//            return CaculateDis

//        ^sourcePointX : end point 
//        }
//        public Point Add(params Vector[] addends)
//        {
//            // array aus vector addieren , params wenn viele parameter Inside the method,
//            // the input vectors are added together using vector addition, and the resulting vector is added to the current Point object to produce a new Point object with the updated coordinates.
//        }





//        // gibt fehler da es kein kosntrukter gibtr
//        // public read only
//        // soll kordinaten ursprung sein 0.0.0
//        // Unterstrich >> static hängt an klasse 

//    }
//      }
//}
