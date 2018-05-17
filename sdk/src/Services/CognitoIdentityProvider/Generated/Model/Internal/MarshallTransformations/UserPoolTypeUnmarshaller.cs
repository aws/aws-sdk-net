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
    /// Response Unmarshaller for UserPoolType Object
    /// </summary>  
    public class UserPoolTypeUnmarshaller : IUnmarshaller<UserPoolType, XmlUnmarshallerContext>, IUnmarshaller<UserPoolType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserPoolType IUnmarshaller<UserPoolType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserPoolType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserPoolType unmarshalledObject = new UserPoolType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdminCreateUserConfig", targetDepth))
                {
                    var unmarshaller = AdminCreateUserConfigTypeUnmarshaller.Instance;
                    unmarshalledObject.AdminCreateUserConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AliasAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AliasAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoVerifiedAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AutoVerifiedAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceConfiguration", targetDepth))
                {
                    var unmarshaller = DeviceConfigurationTypeUnmarshaller.Instance;
                    unmarshalledObject.DeviceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Domain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Domain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailConfiguration", targetDepth))
                {
                    var unmarshaller = EmailConfigurationTypeUnmarshaller.Instance;
                    unmarshalledObject.EmailConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailConfigurationFailure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmailConfigurationFailure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailVerificationMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmailVerificationMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmailVerificationSubject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmailVerificationSubject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedNumberOfUsers", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EstimatedNumberOfUsers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LambdaConfig", targetDepth))
                {
                    var unmarshaller = LambdaConfigTypeUnmarshaller.Instance;
                    unmarshalledObject.LambdaConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MfaConfiguration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MfaConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Policies", targetDepth))
                {
                    var unmarshaller = UserPoolPolicyTypeUnmarshaller.Instance;
                    unmarshalledObject.Policies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SchemaAttributeType, SchemaAttributeTypeUnmarshaller>(SchemaAttributeTypeUnmarshaller.Instance);
                    unmarshalledObject.SchemaAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmsAuthenticationMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SmsAuthenticationMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmsConfiguration", targetDepth))
                {
                    var unmarshaller = SmsConfigurationTypeUnmarshaller.Instance;
                    unmarshalledObject.SmsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmsConfigurationFailure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SmsConfigurationFailure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SmsVerificationMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SmsVerificationMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsernameAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.UsernameAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserPoolAddOns", targetDepth))
                {
                    var unmarshaller = UserPoolAddOnsTypeUnmarshaller.Instance;
                    unmarshalledObject.UserPoolAddOns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserPoolTags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.UserPoolTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerificationMessageTemplate", targetDepth))
                {
                    var unmarshaller = VerificationMessageTemplateTypeUnmarshaller.Instance;
                    unmarshalledObject.VerificationMessageTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserPoolTypeUnmarshaller _instance = new UserPoolTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserPoolTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}