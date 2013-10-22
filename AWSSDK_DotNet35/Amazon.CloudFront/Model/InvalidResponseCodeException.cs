/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
using Amazon.Runtime;

namespace Amazon.CloudFront.Model
{
    ///<summary>
    /// AmazonCloudFront exception
    /// </summary>
    public class InvalidResponseCodeException : AmazonCloudFrontException 
    {
        /// <summary>
        /// Constructs a new InvalidResponseCodeException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        internal InvalidResponseCodeException(string message) 
            : base(message) {}
          
        internal InvalidResponseCodeException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        internal InvalidResponseCodeException(Exception innerException) 
            : base(innerException) {}
            
        internal InvalidResponseCodeException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        internal InvalidResponseCodeException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

        
    }
}
