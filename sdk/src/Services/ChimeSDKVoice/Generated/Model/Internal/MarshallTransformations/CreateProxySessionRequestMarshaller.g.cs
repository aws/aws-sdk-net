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

using Amazon.ChimeSDKVoice.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProxySession Request Marshaller
    /// </summary>
    public partial class CreateProxySessionRequestMarshaller : IMarshaller<IRequest, CreateProxySessionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProxySessionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProxySessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetVoiceConnectorId())
            {
                throw new AmazonChimeSDKVoiceException("Request object does not have required field VoiceConnectorId set");
            }
            request.AddPathResource("{VoiceConnectorId}", StringUtils.FromString(publicRequest.VoiceConnectorId));

            request.ResourcePath = "/voice-connectors/{VoiceConnectorId}/proxy-sessions";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                {
                    context.Writer.WriteStringValue(publicRequestCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetExpiryMinutes())
            {
                context.Writer.WritePropertyName("ExpiryMinutes");
                context.Writer.WriteNumberValue(publicRequest.ExpiryMinutes.Value);
            }
            if (publicRequest.IsSetGeoMatchLevel())
            {
                context.Writer.WritePropertyName("GeoMatchLevel");
                context.Writer.WriteStringValue(publicRequest.GeoMatchLevel);
            }
            if (publicRequest.IsSetGeoMatchParams())
            {
                context.Writer.WritePropertyName("GeoMatchParams");
                context.Writer.WriteStartObject();

                var marshaller = GeoMatchParamsMarshaller.Instance;
                marshaller.Marshall(publicRequest.GeoMatchParams, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetNumberSelectionBehavior())
            {
                context.Writer.WritePropertyName("NumberSelectionBehavior");
                context.Writer.WriteStringValue(publicRequest.NumberSelectionBehavior);
            }
            if (publicRequest.IsSetParticipantPhoneNumbers())
            {
                context.Writer.WritePropertyName("ParticipantPhoneNumbers");
                context.Writer.WriteStartArray();
                foreach (var publicRequestParticipantPhoneNumbersListValue in publicRequest.ParticipantPhoneNumbers)
                {
                    context.Writer.WriteStringValue(publicRequestParticipantPhoneNumbersListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateProxySessionRequestMarshaller _instance = new();

        internal static CreateProxySessionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProxySessionRequestMarshaller Instance => _instance;
    }
}
