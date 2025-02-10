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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTJobsDataPlane.Model;
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
namespace Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeJobExecution Request Marshaller
    /// </summary>       
    public class DescribeJobExecutionRequestMarshaller : IMarshaller<IRequest, DescribeJobExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeJobExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeJobExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTJobsDataPlane");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field ThingName set");
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            
            if (publicRequest.IsSetExecutionNumber())
                request.Parameters.Add("executionNumber", StringUtils.FromLong(publicRequest.ExecutionNumber));
            
            if (publicRequest.IsSetIncludeJobDocument())
                request.Parameters.Add("includeJobDocument", StringUtils.FromBool(publicRequest.IncludeJobDocument));
            request.ResourcePath = "/things/{thingName}/jobs/{jobId}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeJobExecutionRequestMarshaller _instance = new DescribeJobExecutionRequestMarshaller();        

        internal static DescribeJobExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}