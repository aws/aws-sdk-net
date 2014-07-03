/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    /// ElasticMapReduce exception
    /// </summary>
    public class InternalServerErrorException : AmazonElasticMapReduceException 
    {
        /// <summary>
        /// Constructs a new InternalServerErrorException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InternalServerErrorException(string message) 
            : base(message) {}
          
        public InternalServerErrorException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public InternalServerErrorException(Exception innerException) 
            : base(innerException) {}
            
        public InternalServerErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        public InternalServerErrorException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

    }
}