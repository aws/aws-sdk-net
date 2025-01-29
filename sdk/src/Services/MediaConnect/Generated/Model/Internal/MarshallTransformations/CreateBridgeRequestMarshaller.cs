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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
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
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBridge Request Marshaller
    /// </summary>       
    public class CreateBridgeRequestMarshaller : IMarshaller<IRequest, CreateBridgeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBridgeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBridgeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/bridges";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEgressGatewayBridge())
            {
                context.Writer.WritePropertyName("egressGatewayBridge");
                context.Writer.WriteStartObject();

                var marshaller = AddEgressGatewayBridgeRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.EgressGatewayBridge, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIngressGatewayBridge())
            {
                context.Writer.WritePropertyName("ingressGatewayBridge");
                context.Writer.WriteStartObject();

                var marshaller = AddIngressGatewayBridgeRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.IngressGatewayBridge, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddBridgeOutputRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPlacementArn())
            {
                context.Writer.WritePropertyName("placementArn");
                context.Writer.WriteStringValue(publicRequest.PlacementArn);
            }

            if(publicRequest.IsSetSourceFailoverConfig())
            {
                context.Writer.WritePropertyName("sourceFailoverConfig");
                context.Writer.WriteStartObject();

                var marshaller = FailoverConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceFailoverConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddBridgeSourceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourcesListValue, context);

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
        private static CreateBridgeRequestMarshaller _instance = new CreateBridgeRequestMarshaller();        

        internal static CreateBridgeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBridgeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}