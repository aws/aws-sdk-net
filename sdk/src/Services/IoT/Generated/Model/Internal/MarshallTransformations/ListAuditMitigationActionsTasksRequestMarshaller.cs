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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAuditMitigationActionsTasks Request Marshaller
    /// </summary>       
    public class ListAuditMitigationActionsTasksRequestMarshaller : IMarshaller<IRequest, ListAuditMitigationActionsTasksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAuditMitigationActionsTasksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAuditMitigationActionsTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAuditTaskId())
                request.Parameters.Add("auditTaskId", StringUtils.FromString(publicRequest.AuditTaskId));
            
            if (publicRequest.IsSetEndTime())
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            
            if (publicRequest.IsSetFindingId())
                request.Parameters.Add("findingId", StringUtils.FromString(publicRequest.FindingId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartTime())
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            
            if (publicRequest.IsSetTaskStatus())
                request.Parameters.Add("taskStatus", StringUtils.FromString(publicRequest.TaskStatus));
            request.ResourcePath = "/audit/mitigationactions/tasks";
            request.UseQueryString = true;

            return request;
        }
        private static ListAuditMitigationActionsTasksRequestMarshaller _instance = new ListAuditMitigationActionsTasksRequestMarshaller();        

        internal static ListAuditMitigationActionsTasksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAuditMitigationActionsTasksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}