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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/SimpleScalarProperties";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetByteValue())
            {
                context.Writer.WritePropertyName("byteValue");
                context.Writer.WriteNumberValue(publicRequest.ByteValue.Value);
            }

            if(publicRequest.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("DoubleDribble");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.DoubleValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.DoubleValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.DoubleValue.Value);
                }
            }

            if(publicRequest.IsSetFalseBooleanValue())
            {
                context.Writer.WritePropertyName("falseBooleanValue");
                context.Writer.WriteBooleanValue(publicRequest.FalseBooleanValue.Value);
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

            if(publicRequest.IsSetIntegerValue())
            {
                context.Writer.WritePropertyName("integerValue");
                context.Writer.WriteNumberValue(publicRequest.IntegerValue.Value);
            }

            if(publicRequest.IsSetLongValue())
            {
                context.Writer.WritePropertyName("longValue");
                context.Writer.WriteNumberValue(publicRequest.LongValue.Value);
            }

            if(publicRequest.IsSetShortValue())
            {
                context.Writer.WritePropertyName("shortValue");
                context.Writer.WriteNumberValue(publicRequest.ShortValue.Value);
            }

            if(publicRequest.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.WriteStringValue(publicRequest.StringValue);
            }

            if(publicRequest.IsSetTrueBooleanValue())
            {
                context.Writer.WritePropertyName("trueBooleanValue");
                context.Writer.WriteBooleanValue(publicRequest.TrueBooleanValue.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetFoo()) 
            {
                request.Headers["X-Foo"] = publicRequest.Foo;
            }

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