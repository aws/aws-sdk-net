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
using System.Net;
using System.Text;

using Amazon.Runtime;

namespace Amazon.SimpleWorkflow
{
    public class AmazonSimpleWorkflowException : AmazonServiceException
    {
        internal AmazonSimpleWorkflowException(string message)
            : base(message)
        {
        }

        internal AmazonSimpleWorkflowException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        internal AmazonSimpleWorkflowException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        internal AmazonSimpleWorkflowException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        internal AmazonSimpleWorkflowException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }
    }
}
