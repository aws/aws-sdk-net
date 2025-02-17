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
    /// SendOutboundEmail Request Marshaller
    /// </summary>       
    public class SendOutboundEmailRequestMarshaller : IMarshaller<IRequest, SendOutboundEmailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendOutboundEmailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendOutboundEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/instance/{InstanceId}/outbound-email";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalRecipients())
                {
                    context.Writer.WritePropertyName("AdditionalRecipients");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutboundAdditionalRecipientsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdditionalRecipients, context);

                    context.Writer.WriteObjectEnd();
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
                if(publicRequest.IsSetDestinationEmailAddress())
                {
                    context.Writer.WritePropertyName("DestinationEmailAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = EmailAddressInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DestinationEmailAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEmailMessage())
                {
                    context.Writer.WritePropertyName("EmailMessage");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutboundEmailContentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EmailMessage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFromEmailAddress())
                {
                    context.Writer.WritePropertyName("FromEmailAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = EmailAddressInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FromEmailAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceCampaign())
                {
                    context.Writer.WritePropertyName("SourceCampaign");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceCampaignMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceCampaign, context);

                    context.Writer.WriteObjectEnd();
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
        private static SendOutboundEmailRequestMarshaller _instance = new SendOutboundEmailRequestMarshaller();        

        internal static SendOutboundEmailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendOutboundEmailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}