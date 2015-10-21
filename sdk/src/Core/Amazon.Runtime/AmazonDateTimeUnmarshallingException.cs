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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// This exception is thrown when there is a parse error on the response back from AWS.
    /// </summary>
    public class AmazonDateTimeUnmarshallingException : AmazonUnmarshallingException
    {
        #region Public properties
        /// <summary>
        /// The string value which could not be converted into a valid DateTime instance.
        /// </summary>
        public string InvalidDateTimeToken { get; private set; }
        #endregion

        #region Constructors

        public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string invalidDateTimeToken,Exception innerException)
            : base(requestId, lastKnownLocation, innerException)
        {
            this.InvalidDateTimeToken = invalidDateTimeToken;
        }

        public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken,Exception innerException)
            : base(requestId, lastKnownLocation, responseBody, innerException)
        {
            this.InvalidDateTimeToken = invalidDateTimeToken;
        }

        public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, 
            string responseBody, string invalidDateTimeToken,string message, Exception innerException)
            : base(requestId, lastKnownLocation, 
            responseBody, message, innerException)
        {
            this.InvalidDateTimeToken = invalidDateTimeToken;
        }

        #endregion
    }
}
