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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
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
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePhoneNumber Request Marshaller
    /// </summary>       
    public class UpdatePhoneNumberRequestMarshaller : IMarshaller<IRequest, UpdatePhoneNumberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePhoneNumberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePhoneNumberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.UpdatePhoneNumber";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
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
            if(publicRequest.IsSetDeletionProtectionEnabled())
            {
                context.Writer.WritePropertyName("DeletionProtectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtectionEnabled.Value);
            }

            if(publicRequest.IsSetInternationalSendingEnabled())
            {
                context.Writer.WritePropertyName("InternationalSendingEnabled");
                context.Writer.WriteBooleanValue(publicRequest.InternationalSendingEnabled.Value);
            }

            if(publicRequest.IsSetOptOutListName())
            {
                context.Writer.WritePropertyName("OptOutListName");
                context.Writer.WriteStringValue(publicRequest.OptOutListName);
            }

            if(publicRequest.IsSetPhoneNumberId())
            {
                context.Writer.WritePropertyName("PhoneNumberId");
                context.Writer.WriteStringValue(publicRequest.PhoneNumberId);
            }

            if(publicRequest.IsSetSelfManagedOptOutsEnabled())
            {
                context.Writer.WritePropertyName("SelfManagedOptOutsEnabled");
                context.Writer.WriteBooleanValue(publicRequest.SelfManagedOptOutsEnabled.Value);
            }

            if(publicRequest.IsSetTwoWayChannelArn())
            {
                context.Writer.WritePropertyName("TwoWayChannelArn");
                context.Writer.WriteStringValue(publicRequest.TwoWayChannelArn);
            }

            if(publicRequest.IsSetTwoWayChannelRole())
            {
                context.Writer.WritePropertyName("TwoWayChannelRole");
                context.Writer.WriteStringValue(publicRequest.TwoWayChannelRole);
            }

            if(publicRequest.IsSetTwoWayEnabled())
            {
                context.Writer.WritePropertyName("TwoWayEnabled");
                context.Writer.WriteBooleanValue(publicRequest.TwoWayEnabled.Value);
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
        private static UpdatePhoneNumberRequestMarshaller _instance = new UpdatePhoneNumberRequestMarshaller();        

        internal static UpdatePhoneNumberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePhoneNumberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}