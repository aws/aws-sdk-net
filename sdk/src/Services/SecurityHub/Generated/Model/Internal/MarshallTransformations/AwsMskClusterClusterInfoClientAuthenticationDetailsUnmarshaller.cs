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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsMskClusterClusterInfoClientAuthenticationDetails Object
    /// </summary>  
    public class AwsMskClusterClusterInfoClientAuthenticationDetailsUnmarshaller : IUnmarshaller<AwsMskClusterClusterInfoClientAuthenticationDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsMskClusterClusterInfoClientAuthenticationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsMskClusterClusterInfoClientAuthenticationDetails IUnmarshaller<AwsMskClusterClusterInfoClientAuthenticationDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsMskClusterClusterInfoClientAuthenticationDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsMskClusterClusterInfoClientAuthenticationDetails unmarshalledObject = new AwsMskClusterClusterInfoClientAuthenticationDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Sasl", targetDepth))
                {
                    var unmarshaller = AwsMskClusterClusterInfoClientAuthenticationSaslDetailsUnmarshaller.Instance;
                    unmarshalledObject.Sasl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tls", targetDepth))
                {
                    var unmarshaller = AwsMskClusterClusterInfoClientAuthenticationTlsDetailsUnmarshaller.Instance;
                    unmarshalledObject.Tls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unauthenticated", targetDepth))
                {
                    var unmarshaller = AwsMskClusterClusterInfoClientAuthenticationUnauthenticatedDetailsUnmarshaller.Instance;
                    unmarshalledObject.Unauthenticated = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsMskClusterClusterInfoClientAuthenticationDetailsUnmarshaller _instance = new AwsMskClusterClusterInfoClientAuthenticationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsMskClusterClusterInfoClientAuthenticationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}