using System;

namespace Amazon.Runtime.Internal
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class AWSSignerTypeAttribute : Attribute
    {
        public AWSSignerTypeAttribute(string signerType) 
        {
            SignerType = signerType;
        }

        public string SignerType { get; }
    }
}
