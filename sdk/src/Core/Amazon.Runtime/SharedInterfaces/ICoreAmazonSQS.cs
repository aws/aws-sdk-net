using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonSQS is not meant to use directly. It defines SQS with basic .NET types
    /// and allows other services to be able to use SQS as a runtime dependency. This interface
    /// is implemented by the AmazonSQSClient defined in the SQS assembly.
    /// </summary>
    public interface ICoreAmazonSQS
    {
#if BCL
        /// <summary>
        /// Get the attributes for the queue identified by the queue URL.
        /// </summary>
        /// <param name="queueUrl">The queue URL to get attributes for.</param>
        /// <returns>The attributes for the queue.</returns>
        Dictionary<string, string> GetAttributes(string queueUrl);

        /// <summary>
        /// Set the attributes on the queue identified by the queue URL.
        /// </summary>
        /// <param name="queueUrl">The queue URL to set the attributues.</param>
        /// <param name="attributes">The attributes to set.</param>
        void SetAttributes(string queueUrl, Dictionary<string, string> attributes);
#endif
    }
}
