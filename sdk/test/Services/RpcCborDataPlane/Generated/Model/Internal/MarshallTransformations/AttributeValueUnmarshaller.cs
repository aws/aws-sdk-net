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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcCborDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttributeValue Object
    /// </summary>  
    public class AttributeValueUnmarshaller : ICborUnmarshaller<AttributeValue, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AttributeValue Unmarshall(CborUnmarshallerContext context)
        {
            AttributeValue unmarshalledObject = new AttributeValue();
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
                    case "B":
                        {
                            context.AddPathSegment("B");
                            var unmarshaller = CborMemoryStreamUnmarshaller.Instance;
                            unmarshalledObject.B = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BOOL":
                        {
                            context.AddPathSegment("BOOL");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.BOOL = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BS":
                        {
                            context.AddPathSegment("BS");
                            var unmarshaller = new CborListUnmarshaller<MemoryStream, CborMemoryStreamUnmarshaller>(CborMemoryStreamUnmarshaller.Instance);
                            unmarshalledObject.BS = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "L":
                        {
                            context.AddPathSegment("L");
                            var unmarshaller = new CborListUnmarshaller<AttributeValue, AttributeValueUnmarshaller>(AttributeValueUnmarshaller.Instance);
                            unmarshalledObject.L = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "M":
                        {
                            context.AddPathSegment("M");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, AttributeValue, CborStringUnmarshaller, AttributeValueUnmarshaller>(CborStringUnmarshaller.Instance, AttributeValueUnmarshaller.Instance);
                            unmarshalledObject.M = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "N":
                        {
                            context.AddPathSegment("N");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.N = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NS":
                        {
                            context.AddPathSegment("NS");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.NS = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NULL":
                        {
                            context.AddPathSegment("NULL");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.NULL = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "S":
                        {
                            context.AddPathSegment("S");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.S = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SS":
                        {
                            context.AddPathSegment("SS");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.SS = unmarshaller.Unmarshall(context);
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


        private static AttributeValueUnmarshaller _instance = new AttributeValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttributeValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}