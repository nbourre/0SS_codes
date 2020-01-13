using System;
using System.Collections.Generic;
using System.Text;

namespace rappel_members.Models
{
    class Rectangle
    {
        /// <summary>
        /// Exemple d'attributs privés
        /// Les attributs sont privés par défaut
        /// </summary>
        double _area;
        double _width;
        double _height;

        /// <summary>
        /// Exemple de propriétés en lecture-écriture
        /// </summary>
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// Exemple de propriété en lecture-écriture
        /// avec action
        /// </summary>
        public double Width {
            get => _width;
            set
            {
                _width = value;
                _area = _width * _height;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                _area = _width * _height;
            }
        }

        /// <summary>
        /// Exemple de propriété en lecture seulement
        /// </summary>
        public double Area => _area;

    }
}
