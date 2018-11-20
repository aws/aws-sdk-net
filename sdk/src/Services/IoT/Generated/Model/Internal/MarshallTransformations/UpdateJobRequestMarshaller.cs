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
    /// UpdateJob Request Marshaller
    /// </summary>       
    public class UpdateJobRequestMarshaller : IMarshaller<IRequest, UpdateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/jobs/{jobId}";
            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTException("Request object does not have required field JobId set");
            uriResourcePath = uriResourcePath.Replace("{jobId}", StringUtils.FromStringWithSlashEncoding(publicRequest.JobId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAbortConfig())
                {
                    context.Writer.WritePropertyName("abortConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AbortConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AbortConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetJobExecutionsRolloutConfig())
                {
                    context.Writer.WritePropertyName("jobExecutionsRolloutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobExecutionsRolloutConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobExecutionsRolloutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPresignedUrlConfig())
                {
                    context.Writer.WritePropertyName("presignedUrlConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PresignedUrlConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PresignedUrlConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeoutConfig())
                {
                    context.Writer.WritePropertyName("timeoutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeoutConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeoutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateJobRequestMarshaller _instance = new UpdateJobRequestMarshaller();        

        internal static UpdateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}