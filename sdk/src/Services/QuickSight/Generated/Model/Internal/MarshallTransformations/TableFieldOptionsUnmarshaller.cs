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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TableFieldOptions Object
    /// </summary>  
    public class TableFieldOptionsUnmarshaller : IUnmarshaller<TableFieldOptions, XmlUnmarshallerContext>, IUnmarshaller<TableFieldOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TableFieldOptions IUnmarshaller<TableFieldOptions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TableFieldOptions Unmarshall(JsonUnmarshallerContext context)
        {
            TableFieldOptions unmarshalledObject = new TableFieldOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Order", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Order = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PinnedFieldOptions", targetDepth))
                {
                    var unmarshaller = TablePinnedFieldOptionsUnmarshaller.Instance;
                    unmarshalledObject.PinnedFieldOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectedFieldOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TableFieldOption, TableFieldOptionUnmarshaller>(TableFieldOptionUnmarshaller.Instance);
                    unmarshalledObject.SelectedFieldOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransposedTableOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TransposedTableOption, TransposedTableOptionUnmarshaller>(TransposedTableOptionUnmarshaller.Instance);
                    unmarshalledObject.TransposedTableOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TableFieldOptionsUnmarshaller _instance = new TableFieldOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableFieldOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}