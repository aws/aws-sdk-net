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
    /// Response Unmarshaller for TableConfiguration Object
    /// </summary>  
    public class TableConfigurationUnmarshaller : IUnmarshaller<TableConfiguration, XmlUnmarshallerContext>, IUnmarshaller<TableConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TableConfiguration IUnmarshaller<TableConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TableConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TableConfiguration unmarshalledObject = new TableConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FieldOptions", targetDepth))
                {
                    var unmarshaller = TableFieldOptionsUnmarshaller.Instance;
                    unmarshalledObject.FieldOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldWells", targetDepth))
                {
                    var unmarshaller = TableFieldWellsUnmarshaller.Instance;
                    unmarshalledObject.FieldWells = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaginatedReportOptions", targetDepth))
                {
                    var unmarshaller = TablePaginatedReportOptionsUnmarshaller.Instance;
                    unmarshalledObject.PaginatedReportOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SortConfiguration", targetDepth))
                {
                    var unmarshaller = TableSortConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SortConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableInlineVisualizations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TableInlineVisualization, TableInlineVisualizationUnmarshaller>(TableInlineVisualizationUnmarshaller.Instance);
                    unmarshalledObject.TableInlineVisualizations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableOptions", targetDepth))
                {
                    var unmarshaller = TableOptionsUnmarshaller.Instance;
                    unmarshalledObject.TableOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalOptions", targetDepth))
                {
                    var unmarshaller = TotalOptionsUnmarshaller.Instance;
                    unmarshalledObject.TotalOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TableConfigurationUnmarshaller _instance = new TableConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}