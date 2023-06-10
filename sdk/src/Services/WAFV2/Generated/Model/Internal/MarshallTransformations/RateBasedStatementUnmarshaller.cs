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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RateBasedStatement Object
    /// </summary>  
    public class RateBasedStatementUnmarshaller : IUnmarshaller<RateBasedStatement, XmlUnmarshallerContext>, IUnmarshaller<RateBasedStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RateBasedStatement IUnmarshaller<RateBasedStatement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RateBasedStatement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RateBasedStatement unmarshalledObject = new RateBasedStatement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AggregateKeyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregateKeyType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RateBasedStatementCustomKey, RateBasedStatementCustomKeyUnmarshaller>(RateBasedStatementCustomKeyUnmarshaller.Instance);
                    unmarshalledObject.CustomKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ForwardedIPConfig", targetDepth))
                {
                    var unmarshaller = ForwardedIPConfigUnmarshaller.Instance;
                    unmarshalledObject.ForwardedIPConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Limit", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Limit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScopeDownStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    unmarshalledObject.ScopeDownStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RateBasedStatementUnmarshaller _instance = new RateBasedStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RateBasedStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}