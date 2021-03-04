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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectionAuthResponseParameters Object
    /// </summary>  
    public class ConnectionAuthResponseParametersUnmarshaller : IUnmarshaller<ConnectionAuthResponseParameters, XmlUnmarshallerContext>, IUnmarshaller<ConnectionAuthResponseParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConnectionAuthResponseParameters IUnmarshaller<ConnectionAuthResponseParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConnectionAuthResponseParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConnectionAuthResponseParameters unmarshalledObject = new ConnectionAuthResponseParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApiKeyAuthParameters", targetDepth))
                {
                    var unmarshaller = ConnectionApiKeyAuthResponseParametersUnmarshaller.Instance;
                    unmarshalledObject.ApiKeyAuthParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BasicAuthParameters", targetDepth))
                {
                    var unmarshaller = ConnectionBasicAuthResponseParametersUnmarshaller.Instance;
                    unmarshalledObject.BasicAuthParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationHttpParameters", targetDepth))
                {
                    var unmarshaller = ConnectionHttpParametersUnmarshaller.Instance;
                    unmarshalledObject.InvocationHttpParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OAuthParameters", targetDepth))
                {
                    var unmarshaller = ConnectionOAuthResponseParametersUnmarshaller.Instance;
                    unmarshalledObject.OAuthParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConnectionAuthResponseParametersUnmarshaller _instance = new ConnectionAuthResponseParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectionAuthResponseParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}