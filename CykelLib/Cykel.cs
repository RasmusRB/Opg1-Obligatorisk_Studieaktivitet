using System;
using System.Collections.Generic;
using System.Text;

namespace CykelLib
{
    public class Cykel
    {
        #region Instance Fields
        private int _id;
        private string _color;
        private double _price;
        private int _gear;
        #endregion

        #region Constructors
        public Cykel(int Id, string Color, double Price, int Gear)
        {
            _id = Id;
            _color = Color;
            _price = Price;
            _gear = Gear;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (value.Length < 1) throw new ArgumentException();
                {
                    _color = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0) throw new ArgumentNullException();
                {
                    _price = value;
                }
            }
        }

        public int Gear
        {
            get { return _gear; }
            set
            {
                if (value <= 3 || value >= 32) throw new ArgumentException();
                {
                    _gear = value;
                }
            }
        }
        #endregion
    }
}
