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

namespace Amazon.Runtime.Internal
{
    public class ErrorResponse
    {
        private ErrorType type;
        private string 
            code, message, requestId;

        /// <summary>
        /// Error type, one of Sender, Receiver, Unknown
        /// Only applies to XML-based services.
        /// </summary>
        public ErrorType Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Name of the exception class to return
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        /// <summary>
        /// RequestId of the error.
        /// Only applies to XML-based services.
        /// </summary>
        public string RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
    }
}
