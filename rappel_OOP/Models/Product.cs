using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace wpf_rappel_OOP
{
    /// <summary>
    /// Classe qui représente les produits de l'application
    /// </summary>
    class Product
    {
        /// <summary>
        /// Prochain identifiant disponible.
        /// Question : Que signifie le mot clé "static"?
        /// </summary>
        static int nextId;

        /// <summary>
        /// Question : Que fait le get; private set?
        /// </summary>
        public int ProductId { get; private set; }
        public Product()
        {
            /// Interlocked permet de modifier les valeurs
            /// d'une propriété de manière Thread Safe
            ProductId = Interlocked.Increment(ref nextId);
        }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Universal produt code
        /// </summary>
        public string UPC { get; set; }

    }
}
