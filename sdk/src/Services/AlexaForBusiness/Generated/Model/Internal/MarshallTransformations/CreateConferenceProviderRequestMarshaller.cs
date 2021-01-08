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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConferenceProvider Request Marshaller
    /// </summary>       
    public class CreateConferenceProviderRequestMarshaller : IMarshaller<IRequest, CreateConferenceProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConferenceProviderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConferenceProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AlexaForBusiness");
            string target = "AlexaForBusiness.CreateConferenceProvider";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-09";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetConferenceProviderName())
                {
                    context.Writer.WritePropertyName("ConferenceProviderName");
                    context.Writer.Write(publicRequest.ConferenceProviderName);
                }

                if(publicRequest.IsSetConferenceProviderType())
                {
                    context.Writer.WritePropertyName("ConferenceProviderType");
                    context.Writer.Write(publicRequest.ConferenceProviderType);
                }

                if(publicRequest.IsSetIPDialIn())
                {
                    context.Writer.WritePropertyName("IPDialIn");
                    context.Writer.WriteObjectStart();

                    var marshaller = IPDialInMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IPDialIn, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMeetingSetting())
                {
                    context.Writer.WritePropertyName("MeetingSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = MeetingSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MeetingSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPSTNDialIn())
                {
                    context.Writer.WritePropertyName("PSTNDialIn");
                    context.Writer.WriteObjectStart();

                    var marshaller = PSTNDialInMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PSTNDialIn, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateConferenceProviderRequestMarshaller _instance = new CreateConferenceProviderRequestMarshaller();        

        internal static CreateConferenceProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConferenceProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}