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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Textract.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExpenseField Object
    /// </summary>  
    public class ExpenseFieldUnmarshaller : IJsonUnmarshaller<ExpenseField, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ExpenseField Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ExpenseField unmarshalledObject = new ExpenseField();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Currency", targetDepth))
                {
                    var unmarshaller = ExpenseCurrencyUnmarshaller.Instance;
                    unmarshalledObject.Currency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GroupProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ExpenseGroupProperty, ExpenseGroupPropertyUnmarshaller>(ExpenseGroupPropertyUnmarshaller.Instance);
                    unmarshalledObject.GroupProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelDetection", targetDepth))
                {
                    var unmarshaller = ExpenseDetectionUnmarshaller.Instance;
                    unmarshalledObject.LabelDetection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PageNumber", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PageNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = ExpenseTypeUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ValueDetection", targetDepth))
                {
                    var unmarshaller = ExpenseDetectionUnmarshaller.Instance;
                    unmarshalledObject.ValueDetection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExpenseFieldUnmarshaller _instance = new ExpenseFieldUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpenseFieldUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}