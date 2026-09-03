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
using System.Net;
using System.Text;
using Amazon.Runtime;

namespace Amazon.MarketplaceReporting
{
    ///<summary>
    /// Common exception for the MarketplaceReporting service.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class AmazonMarketplaceReportingException : AmazonServiceException
    {
        /// <summary>
        /// Default constructor for AmazonMarketplaceReportingException
        /// message.
        /// </summary>
        public AmazonMarketplaceReportingException() : base() { }

        /// <summary>
        /// Constructs a new AmazonMarketplaceReportingException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public AmazonMarketplaceReportingException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of AmazonMarketplaceReportingException
        /// </summary>
        public AmazonMarketplaceReportingException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of AmazonMarketplaceReportingException
        /// </summary>
        public AmazonMarketplaceReportingException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of AmazonMarketplaceReportingException
        /// </summary>
        public AmazonMarketplaceReportingException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of AmazonMarketplaceReportingException
        /// </summary>
        public AmazonMarketplaceReportingException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AmazonMarketplaceReportingException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AmazonMarketplaceReportingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
