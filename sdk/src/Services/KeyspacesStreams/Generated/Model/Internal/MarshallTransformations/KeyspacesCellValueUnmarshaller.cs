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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyspacesStreams.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KeyspacesStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KeyspacesCellValue Object
    /// </summary>  
    public class KeyspacesCellValueUnmarshaller : IUnmarshaller<KeyspacesCellValue, XmlUnmarshallerContext>, IUnmarshaller<KeyspacesCellValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KeyspacesCellValue IUnmarshaller<KeyspacesCellValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public KeyspacesCellValue Unmarshall(JsonUnmarshallerContext context)
        {
            KeyspacesCellValue unmarshalledObject = new KeyspacesCellValue();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("asciiT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AsciiT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bigintT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BigintT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blobT", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.BlobT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("boolT", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.BoolT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("counterT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CounterT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("decimalT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DecimalT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("doubleT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DoubleT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("floatT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FloatT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inetT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InetT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listT", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyspacesCell, KeyspacesCellUnmarshaller>(KeyspacesCellUnmarshaller.Instance);
                    unmarshalledObject.ListT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapT", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyspacesCellMapDefinition, KeyspacesCellMapDefinitionUnmarshaller>(KeyspacesCellMapDefinitionUnmarshaller.Instance);
                    unmarshalledObject.MapT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("setT", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyspacesCell, KeyspacesCellUnmarshaller>(KeyspacesCellUnmarshaller.Instance);
                    unmarshalledObject.SetT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("smallintT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SmallintT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("textT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TextT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestampT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimestampT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeuuidT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeuuidT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tinyintT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TinyintT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tupleT", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyspacesCell, KeyspacesCellUnmarshaller>(KeyspacesCellUnmarshaller.Instance);
                    unmarshalledObject.TupleT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("udtT", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, KeyspacesCell, StringUnmarshaller, KeyspacesCellUnmarshaller>(StringUnmarshaller.Instance, KeyspacesCellUnmarshaller.Instance);
                    unmarshalledObject.UdtT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uuidT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UuidT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("varcharT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VarcharT = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("varintT", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VarintT = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KeyspacesCellValueUnmarshaller _instance = new KeyspacesCellValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyspacesCellValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}