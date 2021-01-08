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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserIdentity Object
    /// </summary>  
    public class UserIdentityUnmarshaller : IUnmarshaller<UserIdentity, XmlUnmarshallerContext>, IUnmarshaller<UserIdentity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserIdentity IUnmarshaller<UserIdentity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserIdentity Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserIdentity unmarshalledObject = new UserIdentity();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("assumedRole", targetDepth))
                {
                    var unmarshaller = AssumedRoleUnmarshaller.Instance;
                    unmarshalledObject.AssumedRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsAccount", targetDepth))
                {
                    var unmarshaller = AwsAccountUnmarshaller.Instance;
                    unmarshalledObject.AwsAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsService", targetDepth))
                {
                    var unmarshaller = AwsServiceUnmarshaller.Instance;
                    unmarshalledObject.AwsService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("federatedUser", targetDepth))
                {
                    var unmarshaller = FederatedUserUnmarshaller.Instance;
                    unmarshalledObject.FederatedUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamUser", targetDepth))
                {
                    var unmarshaller = IamUserUnmarshaller.Instance;
                    unmarshalledObject.IamUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("root", targetDepth))
                {
                    var unmarshaller = UserIdentityRootUnmarshaller.Instance;
                    unmarshalledObject.Root = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserIdentityUnmarshaller _instance = new UserIdentityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserIdentityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}