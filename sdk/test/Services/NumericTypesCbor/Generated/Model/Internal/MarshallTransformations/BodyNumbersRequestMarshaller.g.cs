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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NumericTypesCbor.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NumericTypesCbor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BodyNumbers Request Marshaller
    /// </summary>
    public partial class BodyNumbersRequestMarshaller : IMarshaller<IRequest, BodyNumbersRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BodyNumbersRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BodyNumbersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NumericTypesCbor");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NumericTypesCbor/operation/BodyNumbers";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBigDecimalList())
                {
                    context.Writer.WriteTextString("BigDecimalList");
                    context.Writer.WriteStartArray(publicRequest.BigDecimalList.Count);
                    foreach (var publicRequestBigDecimalListListValue in publicRequest.BigDecimalList)
                    {
                        context.Writer.WriteBigDecimal(publicRequestBigDecimalListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetBigDecimalMap())
                {
                    context.Writer.WriteTextString("BigDecimalMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestBigDecimalMapKvp in publicRequest.BigDecimalMap)
                    {
                        context.Writer.WriteTextString(publicRequestBigDecimalMapKvp.Key);
                        var publicRequestBigDecimalMapValue = publicRequestBigDecimalMapKvp.Value;
                        context.Writer.WriteBigDecimal(publicRequestBigDecimalMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBigDecimalValue())
                {
                    context.Writer.WriteTextString("BigDecimalValue");
                    context.Writer.WriteBigDecimal(publicRequest.BigDecimalValue.Value);
                }
                if (publicRequest.IsSetBigIntegerList())
                {
                    context.Writer.WriteTextString("BigIntegerList");
                    context.Writer.WriteStartArray(publicRequest.BigIntegerList.Count);
                    foreach (var publicRequestBigIntegerListListValue in publicRequest.BigIntegerList)
                    {
                        context.Writer.WriteBigInteger(publicRequestBigIntegerListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetBigIntegerMap())
                {
                    context.Writer.WriteTextString("BigIntegerMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestBigIntegerMapKvp in publicRequest.BigIntegerMap)
                    {
                        context.Writer.WriteTextString(publicRequestBigIntegerMapKvp.Key);
                        var publicRequestBigIntegerMapValue = publicRequestBigIntegerMapKvp.Value;
                        context.Writer.WriteBigInteger(publicRequestBigIntegerMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBigIntegerValue())
                {
                    context.Writer.WriteTextString("BigIntegerValue");
                    context.Writer.WriteBigInteger(publicRequest.BigIntegerValue.Value);
                }
                if (publicRequest.IsSetByteList())
                {
                    context.Writer.WriteTextString("ByteList");
                    context.Writer.WriteStartArray(publicRequest.ByteList.Count);
                    foreach (var publicRequestByteListListValue in publicRequest.ByteList)
                    {
                        context.Writer.WriteInt32(publicRequestByteListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetByteMap())
                {
                    context.Writer.WriteTextString("ByteMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestByteMapKvp in publicRequest.ByteMap)
                    {
                        context.Writer.WriteTextString(publicRequestByteMapKvp.Key);
                        var publicRequestByteMapValue = publicRequestByteMapKvp.Value;
                        context.Writer.WriteInt32(publicRequestByteMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetByteValue())
                {
                    context.Writer.WriteTextString("ByteValue");
                    context.Writer.WriteInt32(publicRequest.ByteValue.Value);
                }
                if (publicRequest.IsSetNested())
                {
                    context.Writer.WriteTextString("Nested");
                    context.Writer.WriteStartMap(null);

                    var marshaller = NestedNumbersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Nested, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetNestedList())
                {
                    context.Writer.WriteTextString("NestedList");
                    context.Writer.WriteStartArray(publicRequest.NestedList.Count);
                    foreach (var publicRequestNestedListListValue in publicRequest.NestedList)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = NestedNumbersMarshaller.Instance;
                        marshaller.Marshall(publicRequestNestedListListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetShortList())
                {
                    context.Writer.WriteTextString("ShortList");
                    context.Writer.WriteStartArray(publicRequest.ShortList.Count);
                    foreach (var publicRequestShortListListValue in publicRequest.ShortList)
                    {
                        context.Writer.WriteInt32(publicRequestShortListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetShortMap())
                {
                    context.Writer.WriteTextString("ShortMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestShortMapKvp in publicRequest.ShortMap)
                    {
                        context.Writer.WriteTextString(publicRequestShortMapKvp.Key);
                        var publicRequestShortMapValue = publicRequestShortMapKvp.Value;
                        context.Writer.WriteInt32(publicRequestShortMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetShortValue())
                {
                    context.Writer.WriteTextString("ShortValue");
                    context.Writer.WriteInt32(publicRequest.ShortValue.Value);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly BodyNumbersRequestMarshaller _instance = new();

        internal static BodyNumbersRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BodyNumbersRequestMarshaller Instance => _instance;
    }
}
