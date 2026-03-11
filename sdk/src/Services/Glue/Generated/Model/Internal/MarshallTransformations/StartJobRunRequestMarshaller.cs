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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartJobRun Request Marshaller
    /// </summary>       
    public class StartJobRunRequestMarshaller : IMarshaller<IRequest, StartJobRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartJobRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartJobRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.StartJobRun";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllocatedCapacity())
            {
                context.Writer.WritePropertyName("AllocatedCapacity");
                context.Writer.WriteNumberValue(publicRequest.AllocatedCapacity.Value);
            }

            if(publicRequest.IsSetArguments())
            {
                context.Writer.WritePropertyName("Arguments");
                context.Writer.WriteStartObject();
                foreach (var publicRequestArgumentsKvp in publicRequest.Arguments)
                {
                    context.Writer.WritePropertyName(publicRequestArgumentsKvp.Key);
                    var publicRequestArgumentsValue = publicRequestArgumentsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestArgumentsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionClass())
            {
                context.Writer.WritePropertyName("ExecutionClass");
                context.Writer.WriteStringValue(publicRequest.ExecutionClass);
            }

            if(publicRequest.IsSetExecutionRoleSessionPolicy())
            {
                context.Writer.WritePropertyName("ExecutionRoleSessionPolicy");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleSessionPolicy);
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetJobRunId())
            {
                context.Writer.WritePropertyName("JobRunId");
                context.Writer.WriteStringValue(publicRequest.JobRunId);
            }

            if(publicRequest.IsSetJobRunQueuingEnabled())
            {
                context.Writer.WritePropertyName("JobRunQueuingEnabled");
                context.Writer.WriteBooleanValue(publicRequest.JobRunQueuingEnabled.Value);
            }

            if(publicRequest.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.MaxCapacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.MaxCapacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.MaxCapacity.Value);
                }
            }

            if(publicRequest.IsSetNotificationProperty())
            {
                context.Writer.WritePropertyName("NotificationProperty");
                context.Writer.WriteStartObject();

                var marshaller = NotificationPropertyMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationProperty, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }

            if(publicRequest.IsSetSecurityConfiguration())
            {
                context.Writer.WritePropertyName("SecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.SecurityConfiguration);
            }

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
            }

            if(publicRequest.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("WorkerType");
                context.Writer.WriteStringValue(publicRequest.WorkerType);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static StartJobRunRequestMarshaller _instance = new StartJobRunRequestMarshaller();        

        internal static StartJobRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartJobRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}