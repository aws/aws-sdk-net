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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SocialProviderSettings Object
    /// </summary>  
    public class SocialProviderSettingsUnmarshaller : IJsonUnmarshaller<SocialProviderSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SocialProviderSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SocialProviderSettings unmarshalledObject = new SocialProviderSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Facebook", targetDepth))
                {
                    var unmarshaller = BackendAuthSocialProviderConfigUnmarshaller.Instance;
                    unmarshalledObject.Facebook = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Google", targetDepth))
                {
                    var unmarshaller = BackendAuthSocialProviderConfigUnmarshaller.Instance;
                    unmarshalledObject.Google = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoginWithAmazon", targetDepth))
                {
                    var unmarshaller = BackendAuthSocialProviderConfigUnmarshaller.Instance;
                    unmarshalledObject.LoginWithAmazon = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SignInWithApple", targetDepth))
                {
                    var unmarshaller = BackendAuthAppleProviderConfigUnmarshaller.Instance;
                    unmarshalledObject.SignInWithApple = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SocialProviderSettingsUnmarshaller _instance = new SocialProviderSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SocialProviderSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}