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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProtectConfigurationCountryRuleSet Request Marshaller
    /// </summary>       
    public class UpdateProtectConfigurationCountryRuleSetRequestMarshaller : IMarshaller<IRequest, UpdateProtectConfigurationCountryRuleSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProtectConfigurationCountryRuleSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProtectConfigurationCountryRuleSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.UpdateProtectConfigurationCountryRuleSet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCountryRuleSetUpdates())
                {
                    context.Writer.WritePropertyName("CountryRuleSetUpdates");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestCountryRuleSetUpdatesKvp in publicRequest.CountryRuleSetUpdates)
                    {
                        context.Writer.WritePropertyName(publicRequestCountryRuleSetUpdatesKvp.Key);
                        var publicRequestCountryRuleSetUpdatesValue = publicRequestCountryRuleSetUpdatesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ProtectConfigurationCountryRuleSetInformationMarshaller.Instance;
                        marshaller.Marshall(publicRequestCountryRuleSetUpdatesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNumberCapability())
                {
                    context.Writer.WritePropertyName("NumberCapability");
                    context.Writer.Write(publicRequest.NumberCapability);
                }

                if(publicRequest.IsSetProtectConfigurationId())
                {
                    context.Writer.WritePropertyName("ProtectConfigurationId");
                    context.Writer.Write(publicRequest.ProtectConfigurationId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProtectConfigurationCountryRuleSetRequestMarshaller _instance = new UpdateProtectConfigurationCountryRuleSetRequestMarshaller();        

        internal static UpdateProtectConfigurationCountryRuleSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProtectConfigurationCountryRuleSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}