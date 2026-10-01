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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
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
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNotifyCodeConfiguration Request Marshaller
    /// </summary>       
    public class UpdateNotifyCodeConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateNotifyCodeConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNotifyCodeConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNotifyCodeConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetNotifyCodeConfigurationId())
                throw new AmazonEndUserMessagingException("Request object does not have required field NotifyCodeConfigurationId set");
            request.AddPathResource("{notifyCodeConfigurationId+}", StringUtils.FromString(publicRequest.NotifyCodeConfigurationId.TrimStart('/')));
            request.ResourcePath = "/v1/notify-code-configurations/{notifyCodeConfigurationId+}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChannelParameters())
            {
                context.Writer.WritePropertyName("channelParameters");
                context.Writer.WriteStartObject();

                var marshaller = UpdateChannelParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChannelParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCodeConfigurationParameters())
            {
                context.Writer.WritePropertyName("codeConfigurationParameters");
                context.Writer.WriteStartObject();

                var marshaller = UpdateCodeConfigurationParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.CodeConfigurationParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeletionProtectionEnabled())
            {
                context.Writer.WritePropertyName("deletionProtectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtectionEnabled.Value);
            }

            if(publicRequest.IsSetNotifyCodeConfigurationName())
            {
                context.Writer.WritePropertyName("notifyCodeConfigurationName");
                context.Writer.WriteStringValue(publicRequest.NotifyCodeConfigurationName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateNotifyCodeConfigurationRequestMarshaller _instance = new UpdateNotifyCodeConfigurationRequestMarshaller();        

        internal static UpdateNotifyCodeConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNotifyCodeConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}