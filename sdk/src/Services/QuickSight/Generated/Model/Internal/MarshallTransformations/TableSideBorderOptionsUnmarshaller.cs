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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TableSideBorderOptions Object
    /// </summary>  
    public class TableSideBorderOptionsUnmarshaller : IJsonUnmarshaller<TableSideBorderOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TableSideBorderOptions Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TableSideBorderOptions unmarshalledObject = new TableSideBorderOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Bottom", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.Bottom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InnerHorizontal", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.InnerHorizontal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InnerVertical", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.InnerVertical = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Left", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.Left = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Right", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.Right = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Top", targetDepth))
                {
                    var unmarshaller = TableBorderOptionsUnmarshaller.Instance;
                    unmarshalledObject.Top = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TableSideBorderOptionsUnmarshaller _instance = new TableSideBorderOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableSideBorderOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}