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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
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
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutOriginEndpointPolicy Request Marshaller
    /// </summary>       
    public class PutOriginEndpointPolicyRequestMarshaller : IMarshaller<IRequest, PutOriginEndpointPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutOriginEndpointPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutOriginEndpointPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelGroupName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelGroupName set");
            request.AddPathResource("{ChannelGroupName}", StringUtils.FromString(publicRequest.ChannelGroupName));
            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelName set");
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));
            if (!publicRequest.IsSetOriginEndpointName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field OriginEndpointName set");
            request.AddPathResource("{OriginEndpointName}", StringUtils.FromString(publicRequest.OriginEndpointName));
            request.ResourcePath = "/channelGroup/{ChannelGroupName}/channel/{ChannelName}/originEndpoint/{OriginEndpointName}/policy";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCdnAuthConfiguration())
            {
                context.Writer.WritePropertyName("CdnAuthConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CdnAuthConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CdnAuthConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPolicy())
            {
                context.Writer.WritePropertyName("Policy");
                context.Writer.WriteStringValue(publicRequest.Policy);
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
        private static PutOriginEndpointPolicyRequestMarshaller _instance = new PutOriginEndpointPolicyRequestMarshaller();        

        internal static PutOriginEndpointPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutOriginEndpointPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}