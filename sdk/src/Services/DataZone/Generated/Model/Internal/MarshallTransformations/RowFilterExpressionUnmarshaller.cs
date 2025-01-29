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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RowFilterExpression Object
    /// </summary>  
    public class RowFilterExpressionUnmarshaller : IJsonUnmarshaller<RowFilterExpression, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RowFilterExpression Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RowFilterExpression unmarshalledObject = new RowFilterExpression();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("equalTo", targetDepth))
                {
                    var unmarshaller = EqualToExpressionUnmarshaller.Instance;
                    unmarshalledObject.EqualTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThan", targetDepth))
                {
                    var unmarshaller = GreaterThanExpressionUnmarshaller.Instance;
                    unmarshalledObject.GreaterThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThanOrEqualTo", targetDepth))
                {
                    var unmarshaller = GreaterThanOrEqualToExpressionUnmarshaller.Instance;
                    unmarshalledObject.GreaterThanOrEqualTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("in", targetDepth))
                {
                    var unmarshaller = InExpressionUnmarshaller.Instance;
                    unmarshalledObject.In = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isNotNull", targetDepth))
                {
                    var unmarshaller = IsNotNullExpressionUnmarshaller.Instance;
                    unmarshalledObject.IsNotNull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isNull", targetDepth))
                {
                    var unmarshaller = IsNullExpressionUnmarshaller.Instance;
                    unmarshalledObject.IsNull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThan", targetDepth))
                {
                    var unmarshaller = LessThanExpressionUnmarshaller.Instance;
                    unmarshalledObject.LessThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThanOrEqualTo", targetDepth))
                {
                    var unmarshaller = LessThanOrEqualToExpressionUnmarshaller.Instance;
                    unmarshalledObject.LessThanOrEqualTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("like", targetDepth))
                {
                    var unmarshaller = LikeExpressionUnmarshaller.Instance;
                    unmarshalledObject.Like = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notEqualTo", targetDepth))
                {
                    var unmarshaller = NotEqualToExpressionUnmarshaller.Instance;
                    unmarshalledObject.NotEqualTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notIn", targetDepth))
                {
                    var unmarshaller = NotInExpressionUnmarshaller.Instance;
                    unmarshalledObject.NotIn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notLike", targetDepth))
                {
                    var unmarshaller = NotLikeExpressionUnmarshaller.Instance;
                    unmarshalledObject.NotLike = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RowFilterExpressionUnmarshaller _instance = new RowFilterExpressionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RowFilterExpressionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}