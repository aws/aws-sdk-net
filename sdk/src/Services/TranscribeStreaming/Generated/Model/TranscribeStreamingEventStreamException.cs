using Amazon.Runtime.EventStreams.Internal;
using System;

namespace Amazon.TranscribeStreaming
{
    /// <summary>
    /// Modeled Exception that either comes over the stream from the service model, or wraps other exceptions for the purpose of raising events. If it is
    /// modelled, it will be a subclass.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class TranscribeStreamingEventStreamException : EventStreamException
    {
        /// <summary>
        /// Creates a new TranscribeStreamingEventStreamException
        /// </summary>
        public TranscribeStreamingEventStreamException()
        {
        }

        /// <summary>
        /// Creates a new TranscribeStreamingEventStreamException
        /// </summary>
        /// <param name="message"></param>

        public TranscribeStreamingEventStreamException(string message) : base (message)
        {
        }

        /// <summary>
        /// Creates a new TranscribeStreamingEventStreamException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public TranscribeStreamingEventStreamException(string message, Exception innerException) : base(message, innerException)
        {
        }
#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the TranscribeStreamingEventStreamException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected TranscribeStreamingEventStreamException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}