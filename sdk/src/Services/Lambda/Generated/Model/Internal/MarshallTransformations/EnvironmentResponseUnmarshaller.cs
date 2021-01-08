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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnvironmentResponse Object
    /// </summary>  
    public class EnvironmentResponseUnmarshaller : IUnmarshaller<EnvironmentResponse, XmlUnmarshallerContext>, IUnmarshaller<EnvironmentResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EnvironmentResponse IUnmarshaller<EnvironmentResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EnvironmentResponse Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EnvironmentResponse unmarshalledObject = new EnvironmentResponse();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Error", targetDepth))
                {
                    var unmarshaller = EnvironmentErrorUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Variables", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EnvironmentResponseUnmarshaller _instance = new EnvironmentResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnvironmentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}