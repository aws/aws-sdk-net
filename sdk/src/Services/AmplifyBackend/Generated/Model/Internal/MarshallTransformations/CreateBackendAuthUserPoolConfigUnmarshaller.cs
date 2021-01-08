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
    /// Response Unmarshaller for CreateBackendAuthUserPoolConfig Object
    /// </summary>  
    public class CreateBackendAuthUserPoolConfigUnmarshaller : IUnmarshaller<CreateBackendAuthUserPoolConfig, XmlUnmarshallerContext>, IUnmarshaller<CreateBackendAuthUserPoolConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CreateBackendAuthUserPoolConfig IUnmarshaller<CreateBackendAuthUserPoolConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CreateBackendAuthUserPoolConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CreateBackendAuthUserPoolConfig unmarshalledObject = new CreateBackendAuthUserPoolConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("forgotPassword", targetDepth))
                {
                    var unmarshaller = CreateBackendAuthForgotPasswordConfigUnmarshaller.Instance;
                    unmarshalledObject.ForgotPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mfa", targetDepth))
                {
                    var unmarshaller = CreateBackendAuthMFAConfigUnmarshaller.Instance;
                    unmarshalledObject.Mfa = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oAuth", targetDepth))
                {
                    var unmarshaller = CreateBackendAuthOAuthConfigUnmarshaller.Instance;
                    unmarshalledObject.OAuth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("passwordPolicy", targetDepth))
                {
                    var unmarshaller = CreateBackendAuthPasswordPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.PasswordPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredSignUpAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RequiredSignUpAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signInMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignInMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userPoolName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserPoolName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CreateBackendAuthUserPoolConfigUnmarshaller _instance = new CreateBackendAuthUserPoolConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBackendAuthUserPoolConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}