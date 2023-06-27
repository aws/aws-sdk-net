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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SAPODataConnectorProfileProperties Object
    /// </summary>  
    public class SAPODataConnectorProfilePropertiesUnmarshaller : IUnmarshaller<SAPODataConnectorProfileProperties, XmlUnmarshallerContext>, IUnmarshaller<SAPODataConnectorProfileProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SAPODataConnectorProfileProperties IUnmarshaller<SAPODataConnectorProfileProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SAPODataConnectorProfileProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SAPODataConnectorProfileProperties unmarshalledObject = new SAPODataConnectorProfileProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applicationHostUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationHostUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applicationServicePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationServicePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("disableSSO", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableSSO = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logonLanguage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogonLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oAuthProperties", targetDepth))
                {
                    var unmarshaller = OAuthPropertiesUnmarshaller.Instance;
                    unmarshalledObject.OAuthProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portNumber", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PortNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("privateLinkServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateLinkServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SAPODataConnectorProfilePropertiesUnmarshaller _instance = new SAPODataConnectorProfilePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SAPODataConnectorProfilePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}