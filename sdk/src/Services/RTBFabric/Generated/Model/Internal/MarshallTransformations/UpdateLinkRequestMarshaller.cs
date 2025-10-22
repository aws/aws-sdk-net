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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RTBFabric.Model;
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
namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLink Request Marshaller
    /// </summary>       
    public class UpdateLinkRequestMarshaller : IMarshaller<IRequest, UpdateLinkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLinkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLinkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RTBFabric");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-15";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetGatewayId())
                throw new AmazonRTBFabricException("Request object does not have required field GatewayId set");
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));
            if (!publicRequest.IsSetLinkId())
                throw new AmazonRTBFabricException("Request object does not have required field LinkId set");
            request.AddPathResource("{linkId}", StringUtils.FromString(publicRequest.LinkId));
            request.ResourcePath = "/gateway/{gatewayId}/link/{linkId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetLogSettings())
            {
                context.Writer.WritePropertyName("logSettings");
                context.Writer.WriteStartObject();

                var marshaller = LinkLogSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogSettings, context);

                context.Writer.WriteEndObject();
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
        private static UpdateLinkRequestMarshaller _instance = new UpdateLinkRequestMarshaller();        

        internal static UpdateLinkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLinkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}