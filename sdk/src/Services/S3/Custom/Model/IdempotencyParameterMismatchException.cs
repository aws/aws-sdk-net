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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The request includes a client token value that was used for a previous request, but at least one of the request parameters is different from 
    /// the previous request that used that client token.
    /// </summary>
    /// <remarks>
    /// This exception is specific to operations that use idempotency tokens, such as the RenameObject operation.
    /// When you receive this exception, it means you're attempting to retry an operation with the same client token but with different parameters,
    /// which violates the idempotency guarantee.
    /// </remarks>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class IdempotencyParameterMismatchException : AmazonS3Exception
    {
        /// <summary>
        /// Constructs a new IdempotencyParameterMismatchException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public IdempotencyParameterMismatchException(string message)
            : base(message) { }

        /// <summary>
        /// Construct instance of IdempotencyParameterMismatchException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public IdempotencyParameterMismatchException(string message, Exception innerException)
            : base(message, innerException) { }

        /// <summary>
        /// Construct instance of IdempotencyParameterMismatchException
        /// </summary>
        /// <param name="innerException"></param>
        public IdempotencyParameterMismatchException(Exception innerException)
            : base(innerException) { }

        /// <summary>
        /// Construct instance of IdempotencyParameterMismatchException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public IdempotencyParameterMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of IdempotencyParameterMismatchException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public IdempotencyParameterMismatchException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of IdempotencyParameterMismatchException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        /// <param name="amazonId2"></param>
        /// <param name="amazonCfId"></param>
        public IdempotencyParameterMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string amazonId2, string amazonCfId)
            : base(message, innerException, errorType, errorCode, requestId, statusCode, amazonId2, amazonCfId) { }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the IdempotencyParameterMismatchException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected IdempotencyParameterMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
#endif
    }
}