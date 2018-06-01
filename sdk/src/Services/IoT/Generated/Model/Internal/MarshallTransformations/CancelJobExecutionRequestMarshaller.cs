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
    /// CancelJobExecution Request Marshaller
    /// </summary>       
    public class CancelJobExecutionRequestMarshaller : IMarshaller<IRequest, CancelJobExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CancelJobExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CancelJobExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/things/{thingName}/jobs/{jobId}/cancel";
            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTException("Request object does not have required field JobId set");
            uriResourcePath = uriResourcePath.Replace("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTException("Request object does not have required field ThingName set");
            uriResourcePath = uriResourcePath.Replace("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            
            if (publicRequest.IsSetForce())
                request.Parameters.Add("force", StringUtils.FromBool(publicRequest.Force));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExpectedVersion())
                {
                    context.Writer.WritePropertyName("expectedVersion");
                    context.Writer.Write(publicRequest.ExpectedVersion);
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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static CancelJobExecutionRequestMarshaller _instance = new CancelJobExecutionRequestMarshaller();        

        internal static CancelJobExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CancelJobExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}