/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteJobExecution Request Marshaller
    /// </summary>       
    public class DeleteJobExecutionRequestMarshaller : IMarshaller<IRequest, DeleteJobExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteJobExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteJobExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/things/{thingName}/jobs/{jobId}/executionNumber/{executionNumber}";
            if (!publicRequest.IsSetExecutionNumber())
                throw new AmazonIoTException("Request object does not have required field ExecutionNumber set");
            uriResourcePath = uriResourcePath.Replace("{executionNumber}", StringUtils.FromLong(publicRequest.ExecutionNumber));
            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTException("Request object does not have required field JobId set");
            uriResourcePath = uriResourcePath.Replace("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTException("Request object does not have required field ThingName set");
            uriResourcePath = uriResourcePath.Replace("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            
            if (publicRequest.IsSetForce())
                request.Parameters.Add("force", StringUtils.FromBool(publicRequest.Force));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static DeleteJobExecutionRequestMarshaller _instance = new DeleteJobExecutionRequestMarshaller();        

        internal static DeleteJobExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteJobExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}