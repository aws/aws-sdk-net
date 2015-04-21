using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator.Syntax
{
    public class CSharpSyntaxGenerator
    {
        FrameworkVersion _version;

        public CSharpSyntaxGenerator(FrameworkVersion version)
        {
            this._version = version;
        }

        public string GenerateSyntax(TypeWrapper type)
        {
            var syntax = new SyntaxWriter(this._version);

            if (type.IsPublic)
                syntax.WriteToken("public");

            if (type.IsEnum)
            {
                syntax.WriteToken("enum");
                syntax.WriteTypeName(type);
            }
            else
            {
                if (type.IsSealed)
                    syntax.WriteToken("sealed");
                if (type.IsAbstract)
                    syntax.WriteToken("abstract");
                if (type.IsStatic)
                    syntax.WriteToken("static");

                if (type.IsClass)
                    syntax.WriteToken("class");
                else if (type.IsInterface)
                    syntax.WriteToken("interface");
                else if (type.IsValueType)
                    syntax.WriteToken("struct");

                syntax.WriteTypeName(type);

                var baseType = type.BaseType;
                if (baseType != null)
                {
                    syntax.WriteRaw(" :");
                    syntax.WriteTypeName(baseType);
                }

                var interfaces = type.GetInterfaces();
                if (interfaces.Count > 0)
                {
                    syntax.WriteNewLineWithTab();

                    syntax.BeginCommaDelimitedList();
                    foreach (var face in interfaces.OrderBy(x => x.Name))
                    {
                        syntax.WriteTypeName(face);
                    }
                    syntax.EndCommaDelimitedList();
                }
            }

            return syntax.CurrentSyntax;
        }

        public string GenerateSyntax(PropertyInfoWrapper info)
        {
            var syntax = new SyntaxWriter(this._version);

            if (info.IsPublic)
                syntax.WriteToken("public");

            syntax.WriteTypeName(info.PropertyType);

            string methods = null;
            var getMethod = info.GetGetMethod();
            var setMethod = info.GetSetMethod();
            if (getMethod != null && getMethod.IsPublic && setMethod != null && setMethod.IsPublic)
                methods = "get; set;";
            else if (getMethod != null && getMethod.IsPublic)
                methods = "get;";
            else if (setMethod != null && setMethod.IsPublic)
                methods = "set;";

            syntax.WriteRaw(string.Format(" {0} {{", info.Name));
            syntax.WriteToken(methods);
            syntax.WriteRaw(" }");

            return syntax.CurrentSyntax;
        }

        public string GenerateSyntax(MethodInfoWrapper info)
        {
            var syntax = new SyntaxWriter(this._version);

            if (info.IsPublic)
                syntax.WriteToken("public");

            if (info.IsAbstract)
                syntax.WriteToken("abstract");

            if (info.IsVirtual)
                syntax.WriteToken("virtual");

            syntax.WriteTypeName(info.ReturnType);

            syntax.WriteRaw(" " + info.Name);
            var parameters = info.GetParameters();
            AddParameters(syntax, parameters);

            return syntax.CurrentSyntax;
        }

        public string GenerateSyntax(ConstructorInfoWrapper info)
        {
            var syntax = new SyntaxWriter(this._version);

            if (info.IsPublic)
                syntax.WriteToken("public");

            syntax.WriteTypeName(info.DeclaringType);


            var parameters = info.GetParameters();
            AddParameters(syntax, parameters);

            return syntax.CurrentSyntax;
        }

        public string GenerateSyntax(FieldInfoWrapper info)
        {
            var syntax = new SyntaxWriter(this._version);

            if (info.IsPublic)
                syntax.WriteToken("public");

            if (info.IsStatic)
                syntax.WriteToken("static");

            if (info.IsInitOnly)
                syntax.WriteToken("readonly");

            if (info.IsLiteral)
                syntax.WriteToken("const");

            syntax.WriteTypeName(info.FieldType);
            syntax.WriteRaw(" " + info.Name);

            return syntax.CurrentSyntax;
        }

        public string GenerateSyntax(EventInfoWrapper info)
        {
            var syntax = new SyntaxWriter(this._version);

            syntax.WriteToken("public");
            syntax.WriteToken("event");

            syntax.WriteRaw(string.Format(" {0}EventHandler {0}", info.Name));

            return syntax.CurrentSyntax;
        }

        private void AddParameters(SyntaxWriter syntax, IList<ParameterInfoWrapper> parameters)
        {
            syntax.WriteRaw("(");
            if (parameters.Count != 0)
            {
                // Used to track if need a trailing comma
                bool isFirstParameter = true;
                foreach (var parameter in parameters)
                {
                    if (!isFirstParameter)
                        syntax.WriteRaw(",");

                    syntax.WriteNewLineWithTab();
                    syntax.WriteTypeName(parameter.ParameterType);
                    syntax.WriteRaw(" " + parameter.Name);
                    isFirstParameter = false;
                }

                syntax.WriteRaw("\n");
            }

            syntax.WriteRaw(")");
        }
    }
}
