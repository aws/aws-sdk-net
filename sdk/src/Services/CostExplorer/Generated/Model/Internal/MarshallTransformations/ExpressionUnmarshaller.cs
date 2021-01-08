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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Expression Object
    /// </summary>  
    public class ExpressionUnmarshaller : IUnmarshaller<Expression, XmlUnmarshallerContext>, IUnmarshaller<Expression, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Expression IUnmarshaller<Expression, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Expression Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Expression unmarshalledObject = new Expression();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("And", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Expression, ExpressionUnmarshaller>(ExpressionUnmarshaller.Instance);
                    unmarshalledObject.And = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CostCategories", targetDepth))
                {
                    var unmarshaller = CostCategoryValuesUnmarshaller.Instance;
                    unmarshalledObject.CostCategories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dimensions", targetDepth))
                {
                    var unmarshaller = DimensionValuesUnmarshaller.Instance;
                    unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Not", targetDepth))
                {
                    var unmarshaller = ExpressionUnmarshaller.Instance;
                    unmarshalledObject.Not = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Or", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Expression, ExpressionUnmarshaller>(ExpressionUnmarshaller.Instance);
                    unmarshalledObject.Or = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = TagValuesUnmarshaller.Instance;
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ExpressionUnmarshaller _instance = new ExpressionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpressionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}