using System;

namespace Amazon.Runtime.Internal
{
    [Obsolete("This attribute should not be used as the SDK resolves which signer to use at the request level")]
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
