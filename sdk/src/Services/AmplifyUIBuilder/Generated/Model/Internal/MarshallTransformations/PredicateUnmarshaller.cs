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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Predicate Object
    /// </summary>  
    public class PredicateUnmarshaller : IUnmarshaller<Predicate, XmlUnmarshallerContext>, IUnmarshaller<Predicate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Predicate IUnmarshaller<Predicate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Predicate Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Predicate unmarshalledObject = new Predicate();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("and", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Predicate, PredicateUnmarshaller>(PredicateUnmarshaller.Instance);
                    unmarshalledObject.And = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("field", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Field = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operand", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operand = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operandType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperandType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("operator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("or", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Predicate, PredicateUnmarshaller>(PredicateUnmarshaller.Instance);
                    unmarshalledObject.Or = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PredicateUnmarshaller _instance = new PredicateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredicateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}