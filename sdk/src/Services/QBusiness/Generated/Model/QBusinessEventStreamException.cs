using Amazon.Runtime.EventStreams.Internal;
using System;

namespace Amazon.QBusiness
{
    /// <summary>
    /// Modeled Exception that either comes over the stream from the service model, or wraps other exceptions for the purpose of raising events. If it is
    /// modelled, it will be a subclass.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class QBusinessEventStreamException : EventStreamException
    {
        /// <summary>
        /// Creates a new QBusinessEventStreamException
        /// </summary>
        public QBusinessEventStreamException()
        {
        }

        /// <summary>
        /// Creates a new QBusinessEventStreamException
        /// </summary>
        /// <param name="message"></param>

        public QBusinessEventStreamException(string message) : base (message)
        {
        }

        /// <summary>
        /// Creates a new QBusinessEventStreamException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public QBusinessEventStreamException(string message, Exception innerException) : base(message, innerException)
        {
        }
#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the QBusinessEventStreamException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected QBusinessEventStreamException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}