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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.SimpleSystemsManagement.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMaintenanceWindow Request Marshaller
    /// </summary>
    public partial class UpdateMaintenanceWindowRequestMarshaller : IMarshaller<IRequest, UpdateMaintenanceWindowRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMaintenanceWindowRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateMaintenanceWindowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdateMaintenanceWindow";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllowUnassociatedTargets())
            {
                context.Writer.WritePropertyName("AllowUnassociatedTargets");
                context.Writer.WriteBooleanValue(publicRequest.AllowUnassociatedTargets.Value);
            }
            if (publicRequest.IsSetCutoff())
            {
                context.Writer.WritePropertyName("Cutoff");
                context.Writer.WriteNumberValue(publicRequest.Cutoff.Value);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDuration())
            {
                context.Writer.WritePropertyName("Duration");
                context.Writer.WriteNumberValue(publicRequest.Duration.Value);
            }
            if (publicRequest.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(publicRequest.Enabled.Value);
            }
            if (publicRequest.IsSetEndDate())
            {
                context.Writer.WritePropertyName("EndDate");
                context.Writer.WriteStringValue(publicRequest.EndDate);
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetReplace())
            {
                context.Writer.WritePropertyName("Replace");
                context.Writer.WriteBooleanValue(publicRequest.Replace.Value);
            }
            if (publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStringValue(publicRequest.Schedule);
            }
            if (publicRequest.IsSetScheduleOffset())
            {
                context.Writer.WritePropertyName("ScheduleOffset");
                context.Writer.WriteNumberValue(publicRequest.ScheduleOffset.Value);
            }
            if (publicRequest.IsSetScheduleTimezone())
            {
                context.Writer.WritePropertyName("ScheduleTimezone");
                context.Writer.WriteStringValue(publicRequest.ScheduleTimezone);
            }
            if (publicRequest.IsSetStartDate())
            {
                context.Writer.WritePropertyName("StartDate");
                context.Writer.WriteStringValue(publicRequest.StartDate);
            }
            if (publicRequest.IsSetWindowId())
            {
                context.Writer.WritePropertyName("WindowId");
                context.Writer.WriteStringValue(publicRequest.WindowId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateMaintenanceWindowRequestMarshaller _instance = new();

        internal static UpdateMaintenanceWindowRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateMaintenanceWindowRequestMarshaller Instance => _instance;
    }
}
