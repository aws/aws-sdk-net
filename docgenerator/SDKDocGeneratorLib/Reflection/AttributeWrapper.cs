using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace SDKDocGenerator
{
    public class AttributeWrapper : AbstractWrapper
    {
        private CustomAttributeData _data;

        // Lazy + thread-safe so a shared wrapper can be read concurrently during parallel generation.
        private readonly Lazy<string> _name;
        private readonly Lazy<IEnumerable<string>> _arguments;

        public AttributeWrapper(CustomAttributeData data, string docId) : base(docId)
        {
            _data = data;

            _name = new Lazy<string>(() =>
            {
                var attributeLastIndex = _data.AttributeType.Name.LastIndexOf("Attribute", StringComparison.Ordinal);
                return attributeLastIndex != -1
                    ? _data.AttributeType.Name.Substring(0, attributeLastIndex)
                    : _data.AttributeType.Name;
            }, LazyThreadSafetyMode.ExecutionAndPublication);

            _arguments = new Lazy<IEnumerable<string>>(() =>
                _data.ConstructorArguments.Select(argument =>
                {
                    switch (argument.ArgumentType.FullName)
                    {
                        case "System.String":
                            return $"\"{argument.Value}\"";
                        case "System.Boolean":
                            return argument.Value.ToString().ToLower();
                        default:
                            throw new NotImplementedException($"{argument.ArgumentType.FullName} is not implemented");
                    }
                }).ToList(),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public string Name => _name.Value;

        public IEnumerable<string> Arguments => _arguments.Value;
    }
}
