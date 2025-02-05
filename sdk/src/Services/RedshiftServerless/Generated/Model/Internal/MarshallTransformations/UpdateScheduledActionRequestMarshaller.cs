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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
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
namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScheduledAction Request Marshaller
    /// </summary>       
    public class UpdateScheduledActionRequestMarshaller : IMarshaller<IRequest, UpdateScheduledActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScheduledActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScheduledActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftServerless");
            string target = "RedshiftServerless.UpdateScheduledAction";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-21";
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
            if(publicRequest.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.WriteBooleanValue(publicRequest.Enabled.Value);
            }

            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("endTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduledActionDescription())
            {
                context.Writer.WritePropertyName("scheduledActionDescription");
                context.Writer.WriteStringValue(publicRequest.ScheduledActionDescription);
            }

            if(publicRequest.IsSetScheduledActionName())
            {
                context.Writer.WritePropertyName("scheduledActionName");
                context.Writer.WriteStringValue(publicRequest.ScheduledActionName);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            if(publicRequest.IsSetTargetAction())
            {
                context.Writer.WritePropertyName("targetAction");
                context.Writer.WriteStartObject();

                var marshaller = TargetActionMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetAction, context);

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
        private static UpdateScheduledActionRequestMarshaller _instance = new UpdateScheduledActionRequestMarshaller();        

        internal static UpdateScheduledActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScheduledActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}