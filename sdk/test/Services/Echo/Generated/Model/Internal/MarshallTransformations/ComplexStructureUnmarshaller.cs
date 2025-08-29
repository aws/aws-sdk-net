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
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Echo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.Echo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComplexStructure Object
    /// </summary>  
    public class ComplexStructureUnmarshaller : ICborUnmarshaller<ComplexStructure, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ComplexStructure Unmarshall(CborUnmarshallerContext context)
        {
            ComplexStructure unmarshalledObject = new ComplexStructure();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobMember":
                        {
                            context.AddPathSegment("BlobMember");
                            var unmarshaller = CborMemoryStreamUnmarshaller.Instance;
                            unmarshalledObject.BlobMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "booleanMember":
                        {
                            context.AddPathSegment("BooleanMember");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.BooleanMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "complexStructMember":
                        {
                            context.AddPathSegment("ComplexStructMember");
                            var unmarshaller = ComplexStructureUnmarshaller.Instance;
                            unmarshalledObject.ComplexStructMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "doubleMember":
                        {
                            context.AddPathSegment("DoubleMember");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.DoubleMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "floatMember":
                        {
                            context.AddPathSegment("FloatMember");
                            var unmarshaller = CborNullableFloatUnmarshaller.Instance;
                            unmarshalledObject.FloatMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "integerMember":
                        {
                            context.AddPathSegment("IntegerMember");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.IntegerMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "listOfComplexObjectMember":
                        {
                            context.AddPathSegment("ListOfComplexObjectMember");
                            var unmarshaller = new CborListUnmarshaller<ComplexStructure, ComplexStructureUnmarshaller>(ComplexStructureUnmarshaller.Instance);
                            unmarshalledObject.ListOfComplexObjectMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "listOfStringsMember":
                        {
                            context.AddPathSegment("ListOfStringsMember");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.ListOfStringsMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "longMember":
                        {
                            context.AddPathSegment("LongMember");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LongMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "mapOfStringToStringMember":
                        {
                            context.AddPathSegment("MapOfStringToStringMember");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.MapOfStringToStringMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stringMember":
                        {
                            context.AddPathSegment("StringMember");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StringMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "timestampMember":
                        {
                            context.AddPathSegment("TimestampMember");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.TimestampMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static ComplexStructureUnmarshaller _instance = new ComplexStructureUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComplexStructureUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}