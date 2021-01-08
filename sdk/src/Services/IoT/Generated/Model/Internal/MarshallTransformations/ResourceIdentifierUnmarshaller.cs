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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceIdentifier Object
    /// </summary>  
    public class ResourceIdentifierUnmarshaller : IUnmarshaller<ResourceIdentifier, XmlUnmarshallerContext>, IUnmarshaller<ResourceIdentifier, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceIdentifier IUnmarshaller<ResourceIdentifier, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceIdentifier Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceIdentifier unmarshalledObject = new ResourceIdentifier();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("account", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Account = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("caCertificateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaCertificateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cognitoIdentityPoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CognitoIdentityPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceCertificateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeviceCertificateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("policyVersionIdentifier", targetDepth))
                {
                    var unmarshaller = PolicyVersionIdentifierUnmarshaller.Instance;
                    unmarshalledObject.PolicyVersionIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleAliasArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleAliasArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceIdentifierUnmarshaller _instance = new ResourceIdentifierUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceIdentifierUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}