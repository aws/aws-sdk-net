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
    /// Response Unmarshaller for XssMatchStatement Object
    /// </summary>  
    public class XssMatchStatementUnmarshaller : IUnmarshaller<XssMatchStatement, XmlUnmarshallerContext>, IUnmarshaller<XssMatchStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        XssMatchStatement IUnmarshaller<XssMatchStatement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public XssMatchStatement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            XssMatchStatement unmarshalledObject = new XssMatchStatement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FieldToMatch", targetDepth))
                {
                    var unmarshaller = FieldToMatchUnmarshaller.Instance;
                    unmarshalledObject.FieldToMatch = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextTransformations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TextTransformation, TextTransformationUnmarshaller>(TextTransformationUnmarshaller.Instance);
                    unmarshalledObject.TextTransformations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static XssMatchStatementUnmarshaller _instance = new XssMatchStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XssMatchStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}