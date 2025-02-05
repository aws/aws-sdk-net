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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            if (!publicRequest.IsSetQueueId())
                throw new AmazonDeadlineException("Request object does not have required field QueueId set");
            request.AddPathResource("{queueId}", StringUtils.FromString(publicRequest.QueueId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/queues/{queueId}/jobs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttachments())
            {
                context.Writer.WritePropertyName("attachments");
                context.Writer.WriteStartObject();

                var marshaller = AttachmentsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Attachments, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxFailedTasksCount())
            {
                context.Writer.WritePropertyName("maxFailedTasksCount");
                context.Writer.WriteNumberValue(publicRequest.MaxFailedTasksCount.Value);
            }

            if(publicRequest.IsSetMaxRetriesPerTask())
            {
                context.Writer.WritePropertyName("maxRetriesPerTask");
                context.Writer.WriteNumberValue(publicRequest.MaxRetriesPerTask.Value);
            }

            if(publicRequest.IsSetMaxWorkerCount())
            {
                context.Writer.WritePropertyName("maxWorkerCount");
                context.Writer.WriteNumberValue(publicRequest.MaxWorkerCount.Value);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = JobParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetSourceJobId())
            {
                context.Writer.WritePropertyName("sourceJobId");
                context.Writer.WriteStringValue(publicRequest.SourceJobId);
            }

            if(publicRequest.IsSetStorageProfileId())
            {
                context.Writer.WritePropertyName("storageProfileId");
                context.Writer.WriteStringValue(publicRequest.StorageProfileId);
            }

            if(publicRequest.IsSetTargetTaskRunStatus())
            {
                context.Writer.WritePropertyName("targetTaskRunStatus");
                context.Writer.WriteStringValue(publicRequest.TargetTaskRunStatus);
            }

            if(publicRequest.IsSetTemplate())
            {
                context.Writer.WritePropertyName("template");
                context.Writer.WriteStringValue(publicRequest.Template);
            }

            if(publicRequest.IsSetTemplateType())
            {
                context.Writer.WritePropertyName("templateType");
                context.Writer.WriteStringValue(publicRequest.TemplateType);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }
            
            request.HostPrefix = $"management.";

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