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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
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
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBatchJobExecutions Request Marshaller
    /// </summary>       
    public class ListBatchJobExecutionsRequestMarshaller : IMarshaller<IRequest, ListBatchJobExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBatchJobExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBatchJobExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MainframeModernization");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-28";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonMainframeModernizationException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            
            if (publicRequest.IsSetExecutionIds())
                request.ParameterCollection.Add("executionIds", publicRequest.ExecutionIds);
            
            if (publicRequest.IsSetJobName())
                request.Parameters.Add("jobName", StringUtils.FromString(publicRequest.JobName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartedAfter())
                request.Parameters.Add("startedAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartedAfter));
            
            if (publicRequest.IsSetStartedBefore())
                request.Parameters.Add("startedBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartedBefore));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            request.ResourcePath = "/applications/{applicationId}/batch-job-executions";
            request.UseQueryString = true;

            return request;
        }
        private static ListBatchJobExecutionsRequestMarshaller _instance = new ListBatchJobExecutionsRequestMarshaller();        

        internal static ListBatchJobExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBatchJobExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}