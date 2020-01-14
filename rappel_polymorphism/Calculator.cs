using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_rappel_polymorphism
{
    /// <summary>
    /// Exemple de polymorphisme ad hoc
    /// </summary>
    public class Calculator
    {
        #region Polymorphisme Ad hoc

        public int Add (int x, int y) => x + y;      
        public string Add(string A, string B) => A + B;

        #endregion
    }
}
