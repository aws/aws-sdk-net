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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitJob Request Marshaller
    /// </summary>       
    public class SubmitJobRequestMarshaller : IMarshaller<IRequest, SubmitJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/submitjob";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArrayProperties())
                {
                    context.Writer.WritePropertyName("arrayProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = ArrayPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ArrayProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetContainerOverrides())
                {
                    context.Writer.WritePropertyName("containerOverrides");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContainerOverridesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContainerOverrides, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDependsOn())
                {
                    context.Writer.WritePropertyName("dependsOn");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDependsOnListValue in publicRequest.DependsOn)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = JobDependencyMarshaller.Instance;
                        marshaller.Marshall(publicRequestDependsOnListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobDefinition())
                {
                    context.Writer.WritePropertyName("jobDefinition");
                    context.Writer.Write(publicRequest.JobDefinition);
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("jobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetJobQueue())
                {
                    context.Writer.WritePropertyName("jobQueue");
                    context.Writer.Write(publicRequest.JobQueue);
                }

                if(publicRequest.IsSetNodeOverrides())
                {
                    context.Writer.WritePropertyName("nodeOverrides");
                    context.Writer.WriteObjectStart();

                    var marshaller = NodeOverridesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NodeOverrides, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                            context.Writer.Write(publicRequestParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPropagateTags())
                {
                    context.Writer.WritePropertyName("propagateTags");
                    context.Writer.Write(publicRequest.PropagateTags);
                }

                if(publicRequest.IsSetRetryStrategy())
                {
                    context.Writer.WritePropertyName("retryStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetryStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetryStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("timeout");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobTimeoutMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Timeout, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SubmitJobRequestMarshaller _instance = new SubmitJobRequestMarshaller();        

        internal static SubmitJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}