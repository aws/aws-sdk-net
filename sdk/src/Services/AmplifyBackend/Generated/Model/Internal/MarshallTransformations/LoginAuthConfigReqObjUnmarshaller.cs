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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LoginAuthConfigReqObj Object
    /// </summary>  
    public class LoginAuthConfigReqObjUnmarshaller : IUnmarshaller<LoginAuthConfigReqObj, XmlUnmarshallerContext>, IUnmarshaller<LoginAuthConfigReqObj, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LoginAuthConfigReqObj IUnmarshaller<LoginAuthConfigReqObj, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LoginAuthConfigReqObj Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LoginAuthConfigReqObj unmarshalledObject = new LoginAuthConfigReqObj();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aws_cognito_identity_pool_id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsCognitoIdentityPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aws_cognito_region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsCognitoRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aws_user_pools_id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsUserPoolsId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aws_user_pools_web_client_id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsUserPoolsWebClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LoginAuthConfigReqObjUnmarshaller _instance = new LoginAuthConfigReqObjUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoginAuthConfigReqObjUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}