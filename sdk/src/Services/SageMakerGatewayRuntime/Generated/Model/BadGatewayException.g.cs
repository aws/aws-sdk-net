/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SageMakerGatewayRuntime.Model
{
    /// <summary>
    /// 502 -- The gateway could not get a usable response from the inference gateway. The
    /// `Message` prefix says why: * `Global Inference Gateway: could not reach the inference
    /// gateway: &lt;reason&gt;` -- the request could not be sent, or the connection closed
    /// before a response arrived (for example, the connection failed, or the inference gateway
    /// closed it after reading the request). * `Global Inference Gateway: timed out waiting
    /// for the inference gateway` -- on the buffered operation, the inference gateway stopped
    /// sending partway through the response body and the gateway's read timeout expired.
    /// (The same text on a GatewayTimeoutException means no response arrived.) * Any other
    /// `Global Inference Gateway: ` message -- the gateway ended a response before it was
    /// complete, for example because it exceeded the 10 MiB limit of the buffered operation,
    /// the request exceeded its maximum duration, or the inference gateway was taken out
    /// of service. * `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference
    /// gateway serving the model returned a 502, 500, 503 or another 5xx error. Its status
    /// code is in the message (the response status is 502), and up to 256 bytes of its error
    /// message are quoted. * `inference gateway: response ended unexpectedly` -- the inference
    /// gateway's connection failed while it was sending the response. The inference gateway
    /// names a component in the prefix when it reports one: `inference gateway (&lt;component&gt;):
    /// `, where the component is `config` (the inference gateway's configuration and proxy
    /// layer), `scheduler` (its request scheduler), `model selector` (its model selector)
    /// or `model server` (the model server). Not modeled as retryable: a 502 can mean the
    /// inference already ran, and the gateway may already have tried another inference gateway.
    /// Standard SDK retry modes may still retry a 5xx status, which would run (and bill)
    /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class BadGatewayException : AmazonSageMakerGatewayRuntimeException
    {
        /// <summary>
        /// Default constructor for BadGatewayException
        /// message.
        /// </summary>
        public BadGatewayException() : base() { }

        /// <summary>
        /// Constructs a new BadGatewayException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public BadGatewayException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of BadGatewayException
        /// </summary>
        public BadGatewayException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of BadGatewayException
        /// </summary>
        public BadGatewayException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of BadGatewayException
        /// </summary>
        public BadGatewayException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of BadGatewayException
        /// </summary>
        public BadGatewayException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the BadGatewayException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected BadGatewayException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
#endif
    }
}
