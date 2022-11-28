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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Amazon.Runtime;

namespace Amazon.OAM
{
    ///<summary>
    /// Common exception for the OAM service.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class AmazonOAMException : AmazonServiceException
    {
        /// <summary>
        /// Construct instance of AmazonOAMException
        /// </summary>
        /// <param name="message"></param>
        public AmazonOAMException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Construct instance of AmazonOAMException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AmazonOAMException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Construct instance of AmazonOAMException
        /// </summary>
        /// <param name="innerException"></param>
        public AmazonOAMException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Construct instance of AmazonOAMException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AmazonOAMException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct instance of AmazonOAMException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public AmazonOAMException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AmazonOAMException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AmazonOAMException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}