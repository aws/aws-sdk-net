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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NumericRangeFilter Object
    /// </summary>  
    public class NumericRangeFilterUnmarshaller : IUnmarshaller<NumericRangeFilter, XmlUnmarshallerContext>, IUnmarshaller<NumericRangeFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NumericRangeFilter IUnmarshaller<NumericRangeFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NumericRangeFilter Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NumericRangeFilter unmarshalledObject = new NumericRangeFilter();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AggregationFunction", targetDepth))
                {
                    var unmarshaller = AggregationFunctionUnmarshaller.Instance;
                    unmarshalledObject.AggregationFunction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Column", targetDepth))
                {
                    var unmarshaller = ColumnIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Column = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeMaximum", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeMaximum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeMinimum", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeMinimum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NullOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NullOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RangeMaximum", targetDepth))
                {
                    var unmarshaller = NumericRangeFilterValueUnmarshaller.Instance;
                    unmarshalledObject.RangeMaximum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RangeMinimum", targetDepth))
                {
                    var unmarshaller = NumericRangeFilterValueUnmarshaller.Instance;
                    unmarshalledObject.RangeMinimum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectAllOptions", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelectAllOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NumericRangeFilterUnmarshaller _instance = new NumericRangeFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NumericRangeFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}