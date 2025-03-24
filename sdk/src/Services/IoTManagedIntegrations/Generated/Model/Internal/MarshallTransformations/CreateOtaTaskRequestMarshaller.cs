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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOtaTask Request Marshaller
    /// </summary>       
    public class CreateOtaTaskRequestMarshaller : IMarshaller<IRequest, CreateOtaTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOtaTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOtaTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ota-tasks";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetOtaMechanism())
                {
                    context.Writer.WritePropertyName("OtaMechanism");
                    context.Writer.Write(publicRequest.OtaMechanism);
                }

                if(publicRequest.IsSetOtaSchedulingConfig())
                {
                    context.Writer.WritePropertyName("OtaSchedulingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OtaTaskSchedulingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OtaSchedulingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOtaTargetQueryString())
                {
                    context.Writer.WritePropertyName("OtaTargetQueryString");
                    context.Writer.Write(publicRequest.OtaTargetQueryString);
                }

                if(publicRequest.IsSetOtaTaskExecutionRetryConfig())
                {
                    context.Writer.WritePropertyName("OtaTaskExecutionRetryConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OtaTaskExecutionRetryConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OtaTaskExecutionRetryConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOtaType())
                {
                    context.Writer.WritePropertyName("OtaType");
                    context.Writer.Write(publicRequest.OtaType);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("Protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetS3Url())
                {
                    context.Writer.WritePropertyName("S3Url");
                    context.Writer.Write(publicRequest.S3Url);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("Target");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetListValue in publicRequest.Target)
                    {
                            context.Writer.Write(publicRequestTargetListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTaskConfigurationId())
                {
                    context.Writer.WritePropertyName("TaskConfigurationId");
                    context.Writer.Write(publicRequest.TaskConfigurationId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOtaTaskRequestMarshaller _instance = new CreateOtaTaskRequestMarshaller();        

        internal static CreateOtaTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOtaTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}