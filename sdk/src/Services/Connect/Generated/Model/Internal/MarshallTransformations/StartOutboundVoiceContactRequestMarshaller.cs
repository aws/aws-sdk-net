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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartOutboundVoiceContact Request Marshaller
    /// </summary>       
    public class StartOutboundVoiceContactRequestMarshaller : IMarshaller<IRequest, StartOutboundVoiceContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartOutboundVoiceContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartOutboundVoiceContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/contact/outbound-voice";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnswerMachineDetectionConfig())
            {
                context.Writer.WritePropertyName("AnswerMachineDetectionConfig");
                context.Writer.WriteStartObject();

                var marshaller = AnswerMachineDetectionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AnswerMachineDetectionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCampaignId())
            {
                context.Writer.WritePropertyName("CampaignId");
                context.Writer.WriteStringValue(publicRequest.CampaignId);
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
            if(publicRequest.IsSetContactFlowId())
            {
                context.Writer.WritePropertyName("ContactFlowId");
                context.Writer.WriteStringValue(publicRequest.ContactFlowId);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDestinationPhoneNumber())
            {
                context.Writer.WritePropertyName("DestinationPhoneNumber");
                context.Writer.WriteStringValue(publicRequest.DestinationPhoneNumber);
            }

            if(publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQueueId())
            {
                context.Writer.WritePropertyName("QueueId");
                context.Writer.WriteStringValue(publicRequest.QueueId);
            }

            if(publicRequest.IsSetReferences())
            {
                context.Writer.WritePropertyName("References");
                context.Writer.WriteStartObject();
                foreach (var publicRequestReferencesKvp in publicRequest.References)
                {
                    context.Writer.WritePropertyName(publicRequestReferencesKvp.Key);
                    var publicRequestReferencesValue = publicRequestReferencesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestReferencesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRelatedContactId())
            {
                context.Writer.WritePropertyName("RelatedContactId");
                context.Writer.WriteStringValue(publicRequest.RelatedContactId);
            }

            if(publicRequest.IsSetSourcePhoneNumber())
            {
                context.Writer.WritePropertyName("SourcePhoneNumber");
                context.Writer.WriteStringValue(publicRequest.SourcePhoneNumber);
            }

            if(publicRequest.IsSetTrafficType())
            {
                context.Writer.WritePropertyName("TrafficType");
                context.Writer.WriteStringValue(publicRequest.TrafficType);
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
        private static StartOutboundVoiceContactRequestMarshaller _instance = new StartOutboundVoiceContactRequestMarshaller();        

        internal static StartOutboundVoiceContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartOutboundVoiceContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}