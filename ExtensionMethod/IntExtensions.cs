using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class IntExtensions
    {
        // We are going to use this extension method on int type.
        //Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
        //Extension methods are additional custom methods which were originally not included with the class.
        //Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
        //The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.
        //Extension methods can be used anywhere in the application by including the namespace of the extension method.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
