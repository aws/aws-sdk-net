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
    /// DisassociatePhoneNumbersFromVoiceConnectorGroup Request Marshaller
    /// </summary>
    public partial class DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller : IMarshaller<IRequest, DisassociatePhoneNumbersFromVoiceConnectorGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociatePhoneNumbersFromVoiceConnectorGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetVoiceConnectorGroupId())
            {
                throw new AmazonChimeSDKVoiceException("Request object does not have required field VoiceConnectorGroupId set");
            }
            request.AddPathResource("{VoiceConnectorGroupId}", StringUtils.FromString(publicRequest.VoiceConnectorGroupId));

            request.AddSubResource("operation", "disassociate-phone-numbers");
            request.ResourcePath = "/voice-connector-groups/{VoiceConnectorGroupId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetE164PhoneNumbers())
            {
                context.Writer.WritePropertyName("E164PhoneNumbers");
                context.Writer.WriteStartArray();
                foreach (var publicRequestE164PhoneNumbersListValue in publicRequest.E164PhoneNumbers)
                {
                    context.Writer.WriteStringValue(publicRequestE164PhoneNumbersListValue);
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

        private static readonly DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller _instance = new();

        internal static DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller Instance => _instance;
    }
}
