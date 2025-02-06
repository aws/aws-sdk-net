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
    /// Response Unmarshaller for Filter Object
    /// </summary>  
    public class FilterUnmarshaller : IJsonUnmarshaller<Filter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Filter Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Filter unmarshalledObject = new Filter();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CategoryFilter", targetDepth))
                {
                    var unmarshaller = CategoryFilterUnmarshaller.Instance;
                    unmarshalledObject.CategoryFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NestedFilter", targetDepth))
                {
                    var unmarshaller = NestedFilterUnmarshaller.Instance;
                    unmarshalledObject.NestedFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumericEqualityFilter", targetDepth))
                {
                    var unmarshaller = NumericEqualityFilterUnmarshaller.Instance;
                    unmarshalledObject.NumericEqualityFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumericRangeFilter", targetDepth))
                {
                    var unmarshaller = NumericRangeFilterUnmarshaller.Instance;
                    unmarshalledObject.NumericRangeFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelativeDatesFilter", targetDepth))
                {
                    var unmarshaller = RelativeDatesFilterUnmarshaller.Instance;
                    unmarshalledObject.RelativeDatesFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeEqualityFilter", targetDepth))
                {
                    var unmarshaller = TimeEqualityFilterUnmarshaller.Instance;
                    unmarshalledObject.TimeEqualityFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeRangeFilter", targetDepth))
                {
                    var unmarshaller = TimeRangeFilterUnmarshaller.Instance;
                    unmarshalledObject.TimeRangeFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TopBottomFilter", targetDepth))
                {
                    var unmarshaller = TopBottomFilterUnmarshaller.Instance;
                    unmarshalledObject.TopBottomFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FilterUnmarshaller _instance = new FilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}