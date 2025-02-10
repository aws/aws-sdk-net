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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
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
namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConnectPeer Request Marshaller
    /// </summary>       
    public class CreateConnectPeerRequestMarshaller : IMarshaller<IRequest, CreateConnectPeerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConnectPeerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConnectPeerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/connect-peers";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBgpOptions())
            {
                context.Writer.WritePropertyName("BgpOptions");
                context.Writer.WriteStartObject();

                var marshaller = BgpOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.BgpOptions, context);

                context.Writer.WriteEndObject();
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
            if(publicRequest.IsSetConnectAttachmentId())
            {
                context.Writer.WritePropertyName("ConnectAttachmentId");
                context.Writer.WriteStringValue(publicRequest.ConnectAttachmentId);
            }

            if(publicRequest.IsSetCoreNetworkAddress())
            {
                context.Writer.WritePropertyName("CoreNetworkAddress");
                context.Writer.WriteStringValue(publicRequest.CoreNetworkAddress);
            }

            if(publicRequest.IsSetInsideCidrBlocks())
            {
                context.Writer.WritePropertyName("InsideCidrBlocks");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInsideCidrBlocksListValue in publicRequest.InsideCidrBlocks)
                {
                        context.Writer.WriteStringValue(publicRequestInsideCidrBlocksListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPeerAddress())
            {
                context.Writer.WritePropertyName("PeerAddress");
                context.Writer.WriteStringValue(publicRequest.PeerAddress);
            }

            if(publicRequest.IsSetSubnetArn())
            {
                context.Writer.WritePropertyName("SubnetArn");
                context.Writer.WriteStringValue(publicRequest.SubnetArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateConnectPeerRequestMarshaller _instance = new CreateConnectPeerRequestMarshaller();        

        internal static CreateConnectPeerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConnectPeerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}