using Microsoft.FxCop.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFxCopRules
{
    internal sealed class PreventStaticLoggersRule : SdkCustomRule
    {
        public PreventStaticLoggersRule()
            : base("PreventStaticLoggersRule")
        { }

        public override TargetVisibilities TargetVisibility
        {
            get
            {
                return TargetVisibilities.All;
            }
        }

        public static string LoggerInterfaceFullName = "Amazon.Runtime.Internal.Util.ILogger";

        public override ProblemCollection Check(Member member)
        {
            var field = member as Field;
            if (field != null && field.IsStatic)
                CheckStatic(field.DeclaringType, field.Type);

            var property = member as PropertyNode;
            // check only properties that are static AND have a setter
            // static read-only properties (for instance, ones that call GetLogger)
            // are allowed
            if (property != null && property.IsStatic && property.Setter != null)
                CheckStatic(property.DeclaringType, property.Type);

            return Problems;
        }

        private void CheckStatic(TypeNode containerType, TypeNode typeOfStatic)
        {
            if (ImplementsILogger(typeOfStatic))
            {
                var resolution = GetResolution(containerType, typeOfStatic, LoggerInterfaceFullName);
                Problems.Add(new Problem(resolution));
            }
        }
        private bool ImplementsILogger(TypeNode tn)
        {
            if (tn == null)
                return false;

            // check if type is ILogger
            if (IsILogger(tn.FullName))
                return true;

            // check if type implements ILogger
            var interfaces = tn.Interfaces;
            var implementsInterface = interfaces.Any(i => IsILogger(i.FullName));
            if (implementsInterface)
                return true;

            // check base class
            if (ImplementsILogger(tn.BaseType))
                return true;

            return false;
        }
        private bool IsILogger(string fullName)
        {
            return string.Equals(fullName, LoggerInterfaceFullName, StringComparison.Ordinal);
        }
    }
}
