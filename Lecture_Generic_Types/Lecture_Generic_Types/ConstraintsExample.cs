﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Generic_Types
{
    #region Constrain by data type
    class ConstrainedPoint<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public bool EqualsX(T x)
        {
            return this.X.Equals(x);
        }
        public override string ToString()
        {
            return String.Format("Point(x: {0}, y: {1}) ", X, Y);
        }
    }
    #endregion
    #region Constraint by Reference Type
    class ConstrainedClass<T> where T : class
    {
        public T message;
        public ConstrainedClass(T _message)
        {
            this.message = _message;
        }
        public void PrintDetails(T name, T location)
        {
            Console.WriteLine("{0}", message);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);

        }
    }
    #endregion
    #region Constraint by Interface
    interface IAnimal { }
    class Snake : IAnimal { }
    interface IMammal : IAnimal { }
    class Lion : IMammal { }
    class CuteLion : Lion { }
    class ConstrainByInterface<T> where T : IMammal { }

    #endregion

}
