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
    /// UpdateJobQueue Request Marshaller
    /// </summary>       
    public class UpdateJobQueueRequestMarshaller : IMarshaller<IRequest, UpdateJobQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/updatejobqueue";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeEnvironmentOrder())
                {
                    context.Writer.WritePropertyName("computeEnvironmentOrder");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestComputeEnvironmentOrderListValue in publicRequest.ComputeEnvironmentOrder)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ComputeEnvironmentOrderMarshaller.Instance;
                        marshaller.Marshall(publicRequestComputeEnvironmentOrderListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobQueue())
                {
                    context.Writer.WritePropertyName("jobQueue");
                    context.Writer.Write(publicRequest.JobQueue);
                }

                if(publicRequest.IsSetJobStateTimeLimitActions())
                {
                    context.Writer.WritePropertyName("jobStateTimeLimitActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestJobStateTimeLimitActionsListValue in publicRequest.JobStateTimeLimitActions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = JobStateTimeLimitActionMarshaller.Instance;
                        marshaller.Marshall(publicRequestJobStateTimeLimitActionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetSchedulingPolicyArn())
                {
                    context.Writer.WritePropertyName("schedulingPolicyArn");
                    context.Writer.Write(publicRequest.SchedulingPolicyArn);
                }

                if(publicRequest.IsSetServiceEnvironmentOrder())
                {
                    context.Writer.WritePropertyName("serviceEnvironmentOrder");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestServiceEnvironmentOrderListValue in publicRequest.ServiceEnvironmentOrder)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ServiceEnvironmentOrderMarshaller.Instance;
                        marshaller.Marshall(publicRequestServiceEnvironmentOrderListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.Write(publicRequest.State);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateJobQueueRequestMarshaller _instance = new UpdateJobQueueRequestMarshaller();        

        internal static UpdateJobQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}