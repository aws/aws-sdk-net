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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
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
namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLag Request Marshaller
    /// </summary>       
    public class CreateLagRequestMarshaller : IMarshaller<IRequest, CreateLagRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLagRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLagRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectConnect");
            string target = "OvertureService.CreateLag";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChildConnectionTags())
            {
                context.Writer.WritePropertyName("childConnectionTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestChildConnectionTagsListValue in publicRequest.ChildConnectionTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestChildConnectionTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConnectionId())
            {
                context.Writer.WritePropertyName("connectionId");
                context.Writer.WriteStringValue(publicRequest.ConnectionId);
            }

            if(publicRequest.IsSetConnectionsBandwidth())
            {
                context.Writer.WritePropertyName("connectionsBandwidth");
                context.Writer.WriteStringValue(publicRequest.ConnectionsBandwidth);
            }

            if(publicRequest.IsSetLagName())
            {
                context.Writer.WritePropertyName("lagName");
                context.Writer.WriteStringValue(publicRequest.LagName);
            }

            if(publicRequest.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteStringValue(publicRequest.Location);
            }

            if(publicRequest.IsSetNumberOfConnections())
            {
                context.Writer.WritePropertyName("numberOfConnections");
                context.Writer.WriteNumberValue(publicRequest.NumberOfConnections.Value);
            }

            if(publicRequest.IsSetProviderName())
            {
                context.Writer.WritePropertyName("providerName");
                context.Writer.WriteStringValue(publicRequest.ProviderName);
            }

            if(publicRequest.IsSetRequestMACSec())
            {
                context.Writer.WritePropertyName("requestMACSec");
                context.Writer.WriteBooleanValue(publicRequest.RequestMACSec.Value);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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
        private static CreateLagRequestMarshaller _instance = new CreateLagRequestMarshaller();        

        internal static CreateLagRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLagRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}