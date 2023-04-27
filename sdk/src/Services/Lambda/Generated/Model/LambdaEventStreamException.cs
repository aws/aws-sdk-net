using Amazon.Runtime.EventStreams.Internal;
using System;

namespace Amazon.Lambda
{
#if !PCL && !CORECLR
    [Serializable]
#endif
    public class LambdaEventStreamException : EventStreamException
    {
        public LambdaEventStreamException()
        {
        }

        public LambdaEventStreamException(string message) : base (message)
        {
        }
        public LambdaEventStreamException(string message, Exception innerException) : base(message, innerException)
        {
        }
#if NETSTANDARD
        protected LambdaEventStreamException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
        }
#endif

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the LambdaEventStreamException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected LambdaEventStreamException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}