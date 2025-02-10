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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupportApp.Model;
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
namespace Amazon.SupportApp.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSlackChannelConfiguration Request Marshaller
    /// </summary>       
    public class CreateSlackChannelConfigurationRequestMarshaller : IMarshaller<IRequest, CreateSlackChannelConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSlackChannelConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSlackChannelConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupportApp");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/control/create-slack-channel-configuration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChannelId())
            {
                context.Writer.WritePropertyName("channelId");
                context.Writer.WriteStringValue(publicRequest.ChannelId);
            }

            if(publicRequest.IsSetChannelName())
            {
                context.Writer.WritePropertyName("channelName");
                context.Writer.WriteStringValue(publicRequest.ChannelName);
            }

            if(publicRequest.IsSetChannelRoleArn())
            {
                context.Writer.WritePropertyName("channelRoleArn");
                context.Writer.WriteStringValue(publicRequest.ChannelRoleArn);
            }

            if(publicRequest.IsSetNotifyOnAddCorrespondenceToCase())
            {
                context.Writer.WritePropertyName("notifyOnAddCorrespondenceToCase");
                context.Writer.WriteBooleanValue(publicRequest.NotifyOnAddCorrespondenceToCase.Value);
            }

            if(publicRequest.IsSetNotifyOnCaseSeverity())
            {
                context.Writer.WritePropertyName("notifyOnCaseSeverity");
                context.Writer.WriteStringValue(publicRequest.NotifyOnCaseSeverity);
            }

            if(publicRequest.IsSetNotifyOnCreateOrReopenCase())
            {
                context.Writer.WritePropertyName("notifyOnCreateOrReopenCase");
                context.Writer.WriteBooleanValue(publicRequest.NotifyOnCreateOrReopenCase.Value);
            }

            if(publicRequest.IsSetNotifyOnResolveCase())
            {
                context.Writer.WritePropertyName("notifyOnResolveCase");
                context.Writer.WriteBooleanValue(publicRequest.NotifyOnResolveCase.Value);
            }

            if(publicRequest.IsSetTeamId())
            {
                context.Writer.WritePropertyName("teamId");
                context.Writer.WriteStringValue(publicRequest.TeamId);
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
        private static CreateSlackChannelConfigurationRequestMarshaller _instance = new CreateSlackChannelConfigurationRequestMarshaller();        

        internal static CreateSlackChannelConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSlackChannelConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}