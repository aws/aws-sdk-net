/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LambdaConfigType Object
    /// </summary>  
    public class LambdaConfigTypeUnmarshaller : IUnmarshaller<LambdaConfigType, XmlUnmarshallerContext>, IUnmarshaller<LambdaConfigType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LambdaConfigType IUnmarshaller<LambdaConfigType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LambdaConfigType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LambdaConfigType unmarshalledObject = new LambdaConfigType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreateAuthChallenge", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateAuthChallenge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefineAuthChallenge", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefineAuthChallenge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostAuthentication", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PostAuthentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostConfirmation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PostConfirmation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreAuthentication", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreAuthentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreSignUp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreSignUp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreTokenGeneration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreTokenGeneration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserMigration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserMigration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerifyAuthChallengeResponse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VerifyAuthChallengeResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LambdaConfigTypeUnmarshaller _instance = new LambdaConfigTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LambdaConfigTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}