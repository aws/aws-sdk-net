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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExpenseDocument Object
    /// </summary>  
    public class ExpenseDocumentUnmarshaller : IUnmarshaller<ExpenseDocument, XmlUnmarshallerContext>, IUnmarshaller<ExpenseDocument, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ExpenseDocument IUnmarshaller<ExpenseDocument, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ExpenseDocument Unmarshall(JsonUnmarshallerContext context)
        {
            ExpenseDocument unmarshalledObject = new ExpenseDocument();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Blocks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Block, BlockUnmarshaller>(BlockUnmarshaller.Instance);
                    unmarshalledObject.Blocks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpenseIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExpenseIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineItemGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LineItemGroup, LineItemGroupUnmarshaller>(LineItemGroupUnmarshaller.Instance);
                    unmarshalledObject.LineItemGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SummaryFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpenseField, ExpenseFieldUnmarshaller>(ExpenseFieldUnmarshaller.Instance);
                    unmarshalledObject.SummaryFields = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExpenseDocumentUnmarshaller _instance = new ExpenseDocumentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpenseDocumentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618