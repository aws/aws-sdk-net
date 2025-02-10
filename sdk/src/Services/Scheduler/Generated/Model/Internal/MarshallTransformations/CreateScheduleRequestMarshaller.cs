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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Scheduler.Model;
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
namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSchedule Request Marshaller
    /// </summary>       
    public class CreateScheduleRequestMarshaller : IMarshaller<IRequest, CreateScheduleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScheduleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScheduleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Scheduler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonSchedulerException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/schedules/{Name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionAfterCompletion())
            {
                context.Writer.WritePropertyName("ActionAfterCompletion");
                context.Writer.WriteStringValue(publicRequest.ActionAfterCompletion);
            }

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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEndDate())
            {
                context.Writer.WritePropertyName("EndDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndDate.Value)));
            }

            if(publicRequest.IsSetFlexibleTimeWindow())
            {
                context.Writer.WritePropertyName("FlexibleTimeWindow");
                context.Writer.WriteStartObject();

                var marshaller = FlexibleTimeWindowMarshaller.Instance;
                marshaller.Marshall(publicRequest.FlexibleTimeWindow, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGroupName())
            {
                context.Writer.WritePropertyName("GroupName");
                context.Writer.WriteStringValue(publicRequest.GroupName);
            }

            if(publicRequest.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.KmsKeyArn);
            }

            if(publicRequest.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(publicRequest.ScheduleExpression);
            }

            if(publicRequest.IsSetScheduleExpressionTimezone())
            {
                context.Writer.WritePropertyName("ScheduleExpressionTimezone");
                context.Writer.WriteStringValue(publicRequest.ScheduleExpressionTimezone);
            }

            if(publicRequest.IsSetStartDate())
            {
                context.Writer.WritePropertyName("StartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartDate.Value)));
            }

            if(publicRequest.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(publicRequest.State);
            }

            if(publicRequest.IsSetTarget())
            {
                context.Writer.WritePropertyName("Target");
                context.Writer.WriteStartObject();

                var marshaller = TargetMarshaller.Instance;
                marshaller.Marshall(publicRequest.Target, context);

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
        private static CreateScheduleRequestMarshaller _instance = new CreateScheduleRequestMarshaller();        

        internal static CreateScheduleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScheduleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}