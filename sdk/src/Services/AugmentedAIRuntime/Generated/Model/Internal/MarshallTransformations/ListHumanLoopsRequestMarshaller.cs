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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AugmentedAIRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.AugmentedAIRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListHumanLoops Request Marshaller
    /// </summary>       
    public class ListHumanLoopsRequestMarshaller : IMarshaller<IRequest, ListHumanLoopsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHumanLoopsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListHumanLoopsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AugmentedAIRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-07";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCreationTimeAfter())
                request.Parameters.Add("CreationTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeAfter));
            
            if (publicRequest.IsSetCreationTimeBefore())
                request.Parameters.Add("CreationTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeBefore));
            
            if (publicRequest.IsSetFlowDefinitionArn())
                request.Parameters.Add("FlowDefinitionArn", StringUtils.FromString(publicRequest.FlowDefinitionArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSortOrder())
                request.Parameters.Add("SortOrder", StringUtils.FromString(publicRequest.SortOrder));
            request.ResourcePath = "/human-loops";
            request.UseQueryString = true;

            return request;
        }
        private static ListHumanLoopsRequestMarshaller _instance = new ListHumanLoopsRequestMarshaller();        

        internal static ListHumanLoopsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListHumanLoopsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}