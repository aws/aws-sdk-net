using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime.Internal.Auth
{
    public class SignatureException : Exception
    {
        internal SignatureException(string message)
            : base(message)
        {
        }

        internal SignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
