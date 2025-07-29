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

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitServiceJob Request Marshaller
    /// </summary>       
    public class SubmitServiceJobRequestMarshaller : IMarshaller<IRequest, SubmitServiceJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitServiceJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitServiceJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/submitservicejob";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
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

                if(publicRequest.IsSetRetryStrategy())
                {
                    context.Writer.WritePropertyName("retryStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceJobRetryStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetryStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSchedulingPriority())
                {
                    context.Writer.WritePropertyName("schedulingPriority");
                    context.Writer.Write(publicRequest.SchedulingPriority);
                }

                if(publicRequest.IsSetServiceJobType())
                {
                    context.Writer.WritePropertyName("serviceJobType");
                    context.Writer.Write(publicRequest.ServiceJobType);
                }

                if(publicRequest.IsSetServiceRequestPayload())
                {
                    context.Writer.WritePropertyName("serviceRequestPayload");
                    context.Writer.Write(publicRequest.ServiceRequestPayload);
                }

                if(publicRequest.IsSetShareIdentifier())
                {
                    context.Writer.WritePropertyName("shareIdentifier");
                    context.Writer.Write(publicRequest.ShareIdentifier);
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

                if(publicRequest.IsSetTimeoutConfig())
                {
                    context.Writer.WritePropertyName("timeoutConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceJobTimeoutMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeoutConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SubmitServiceJobRequestMarshaller _instance = new SubmitServiceJobRequestMarshaller();        

        internal static SubmitServiceJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitServiceJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}