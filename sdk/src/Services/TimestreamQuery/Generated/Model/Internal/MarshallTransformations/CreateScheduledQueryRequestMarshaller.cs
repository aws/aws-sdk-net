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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
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
namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamQuery");
            string target = "Timestream_20181101.CreateScheduledQuery";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-01";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetErrorReportConfiguration())
            {
                context.Writer.WritePropertyName("ErrorReportConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ErrorReportConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ErrorReportConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotificationConfiguration())
            {
                context.Writer.WritePropertyName("NotificationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("QueryString");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetScheduleConfiguration())
            {
                context.Writer.WritePropertyName("ScheduleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScheduleConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduledQueryExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ScheduledQueryExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ScheduledQueryExecutionRoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetConfiguration())
            {
                context.Writer.WritePropertyName("TargetConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TargetConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetConfiguration, context);

                context.Writer.WriteEndObject();
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