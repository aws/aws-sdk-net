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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
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
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateScheduledQuery Request Marshaller
    /// </summary>       
    public class CreateScheduledQueryRequestMarshaller : IMarshaller<IRequest, CreateScheduledQueryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScheduledQueryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScheduledQueryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.CreateScheduledQuery";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDestinationConfiguration())
            {
                context.Writer.WritePropertyName("destinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetLogGroupIdentifiers())
            {
                context.Writer.WritePropertyName("logGroupIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLogGroupIdentifiersListValue in publicRequest.LogGroupIdentifiers)
                {
                        context.Writer.WriteStringValue(publicRequestLogGroupIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQueryLanguage())
            {
                context.Writer.WritePropertyName("queryLanguage");
                context.Writer.WriteStringValue(publicRequest.QueryLanguage);
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("queryString");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetScheduleEndTime())
            {
                context.Writer.WritePropertyName("scheduleEndTime");
                context.Writer.WriteNumberValue(publicRequest.ScheduleEndTime.Value);
            }

            if(publicRequest.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("scheduleExpression");
                context.Writer.WriteStringValue(publicRequest.ScheduleExpression);
            }

            if(publicRequest.IsSetScheduleStartTime())
            {
                context.Writer.WritePropertyName("scheduleStartTime");
                context.Writer.WriteNumberValue(publicRequest.ScheduleStartTime.Value);
            }

            if(publicRequest.IsSetStartTimeOffset())
            {
                context.Writer.WritePropertyName("startTimeOffset");
                context.Writer.WriteNumberValue(publicRequest.StartTimeOffset.Value);
            }

            if(publicRequest.IsSetState())
            {
                context.Writer.WritePropertyName("state");
                context.Writer.WriteStringValue(publicRequest.State);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimezone())
            {
                context.Writer.WritePropertyName("timezone");
                context.Writer.WriteStringValue(publicRequest.Timezone);
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
        private static CreateScheduledQueryRequestMarshaller _instance = new CreateScheduledQueryRequestMarshaller();        

        internal static CreateScheduledQueryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScheduledQueryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}