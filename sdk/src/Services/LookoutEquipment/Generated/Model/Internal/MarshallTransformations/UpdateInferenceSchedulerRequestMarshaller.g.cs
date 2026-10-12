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
    /// UpdateInferenceScheduler Request Marshaller
    /// </summary>
    public partial class UpdateInferenceSchedulerRequestMarshaller : IMarshaller<IRequest, UpdateInferenceSchedulerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInferenceSchedulerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateInferenceSchedulerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutEquipment");
            string target = "AWSLookoutEquipmentFrontendService.UpdateInferenceScheduler";
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
            if (publicRequest.IsSetDataDelayOffsetInMinutes())
            {
                context.Writer.WritePropertyName("DataDelayOffsetInMinutes");
                context.Writer.WriteNumberValue(publicRequest.DataDelayOffsetInMinutes.Value);
            }
            if (publicRequest.IsSetDataInputConfiguration())
            {
                context.Writer.WritePropertyName("DataInputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InferenceInputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataInputConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDataOutputConfiguration())
            {
                context.Writer.WritePropertyName("DataOutputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InferenceOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataOutputConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDataUploadFrequency())
            {
                context.Writer.WritePropertyName("DataUploadFrequency");
                context.Writer.WriteStringValue(publicRequest.DataUploadFrequency);
            }
            if (publicRequest.IsSetInferenceSchedulerName())
            {
                context.Writer.WritePropertyName("InferenceSchedulerName");
                context.Writer.WriteStringValue(publicRequest.InferenceSchedulerName);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateInferenceSchedulerRequestMarshaller _instance = new();

        internal static UpdateInferenceSchedulerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateInferenceSchedulerRequestMarshaller Instance => _instance;
    }
}
