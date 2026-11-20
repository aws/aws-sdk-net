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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// The input fails to satisfy the constraints specified by the service. Check the <c>reason</c>
    /// field for the constraint that failed.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ValidationException : AmazonMarketplaceDiscoveryException
    {
        /// <summary>
        /// Default constructor for ValidationException
        /// message.
        /// </summary>
        public ValidationException() : base() { }

        /// <summary>
        /// Constructs a new ValidationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ValidationException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        public ValidationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason that the input fails to satisfy the constraints that the Discovery API
        /// specifies. This field has one of the following values:
        /// </para>
        ///  <dl> <dt>INVALID_PAGINATION_TOKEN</dt> <dd> 
        /// <para>
        /// The <c>nextToken</c> value is malformed, expired, or belongs to a different request.
        /// Start the pagination again from the first page.
        /// </para>
        ///  </dd> <dt>MALFORMED_REQUEST_PARAMETERS</dt> <dd> 
        /// <para>
        /// One or more request parameters have an invalid value. Correct the parameters that
        /// you specified, and then resubmit your request.
        /// </para>
        ///  </dd> <dt>PAGINATION_LIMIT_EXCEEDED</dt> <dd> 
        /// <para>
        /// The request asks for results beyond the deepest page that the operation returns. Narrow
        /// your request with filters or a more specific search.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ValidationExceptionReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ValidationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (ValidationExceptionReason)info.GetValue("Reason", typeof(ValidationExceptionReason));
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
            info.AddValue("Reason", this.Reason);
        }
#endif
    }
}
