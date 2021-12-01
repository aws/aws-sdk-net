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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataValue Object
    /// </summary>  
    public class DataValueUnmarshaller : IUnmarshaller<DataValue, XmlUnmarshallerContext>, IUnmarshaller<DataValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataValue IUnmarshaller<DataValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataValue unmarshalledObject = new DataValue();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("booleanValue", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.BooleanValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("doubleValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DoubleValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Expression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("integerValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IntegerValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listValue", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataValue, DataValueUnmarshaller>(DataValueUnmarshaller.Instance);
                    unmarshalledObject.ListValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("longValue", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LongValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapValue", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, DataValue, StringUnmarshaller, DataValueUnmarshaller>(StringUnmarshaller.Instance, DataValueUnmarshaller.Instance);
                    unmarshalledObject.MapValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relationshipValue", targetDepth))
                {
                    var unmarshaller = RelationshipValueUnmarshaller.Instance;
                    unmarshalledObject.RelationshipValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stringValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StringValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataValueUnmarshaller _instance = new DataValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}