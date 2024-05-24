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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartUpdateSignalMap Request Marshaller
    /// </summary>       
    public class StartUpdateSignalMapRequestMarshaller : IMarshaller<IRequest, StartUpdateSignalMapRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartUpdateSignalMapRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartUpdateSignalMapRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonMediaLiveException("Request object does not have required field Identifier set");
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/prod/signal-maps/{identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCloudWatchAlarmTemplateGroupIdentifiers())
                {
                    context.Writer.WritePropertyName("cloudWatchAlarmTemplateGroupIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCloudWatchAlarmTemplateGroupIdentifiersListValue in publicRequest.CloudWatchAlarmTemplateGroupIdentifiers)
                    {
                            context.Writer.Write(publicRequestCloudWatchAlarmTemplateGroupIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDiscoveryEntryPointArn())
                {
                    context.Writer.WritePropertyName("discoveryEntryPointArn");
                    context.Writer.Write(publicRequest.DiscoveryEntryPointArn);
                }

                if(publicRequest.IsSetEventBridgeRuleTemplateGroupIdentifiers())
                {
                    context.Writer.WritePropertyName("eventBridgeRuleTemplateGroupIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEventBridgeRuleTemplateGroupIdentifiersListValue in publicRequest.EventBridgeRuleTemplateGroupIdentifiers)
                    {
                            context.Writer.Write(publicRequestEventBridgeRuleTemplateGroupIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetForceRediscovery())
                {
                    context.Writer.WritePropertyName("forceRediscovery");
                    context.Writer.Write(publicRequest.ForceRediscovery);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartUpdateSignalMapRequestMarshaller _instance = new StartUpdateSignalMapRequestMarshaller();        

        internal static StartUpdateSignalMapRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartUpdateSignalMapRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}