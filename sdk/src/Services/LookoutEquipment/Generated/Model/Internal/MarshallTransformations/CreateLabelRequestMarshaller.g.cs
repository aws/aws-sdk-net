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

using Amazon.LookoutEquipment.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLabel Request Marshaller
    /// </summary>
    public partial class CreateLabelRequestMarshaller : IMarshaller<IRequest, CreateLabelRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLabelRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLabelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutEquipment");
            string target = "AWSLookoutEquipmentFrontendService.CreateLabel";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-15";
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
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.EndTime.Value));
            }
            if (publicRequest.IsSetEquipment())
            {
                context.Writer.WritePropertyName("Equipment");
                context.Writer.WriteStringValue(publicRequest.Equipment);
            }
            if (publicRequest.IsSetFaultCode())
            {
                context.Writer.WritePropertyName("FaultCode");
                context.Writer.WriteStringValue(publicRequest.FaultCode);
            }
            if (publicRequest.IsSetLabelGroupName())
            {
                context.Writer.WritePropertyName("LabelGroupName");
                context.Writer.WriteStringValue(publicRequest.LabelGroupName);
            }
            if (publicRequest.IsSetNotes())
            {
                context.Writer.WritePropertyName("Notes");
                context.Writer.WriteStringValue(publicRequest.Notes);
            }
            if (publicRequest.IsSetRating())
            {
                context.Writer.WritePropertyName("Rating");
                context.Writer.WriteStringValue(publicRequest.Rating);
            }
            if (publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.StartTime.Value));
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateLabelRequestMarshaller _instance = new();

        internal static CreateLabelRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLabelRequestMarshaller Instance => _instance;
    }
}
