/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticLoadBalancing
{
    public class AmazonElasticLoadBalancingException : AmazonServiceException
    {
        internal AmazonElasticLoadBalancingException(string message)
            : base(message)
        {
        }

        internal AmazonElasticLoadBalancingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        internal AmazonElasticLoadBalancingException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        internal AmazonElasticLoadBalancingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        internal AmazonElasticLoadBalancingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }
    }
}
