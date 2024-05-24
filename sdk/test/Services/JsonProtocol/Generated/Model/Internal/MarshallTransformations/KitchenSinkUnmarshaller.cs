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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.JsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.JsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KitchenSink Object
    /// </summary>  
    public class KitchenSinkUnmarshaller : IUnmarshaller<KitchenSink, XmlUnmarshallerContext>, IUnmarshaller<KitchenSink, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KitchenSink IUnmarshaller<KitchenSink, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public KitchenSink Unmarshall(JsonUnmarshallerContext context)
        {
            KitchenSink unmarshalledObject = new KitchenSink();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Blob", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.Blob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Boolean", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Boolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Double", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Double = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmptyStruct", targetDepth))
                {
                    var unmarshaller = EmptyStructUnmarshaller.Instance;
                    unmarshalledObject.EmptyStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Float", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Float = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpdateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.HttpdateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Integer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Integer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Iso8601Timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Iso8601Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JsonValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JsonValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfLists", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<List<string>, ListUnmarshaller<string, StringUnmarshaller>>(new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.ListOfLists = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfMapsOfStrings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, string>, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.ListOfMapsOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfStrings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ListOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfStructs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SimpleStruct, SimpleStructUnmarshaller>(SimpleStructUnmarshaller.Instance);
                    unmarshalledObject.ListOfStructs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Long", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Long = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfListsOfStrings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.MapOfListsOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfMaps", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.MapOfMaps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfStrings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.MapOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfStructs", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, SimpleStruct, StringUnmarshaller, SimpleStructUnmarshaller>(StringUnmarshaller.Instance, SimpleStructUnmarshaller.Instance);
                    unmarshalledObject.MapOfStructs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KitchenSink, KitchenSinkUnmarshaller>(KitchenSinkUnmarshaller.Instance);
                    unmarshalledObject.RecursiveList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveMap", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, KitchenSink, StringUnmarshaller, KitchenSinkUnmarshaller>(StringUnmarshaller.Instance, KitchenSinkUnmarshaller.Instance);
                    unmarshalledObject.RecursiveMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveStruct", targetDepth))
                {
                    var unmarshaller = KitchenSinkUnmarshaller.Instance;
                    unmarshalledObject.RecursiveStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SimpleStruct", targetDepth))
                {
                    var unmarshaller = SimpleStructUnmarshaller.Instance;
                    unmarshalledObject.SimpleStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("String", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.String = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StructWithJsonName", targetDepth))
                {
                    var unmarshaller = StructWithJsonNameUnmarshaller.Instance;
                    unmarshalledObject.StructWithJsonName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnixTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UnixTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KitchenSinkUnmarshaller _instance = new KitchenSinkUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KitchenSinkUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}