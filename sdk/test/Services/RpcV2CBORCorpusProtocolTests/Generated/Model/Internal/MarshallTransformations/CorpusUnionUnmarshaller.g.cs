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

using Amazon.RpcV2CBORCorpusProtocolTests.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CorpusUnion Object
    /// </summary>
    public partial class CorpusUnionUnmarshaller : ICborUnmarshaller<CorpusUnion, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CorpusUnion Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CorpusUnion();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "bigDecimalValue":
                        context.AddPathSegment("BigDecimalValue");
                        unmarshalledObject.BigDecimalValue = CborNullableBigDecimalUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "bigIntegerValue":
                        context.AddPathSegment("BigIntegerValue");
                        unmarshalledObject.BigIntegerValue = CborNullableBigIntegerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "blobValue":
                        context.AddPathSegment("BlobValue");
                        unmarshalledObject.BlobValue = CborMemoryStreamUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "booleanValue":
                        context.AddPathSegment("BooleanValue");
                        unmarshalledObject.BooleanValue = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "byteValue":
                        context.AddPathSegment("ByteValue");
                        unmarshalledObject.ByteValue = CborNullableSByteUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "doubleValue":
                        context.AddPathSegment("DoubleValue");
                        unmarshalledObject.DoubleValue = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "enumValue":
                        context.AddPathSegment("EnumValue");
                        unmarshalledObject.EnumValue = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "floatValue":
                        context.AddPathSegment("FloatValue");
                        unmarshalledObject.FloatValue = CborNullableFloatUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "intEnumValue":
                        context.AddPathSegment("IntEnumValue");
                        unmarshalledObject.IntEnumValue = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "integerValue":
                        context.AddPathSegment("IntegerValue");
                        unmarshalledObject.IntegerValue = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "listValue":
                        context.AddPathSegment("ListValue");
                        unmarshalledObject.ListValue = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "longValue":
                        context.AddPathSegment("LongValue");
                        unmarshalledObject.LongValue = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "mapValue":
                        context.AddPathSegment("MapValue");
                        unmarshalledObject.MapValue = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "shortValue":
                        context.AddPathSegment("ShortValue");
                        unmarshalledObject.ShortValue = CborNullableShortUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stringValue":
                        context.AddPathSegment("StringValue");
                        unmarshalledObject.StringValue = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "structValue":
                        context.AddPathSegment("StructValue");
                        unmarshalledObject.StructValue = SimpleStructUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "timestampValue":
                        context.AddPathSegment("TimestampValue");
                        unmarshalledObject.TimestampValue = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "unionValue":
                        context.AddPathSegment("UnionValue");
                        unmarshalledObject.UnionValue = CorpusSubUnionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static CorpusUnionUnmarshaller _instance = new CorpusUnionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CorpusUnionUnmarshaller Instance => _instance;
    }
}
