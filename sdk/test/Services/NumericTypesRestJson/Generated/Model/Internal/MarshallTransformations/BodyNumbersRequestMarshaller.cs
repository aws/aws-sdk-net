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
 * Do not modify this file. This file is generated from the numerictypesrestjson-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestJson.Model;
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
namespace Amazon.NumericTypesRestJson.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BodyNumbers Request Marshaller
    /// </summary>       
    public class BodyNumbersRequestMarshaller : IMarshaller<IRequest, BodyNumbersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BodyNumbersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BodyNumbersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NumericTypesRestJson");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/BodyNumbers";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBigDecimalList())
            {
                context.Writer.WritePropertyName("BigDecimalList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBigDecimalListListValue in publicRequest.BigDecimalList)
                {
                        StringUtils.WriteBigDecimalValue(context.Writer, publicRequestBigDecimalListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBigDecimalMap())
            {
                context.Writer.WritePropertyName("BigDecimalMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestBigDecimalMapKvp in publicRequest.BigDecimalMap)
                {
                    context.Writer.WritePropertyName(publicRequestBigDecimalMapKvp.Key);
                    var publicRequestBigDecimalMapValue = publicRequestBigDecimalMapKvp.Value;

                        StringUtils.WriteBigDecimalValue(context.Writer, publicRequestBigDecimalMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBigDecimalValue())
            {
                context.Writer.WritePropertyName("BigDecimalValue");
                StringUtils.WriteBigDecimalValue(context.Writer, publicRequest.BigDecimalValue.Value);
            }

            if(publicRequest.IsSetBigIntegerList())
            {
                context.Writer.WritePropertyName("BigIntegerList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBigIntegerListListValue in publicRequest.BigIntegerList)
                {
                        StringUtils.WriteBigIntegerValue(context.Writer, publicRequestBigIntegerListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBigIntegerMap())
            {
                context.Writer.WritePropertyName("BigIntegerMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestBigIntegerMapKvp in publicRequest.BigIntegerMap)
                {
                    context.Writer.WritePropertyName(publicRequestBigIntegerMapKvp.Key);
                    var publicRequestBigIntegerMapValue = publicRequestBigIntegerMapKvp.Value;

                        StringUtils.WriteBigIntegerValue(context.Writer, publicRequestBigIntegerMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBigIntegerValue())
            {
                context.Writer.WritePropertyName("BigIntegerValue");
                StringUtils.WriteBigIntegerValue(context.Writer, publicRequest.BigIntegerValue.Value);
            }

            if(publicRequest.IsSetByteList())
            {
                context.Writer.WritePropertyName("ByteList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestByteListListValue in publicRequest.ByteList)
                {
                        context.Writer.WriteNumberValue(publicRequestByteListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetByteMap())
            {
                context.Writer.WritePropertyName("ByteMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestByteMapKvp in publicRequest.ByteMap)
                {
                    context.Writer.WritePropertyName(publicRequestByteMapKvp.Key);
                    var publicRequestByteMapValue = publicRequestByteMapKvp.Value;

                        context.Writer.WriteNumberValue(publicRequestByteMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetByteValue())
            {
                context.Writer.WritePropertyName("ByteValue");
                context.Writer.WriteNumberValue(publicRequest.ByteValue.Value);
            }

            if(publicRequest.IsSetNested())
            {
                context.Writer.WritePropertyName("Nested");
                context.Writer.WriteStartObject();

                var marshaller = NestedNumbersMarshaller.Instance;
                marshaller.Marshall(publicRequest.Nested, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNestedList())
            {
                context.Writer.WritePropertyName("NestedList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNestedListListValue in publicRequest.NestedList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NestedNumbersMarshaller.Instance;
                    marshaller.Marshall(publicRequestNestedListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetShortList())
            {
                context.Writer.WritePropertyName("ShortList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestShortListListValue in publicRequest.ShortList)
                {
                        context.Writer.WriteNumberValue(publicRequestShortListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetShortMap())
            {
                context.Writer.WritePropertyName("ShortMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestShortMapKvp in publicRequest.ShortMap)
                {
                    context.Writer.WritePropertyName(publicRequestShortMapKvp.Key);
                    var publicRequestShortMapValue = publicRequestShortMapKvp.Value;

                        context.Writer.WriteNumberValue(publicRequestShortMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetShortValue())
            {
                context.Writer.WritePropertyName("ShortValue");
                context.Writer.WriteNumberValue(publicRequest.ShortValue.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static BodyNumbersRequestMarshaller _instance = new BodyNumbersRequestMarshaller();        

        internal static BodyNumbersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodyNumbersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}