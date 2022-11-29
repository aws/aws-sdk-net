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
    /// Response Unmarshaller for TableConditionalFormattingOption Object
    /// </summary>  
    public class TableConditionalFormattingOptionUnmarshaller : IUnmarshaller<TableConditionalFormattingOption, XmlUnmarshallerContext>, IUnmarshaller<TableConditionalFormattingOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TableConditionalFormattingOption IUnmarshaller<TableConditionalFormattingOption, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TableConditionalFormattingOption Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TableConditionalFormattingOption unmarshalledObject = new TableConditionalFormattingOption();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Cell", targetDepth))
                {
                    var unmarshaller = TableCellConditionalFormattingUnmarshaller.Instance;
                    unmarshalledObject.Cell = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Row", targetDepth))
                {
                    var unmarshaller = TableRowConditionalFormattingUnmarshaller.Instance;
                    unmarshalledObject.Row = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TableConditionalFormattingOptionUnmarshaller _instance = new TableConditionalFormattingOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableConditionalFormattingOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}