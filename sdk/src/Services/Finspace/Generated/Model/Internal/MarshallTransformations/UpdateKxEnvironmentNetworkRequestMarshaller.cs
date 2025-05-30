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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
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
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateKxEnvironmentNetwork Request Marshaller
    /// </summary>       
    public class UpdateKxEnvironmentNetworkRequestMarshaller : IMarshaller<IRequest, UpdateKxEnvironmentNetworkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateKxEnvironmentNetworkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateKxEnvironmentNetworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/kx/environments/{environmentId}/network";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomDNSConfiguration())
            {
                context.Writer.WritePropertyName("customDNSConfiguration");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomDNSConfigurationListValue in publicRequest.CustomDNSConfiguration)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomDNSServerMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomDNSConfigurationListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTransitGatewayConfiguration())
            {
                context.Writer.WritePropertyName("transitGatewayConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TransitGatewayConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TransitGatewayConfiguration, context);

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
        private static UpdateKxEnvironmentNetworkRequestMarshaller _instance = new UpdateKxEnvironmentNetworkRequestMarshaller();        

        internal static UpdateKxEnvironmentNetworkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateKxEnvironmentNetworkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}