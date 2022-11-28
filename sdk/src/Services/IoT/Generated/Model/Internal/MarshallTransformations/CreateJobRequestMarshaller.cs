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
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            request.ResourcePath = "/jobs/{jobId}";
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

                if(publicRequest.IsSetDocument())
                {
                    context.Writer.WritePropertyName("document");
                    context.Writer.Write(publicRequest.Document);
                }

                if(publicRequest.IsSetDocumentParameters())
                {
                    context.Writer.WritePropertyName("documentParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDocumentParametersKvp in publicRequest.DocumentParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestDocumentParametersKvp.Key);
                        var publicRequestDocumentParametersValue = publicRequestDocumentParametersKvp.Value;

                            context.Writer.Write(publicRequestDocumentParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDocumentSource())
                {
                    context.Writer.WritePropertyName("documentSource");
                    context.Writer.Write(publicRequest.DocumentSource);
                }

                if(publicRequest.IsSetJobExecutionsRetryConfig())
                {
                    context.Writer.WritePropertyName("jobExecutionsRetryConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobExecutionsRetryConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobExecutionsRetryConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobExecutionsRolloutConfig())
                {
                    context.Writer.WritePropertyName("jobExecutionsRolloutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobExecutionsRolloutConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobExecutionsRolloutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobTemplateArn())
                {
                    context.Writer.WritePropertyName("jobTemplateArn");
                    context.Writer.Write(publicRequest.JobTemplateArn);
                }

                if(publicRequest.IsSetNamespaceId())
                {
                    context.Writer.WritePropertyName("namespaceId");
                    context.Writer.Write(publicRequest.NamespaceId);
                }

                if(publicRequest.IsSetPresignedUrlConfig())
                {
                    context.Writer.WritePropertyName("presignedUrlConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PresignedUrlConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PresignedUrlConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSchedulingConfig())
                {
                    context.Writer.WritePropertyName("schedulingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SchedulingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchedulingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                            context.Writer.Write(publicRequestTargetsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetSelection())
                {
                    context.Writer.WritePropertyName("targetSelection");
                    context.Writer.Write(publicRequest.TargetSelection);
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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}