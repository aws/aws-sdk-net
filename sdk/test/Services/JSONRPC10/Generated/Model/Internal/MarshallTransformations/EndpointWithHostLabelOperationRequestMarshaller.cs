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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EndpointWithHostLabelOperation Request Marshaller
    /// </summary>       
    public class EndpointWithHostLabelOperationRequestMarshaller : IMarshaller<IRequest, EndpointWithHostLabelOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EndpointWithHostLabelOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EndpointWithHostLabelOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JSONRPC10");
            string target = "JsonRpc10.EndpointWithHostLabelOperation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
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
            if(publicRequest.IsSetLabel())
            {
                context.Writer.WritePropertyName("label");
                context.Writer.WriteStringValue(publicRequest.Label);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            var hostPrefixLabels = new
            {
                label = StringUtils.FromString(publicRequest.Label),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.label))
                throw new AmazonJSONRPC10Exception("label can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"foo.{hostPrefixLabels.label}.";

            return request;
        }
        private static EndpointWithHostLabelOperationRequestMarshaller _instance = new EndpointWithHostLabelOperationRequestMarshaller();        

        internal static EndpointWithHostLabelOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EndpointWithHostLabelOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}