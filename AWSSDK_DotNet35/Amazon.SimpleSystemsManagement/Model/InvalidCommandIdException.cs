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

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SimpleSystemsManagement.Model
{
    ///<summary>
    /// SimpleSystemsManagement exception
    /// </summary>
    public class InvalidCommandIdException : AmazonSimpleSystemsManagementException 
    {
        /// <summary>
        /// Constructs a new InvalidCommandIdException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidCommandIdException(string message) 
            : base(message) {}
          
        public InvalidCommandIdException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public InvalidCommandIdException(Exception innerException) 
            : base(innerException) {}
            
        public InvalidCommandIdException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        public InvalidCommandIdException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

    }
}