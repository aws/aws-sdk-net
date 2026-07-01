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
    /// SendOutboundWebNotification Request Marshaller
    /// </summary>       
    public class SendOutboundWebNotificationRequestMarshaller : IMarshaller<IRequest, SendOutboundWebNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendOutboundWebNotificationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendOutboundWebNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/instance/{InstanceId}/outbound-web-notification";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBrowserId())
            {
                context.Writer.WritePropertyName("BrowserId");
                context.Writer.WriteStringValue(publicRequest.BrowserId);
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
            if(publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStartObject();

                var marshaller = WebNotificationContentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Content, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartObject();

                var marshaller = WidgetDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExpiresAt())
            {
                context.Writer.WritePropertyName("ExpiresAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ExpiresAt.Value)));
            }

            if(publicRequest.IsSetSessionId())
            {
                context.Writer.WritePropertyName("SessionId");
                context.Writer.WriteStringValue(publicRequest.SessionId);
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStartObject();

                var marshaller = WebNotificationSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static SendOutboundWebNotificationRequestMarshaller _instance = new SendOutboundWebNotificationRequestMarshaller();        

        internal static SendOutboundWebNotificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendOutboundWebNotificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}