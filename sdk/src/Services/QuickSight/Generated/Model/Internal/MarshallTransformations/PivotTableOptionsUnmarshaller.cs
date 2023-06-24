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
    /// Response Unmarshaller for PivotTableOptions Object
    /// </summary>  
    public class PivotTableOptionsUnmarshaller : IUnmarshaller<PivotTableOptions, XmlUnmarshallerContext>, IUnmarshaller<PivotTableOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PivotTableOptions IUnmarshaller<PivotTableOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PivotTableOptions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PivotTableOptions unmarshalledObject = new PivotTableOptions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CellStyle", targetDepth))
                {
                    var unmarshaller = TableCellStyleUnmarshaller.Instance;
                    unmarshalledObject.CellStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CollapsedRowDimensionsVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollapsedRowDimensionsVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnHeaderStyle", targetDepth))
                {
                    var unmarshaller = TableCellStyleUnmarshaller.Instance;
                    unmarshalledObject.ColumnHeaderStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnNamesVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnNamesVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricPlacement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricPlacement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowAlternateColorOptions", targetDepth))
                {
                    var unmarshaller = RowAlternateColorOptionsUnmarshaller.Instance;
                    unmarshalledObject.RowAlternateColorOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowFieldNamesStyle", targetDepth))
                {
                    var unmarshaller = TableCellStyleUnmarshaller.Instance;
                    unmarshalledObject.RowFieldNamesStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowHeaderStyle", targetDepth))
                {
                    var unmarshaller = TableCellStyleUnmarshaller.Instance;
                    unmarshalledObject.RowHeaderStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SingleMetricVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SingleMetricVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ToggleButtonsVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToggleButtonsVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PivotTableOptionsUnmarshaller _instance = new PivotTableOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PivotTableOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}