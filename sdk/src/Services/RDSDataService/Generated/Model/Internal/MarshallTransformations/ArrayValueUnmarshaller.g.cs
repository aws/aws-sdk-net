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

using Amazon.RDSDataService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ArrayValue Object
    /// </summary>
    public partial class ArrayValueUnmarshaller : IJsonUnmarshaller<ArrayValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ArrayValue Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ArrayValue();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arrayValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ArrayValue, ArrayValueUnmarshaller>(ArrayValueUnmarshaller.Instance);
                    unmarshalledObject.ArrayValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("booleanValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<bool?, NullableBoolUnmarshaller>(NullableBoolUnmarshaller.Instance);
                    unmarshalledObject.BooleanValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("doubleValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<double?, NullableDoubleUnmarshaller>(NullableDoubleUnmarshaller.Instance);
                    unmarshalledObject.DoubleValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("longValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<long?, NullableLongUnmarshaller>(NullableLongUnmarshaller.Instance);
                    unmarshalledObject.LongValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("stringValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StringValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ArrayValueUnmarshaller _instance = new ArrayValueUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ArrayValueUnmarshaller Instance => _instance;
    }
}
