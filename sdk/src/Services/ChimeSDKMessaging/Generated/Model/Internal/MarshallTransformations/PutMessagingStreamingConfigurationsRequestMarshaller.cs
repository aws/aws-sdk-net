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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMessagingStreamingConfigurations Request Marshaller
    /// </summary>       
    public class PutMessagingStreamingConfigurationsRequestMarshaller : IMarshaller<IRequest, PutMessagingStreamingConfigurationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMessagingStreamingConfigurationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMessagingStreamingConfigurationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAppInstanceArn())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field AppInstanceArn set");
            request.AddPathResource("{appInstanceArn}", StringUtils.FromString(publicRequest.AppInstanceArn));
            request.ResourcePath = "/app-instances/{appInstanceArn}/streaming-configurations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetStreamingConfigurations())
                {
                    context.Writer.WritePropertyName("StreamingConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStreamingConfigurationsListValue in publicRequest.StreamingConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StreamingConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestStreamingConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutMessagingStreamingConfigurationsRequestMarshaller _instance = new PutMessagingStreamingConfigurationsRequestMarshaller();        

        internal static PutMessagingStreamingConfigurationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMessagingStreamingConfigurationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}