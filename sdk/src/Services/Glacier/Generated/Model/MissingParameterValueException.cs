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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Glacier.Model
{
    ///<summary>
    /// Glacier exception
    /// </summary>
    public class MissingParameterValueException : AmazonGlacierException 
    {
        /// <summary>
        /// Constructs a new MissingParameterValueException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public MissingParameterValueException(string message) 
            : base(message) {}
          
        /// <summary>
        /// Construct instance of MissingParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public MissingParameterValueException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        /// <summary>
        /// Construct instance of MissingParameterValueException
        /// </summary>
        /// <param name="innerException"></param>
        public MissingParameterValueException(Exception innerException) 
            : base(innerException) {}
            
        /// <summary>
        /// Construct instance of MissingParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public MissingParameterValueException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of MissingParameterValueException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public MissingParameterValueException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Gets and sets the Code property.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets and sets the Type property.
        /// </summary>
        public string Type { get; set; }

    }
}