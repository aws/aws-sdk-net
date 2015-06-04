using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.FxCop.Sdk;
using System.Reflection;

namespace CustomFxCopRules
{
    internal sealed class PreventMD5UseRule : SdkCustomRule
    {
        public PreventMD5UseRule()
            : base("PreventMD5UseRule")
        { }

        public override TargetVisibilities TargetVisibility
        {
            get
            {
                return TargetVisibilities.All;
            }
        }

        public override ProblemCollection Check(Member member)
        {
            var method = member as Method;
            CheckMethod(method);

            var field = member as Field;
            CheckField(field);

            var prop = member as PropertyNode;
            CheckProperty(prop);

            return Problems;
        }

        private void CheckProperty(PropertyNode p)
        {
            if (p == null)
                return;

            CheckType(p.Type, p);
        }
        private void CheckField(Field f)
        {
            if (f == null)
                return;

            CheckType(f.Type, f);
        }
        private void CheckMethod(Method method)
        {
            if (method == null || method.Instructions == null || method.Instructions.Count == 0)
                return;

            foreach (var instruction in method.Instructions)
            {
                var invokedMethod = instruction.Value as Method;
                if (invokedMethod != null)
                {
                    var declaringType = invokedMethod.DeclaringType;
                    CheckType(declaringType, method);
                }

                var classNode = instruction.Value as ClassNode;
                if (classNode != null)
                {
                    CheckType(classNode, method);
                }
            }
        }

        public static string MD5Type = "System.Security.Cryptography.MD5";

        private void CheckType(TypeNode type, Member member)
        {
            if (IsAssignableTo(type, MD5Type))
            {
                var resolution = GetResolution(type, member.FullName);
                Problems.Add(new Problem(resolution));
            }
        }
        private bool IsAssignableTo(TypeNode type, string assignableTo)
        {
            if (string.Equals(type.FullName, assignableTo))
                return true;

            var baseType = type.BaseType;
            if (baseType == null)
                return false;

            return IsAssignableTo(baseType, assignableTo);
        }
    }
}
