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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNodeRegistrationScript Request Marshaller
    /// </summary>       
    public class CreateNodeRegistrationScriptRequestMarshaller : IMarshaller<IRequest, CreateNodeRegistrationScriptRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNodeRegistrationScriptRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNodeRegistrationScriptRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterId())
                throw new AmazonMediaLiveException("Request object does not have required field ClusterId set");
            request.AddPathResource("{clusterId}", StringUtils.FromString(publicRequest.ClusterId));
            request.ResourcePath = "/prod/clusters/{clusterId}/nodeRegistrationScript";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNodeInterfaceMappings())
            {
                context.Writer.WritePropertyName("nodeInterfaceMappings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNodeInterfaceMappingsListValue in publicRequest.NodeInterfaceMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NodeInterfaceMappingMarshaller.Instance;
                    marshaller.Marshall(publicRequestNodeInterfaceMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRequestId())
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(publicRequest.RequestId);
            }

            else if(!(publicRequest.IsSetRequestId()))
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(publicRequest.Role);
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
        private static CreateNodeRegistrationScriptRequestMarshaller _instance = new CreateNodeRegistrationScriptRequestMarshaller();        

        internal static CreateNodeRegistrationScriptRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNodeRegistrationScriptRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}