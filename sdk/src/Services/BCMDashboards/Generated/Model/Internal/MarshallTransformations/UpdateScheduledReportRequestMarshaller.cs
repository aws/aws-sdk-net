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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDashboards.Model;
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
namespace Amazon.BCMDashboards.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScheduledReport Request Marshaller
    /// </summary>       
    public class UpdateScheduledReportRequestMarshaller : IMarshaller<IRequest, UpdateScheduledReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScheduledReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScheduledReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BCMDashboards");
            string target = "AWSBCMDashboardsService.UpdateScheduledReport";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-08-18";
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
            if(publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }

            if(publicRequest.IsSetClearWidgetDateRangeOverride())
            {
                context.Writer.WritePropertyName("clearWidgetDateRangeOverride");
                context.Writer.WriteBooleanValue(publicRequest.ClearWidgetDateRangeOverride.Value);
            }

            if(publicRequest.IsSetClearWidgetIds())
            {
                context.Writer.WritePropertyName("clearWidgetIds");
                context.Writer.WriteBooleanValue(publicRequest.ClearWidgetIds.Value);
            }

            if(publicRequest.IsSetDashboardArn())
            {
                context.Writer.WritePropertyName("dashboardArn");
                context.Writer.WriteStringValue(publicRequest.DashboardArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetScheduleConfig())
            {
                context.Writer.WritePropertyName("scheduleConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScheduleConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduledReportExecutionRoleArn())
            {
                context.Writer.WritePropertyName("scheduledReportExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ScheduledReportExecutionRoleArn);
            }

            if(publicRequest.IsSetWidgetDateRangeOverride())
            {
                context.Writer.WritePropertyName("widgetDateRangeOverride");
                context.Writer.WriteStartObject();

                var marshaller = DateTimeRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.WidgetDateRangeOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWidgetIds())
            {
                context.Writer.WritePropertyName("widgetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWidgetIdsListValue in publicRequest.WidgetIds)
                {
                        context.Writer.WriteStringValue(publicRequestWidgetIdsListValue);
                }
                context.Writer.WriteEndArray();
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
        private static UpdateScheduledReportRequestMarshaller _instance = new UpdateScheduledReportRequestMarshaller();        

        internal static UpdateScheduledReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScheduledReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}