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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTask Request Marshaller
    /// </summary>       
    public class GetTaskRequestMarshaller : IMarshaller<IRequest, GetTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            if (!publicRequest.IsSetJobId())
                throw new AmazonDeadlineException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetQueueId())
                throw new AmazonDeadlineException("Request object does not have required field QueueId set");
            request.AddPathResource("{queueId}", StringUtils.FromString(publicRequest.QueueId));
            if (!publicRequest.IsSetStepId())
                throw new AmazonDeadlineException("Request object does not have required field StepId set");
            request.AddPathResource("{stepId}", StringUtils.FromString(publicRequest.StepId));
            if (!publicRequest.IsSetTaskId())
                throw new AmazonDeadlineException("Request object does not have required field TaskId set");
            request.AddPathResource("{taskId}", StringUtils.FromString(publicRequest.TaskId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/queues/{queueId}/jobs/{jobId}/steps/{stepId}/tasks/{taskId}";
            
            request.HostPrefix = $"management.";

            return request;
        }
        private static GetTaskRequestMarshaller _instance = new GetTaskRequestMarshaller();        

        internal static GetTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}