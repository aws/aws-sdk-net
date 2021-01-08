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
using ThirdParty.Json.LitJson;

namespace Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJobExecution Request Marshaller
    /// </summary>       
    public class UpdateJobExecutionRequestMarshaller : IMarshaller<IRequest, UpdateJobExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTJobsDataPlane");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-29";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field ThingName set");
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            request.ResourcePath = "/things/{thingName}/jobs/{jobId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExecutionNumber())
                {
                    context.Writer.WritePropertyName("executionNumber");
                    context.Writer.Write(publicRequest.ExecutionNumber);
                }

                if(publicRequest.IsSetExpectedVersion())
                {
                    context.Writer.WritePropertyName("expectedVersion");
                    context.Writer.Write(publicRequest.ExpectedVersion);
                }

                if(publicRequest.IsSetIncludeJobDocument())
                {
                    context.Writer.WritePropertyName("includeJobDocument");
                    context.Writer.Write(publicRequest.IncludeJobDocument);
                }

                if(publicRequest.IsSetIncludeJobExecutionState())
                {
                    context.Writer.WritePropertyName("includeJobExecutionState");
                    context.Writer.Write(publicRequest.IncludeJobExecutionState);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetStatusDetails())
                {
                    context.Writer.WritePropertyName("statusDetails");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestStatusDetailsKvp in publicRequest.StatusDetails)
                    {
                        context.Writer.WritePropertyName(publicRequestStatusDetailsKvp.Key);
                        var publicRequestStatusDetailsValue = publicRequestStatusDetailsKvp.Value;

                            context.Writer.Write(publicRequestStatusDetailsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStepTimeoutInMinutes())
                {
                    context.Writer.WritePropertyName("stepTimeoutInMinutes");
                    context.Writer.Write(publicRequest.StepTimeoutInMinutes);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateJobExecutionRequestMarshaller _instance = new UpdateJobExecutionRequestMarshaller();        

        internal static UpdateJobExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}