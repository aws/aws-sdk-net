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
    /// SimpleScalarProperties Request Marshaller
    /// </summary>       
    public class SimpleScalarPropertiesRequestMarshaller : IMarshaller<IRequest, SimpleScalarPropertiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleScalarPropertiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SimpleScalarPropertiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JSONRPC10");
            string target = "JsonRpc10.SimpleScalarProperties";
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
            if(publicRequest.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("doubleValue");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.DoubleValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.DoubleValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.DoubleValue.Value);
                }
            }

            if(publicRequest.IsSetFloatValue())
            {
                context.Writer.WritePropertyName("floatValue");
                if(StringUtils.IsSpecialFloatValue(publicRequest.FloatValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.FloatValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.FloatValue.Value);
                }
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
        private static SimpleScalarPropertiesRequestMarshaller _instance = new SimpleScalarPropertiesRequestMarshaller();        

        internal static SimpleScalarPropertiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarPropertiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}