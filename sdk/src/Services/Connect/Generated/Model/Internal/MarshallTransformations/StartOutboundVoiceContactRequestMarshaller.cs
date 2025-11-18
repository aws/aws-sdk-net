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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnswerMachineDetectionConfig())
                {
                    context.Writer.WritePropertyName("AnswerMachineDetectionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnswerMachineDetectionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnswerMachineDetectionConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAttributes())
                {
                    context.Writer.WritePropertyName("Attributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                            context.Writer.Write(publicRequestAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCampaignId())
                {
                    context.Writer.WritePropertyName("CampaignId");
                    context.Writer.Write(publicRequest.CampaignId);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetContactFlowId())
                {
                    context.Writer.WritePropertyName("ContactFlowId");
                    context.Writer.Write(publicRequest.ContactFlowId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDestinationPhoneNumber())
                {
                    context.Writer.WritePropertyName("DestinationPhoneNumber");
                    context.Writer.Write(publicRequest.DestinationPhoneNumber);
                }

                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOutboundStrategy())
                {
                    context.Writer.WritePropertyName("OutboundStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutboundStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutboundStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetQueueId())
                {
                    context.Writer.WritePropertyName("QueueId");
                    context.Writer.Write(publicRequest.QueueId);
                }

                if(publicRequest.IsSetReferences())
                {
                    context.Writer.WritePropertyName("References");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestReferencesKvp in publicRequest.References)
                    {
                        context.Writer.WritePropertyName(publicRequestReferencesKvp.Key);
                        var publicRequestReferencesValue = publicRequestReferencesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ReferenceMarshaller.Instance;
                        marshaller.Marshall(publicRequestReferencesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRelatedContactId())
                {
                    context.Writer.WritePropertyName("RelatedContactId");
                    context.Writer.Write(publicRequest.RelatedContactId);
                }

                if(publicRequest.IsSetRingTimeoutInSeconds())
                {
                    context.Writer.WritePropertyName("RingTimeoutInSeconds");
                    context.Writer.Write(publicRequest.RingTimeoutInSeconds);
                }

                if(publicRequest.IsSetSourcePhoneNumber())
                {
                    context.Writer.WritePropertyName("SourcePhoneNumber");
                    context.Writer.Write(publicRequest.SourcePhoneNumber);
                }

                if(publicRequest.IsSetTrafficType())
                {
                    context.Writer.WritePropertyName("TrafficType");
                    context.Writer.Write(publicRequest.TrafficType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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