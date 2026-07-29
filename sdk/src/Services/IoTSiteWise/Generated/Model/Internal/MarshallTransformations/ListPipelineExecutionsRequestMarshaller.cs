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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPipelineExecutions Request Marshaller
    /// </summary>       
    public class ListPipelineExecutionsRequestMarshaller : IMarshaller<IRequest, ListPipelineExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPipelineExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPipelineExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetPipelineName())
                throw new AmazonIoTSiteWiseException("Request object does not have required field PipelineName set");
            request.AddPathResource("{pipelineName}", StringUtils.FromString(publicRequest.PipelineName));
            if (!publicRequest.IsSetWorkspaceName())
                throw new AmazonIoTSiteWiseException("Request object does not have required field WorkspaceName set");
            request.AddPathResource("{workspaceName}", StringUtils.FromString(publicRequest.WorkspaceName));
            
            if (publicRequest.IsSetEndTimeAfter())
                request.Parameters.Add("endTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTimeAfter));
            
            if (publicRequest.IsSetEndTimeBefore())
                request.Parameters.Add("endTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTimeBefore));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartTimeAfter())
                request.Parameters.Add("startTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTimeAfter));
            
            if (publicRequest.IsSetStartTimeBefore())
                request.Parameters.Add("startTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTimeBefore));
            
            if (publicRequest.IsSetState())
                request.Parameters.Add("state", StringUtils.FromString(publicRequest.State));
            request.ResourcePath = "/workspaces/{workspaceName}/pipelines/{pipelineName}/executions";
            request.UseQueryString = true;
            
            request.HostPrefix = $"data.";

            return request;
        }
        private static ListPipelineExecutionsRequestMarshaller _instance = new ListPipelineExecutionsRequestMarshaller();        

        internal static ListPipelineExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPipelineExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}