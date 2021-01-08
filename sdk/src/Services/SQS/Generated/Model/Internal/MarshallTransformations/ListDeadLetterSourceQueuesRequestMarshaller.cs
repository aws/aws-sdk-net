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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDeadLetterSourceQueues Request Marshaller
    /// </summary>       
    public class ListDeadLetterSourceQueuesRequestMarshaller : IMarshaller<IRequest, ListDeadLetterSourceQueuesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDeadLetterSourceQueuesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDeadLetterSourceQueuesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "ListDeadLetterSourceQueues");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetQueueUrl())
                {
                    request.Parameters.Add("QueueUrl", StringUtils.FromString(publicRequest.QueueUrl));
                }
            }
            return request;
        }
                    private static ListDeadLetterSourceQueuesRequestMarshaller _instance = new ListDeadLetterSourceQueuesRequestMarshaller();        

        internal static ListDeadLetterSourceQueuesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDeadLetterSourceQueuesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}