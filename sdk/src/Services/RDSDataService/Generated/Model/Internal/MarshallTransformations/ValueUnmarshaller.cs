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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Value Object
    /// </summary>  
    public class ValueUnmarshaller : IJsonUnmarshaller<Value, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Value Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Value unmarshalledObject = new Value();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arrayValues", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Value, ValueUnmarshaller>(ValueUnmarshaller.Instance);
                    unmarshalledObject.ArrayValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bigIntValue", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BigIntValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bitValue", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.BitValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("blobValue", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.BlobValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("doubleValue", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.DoubleValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("intValue", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IntValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isNull", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsNull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("realValue", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.RealValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stringValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StringValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("structValue", targetDepth))
                {
                    var unmarshaller = StructValueUnmarshaller.Instance;
                    unmarshalledObject.StructValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ValueUnmarshaller _instance = new ValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}