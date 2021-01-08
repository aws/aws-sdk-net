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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFRegional.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFRegional.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SqlInjectionMatchTuple Object
    /// </summary>  
    public class SqlInjectionMatchTupleUnmarshaller : IUnmarshaller<SqlInjectionMatchTuple, XmlUnmarshallerContext>, IUnmarshaller<SqlInjectionMatchTuple, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SqlInjectionMatchTuple IUnmarshaller<SqlInjectionMatchTuple, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SqlInjectionMatchTuple Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SqlInjectionMatchTuple unmarshalledObject = new SqlInjectionMatchTuple();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FieldToMatch", targetDepth))
                {
                    var unmarshaller = FieldToMatchUnmarshaller.Instance;
                    unmarshalledObject.FieldToMatch = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextTransformation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TextTransformation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SqlInjectionMatchTupleUnmarshaller _instance = new SqlInjectionMatchTupleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SqlInjectionMatchTupleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}