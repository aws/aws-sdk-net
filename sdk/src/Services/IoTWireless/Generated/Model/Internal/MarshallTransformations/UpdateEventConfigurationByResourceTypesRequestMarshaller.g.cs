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

using Amazon.IoTWireless.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventConfigurationByResourceTypes Request Marshaller
    /// </summary>
    public partial class UpdateEventConfigurationByResourceTypesRequestMarshaller : IMarshaller<IRequest, UpdateEventConfigurationByResourceTypesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventConfigurationByResourceTypesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateEventConfigurationByResourceTypesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/event-configurations-resource-types";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetConnectionStatus())
            {
                context.Writer.WritePropertyName("ConnectionStatus");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionStatusResourceTypeEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConnectionStatus, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDeviceRegistrationState())
            {
                context.Writer.WritePropertyName("DeviceRegistrationState");
                context.Writer.WriteStartObject();

                var marshaller = DeviceRegistrationStateResourceTypeEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceRegistrationState, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetJoin())
            {
                context.Writer.WritePropertyName("Join");
                context.Writer.WriteStartObject();

                var marshaller = JoinResourceTypeEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Join, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMessageDeliveryStatus())
            {
                context.Writer.WritePropertyName("MessageDeliveryStatus");
                context.Writer.WriteStartObject();

                var marshaller = MessageDeliveryStatusResourceTypeEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MessageDeliveryStatus, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetProximity())
            {
                context.Writer.WritePropertyName("Proximity");
                context.Writer.WriteStartObject();

                var marshaller = ProximityResourceTypeEventConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Proximity, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateEventConfigurationByResourceTypesRequestMarshaller _instance = new();

        internal static UpdateEventConfigurationByResourceTypesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateEventConfigurationByResourceTypesRequestMarshaller Instance => _instance;
    }
}
