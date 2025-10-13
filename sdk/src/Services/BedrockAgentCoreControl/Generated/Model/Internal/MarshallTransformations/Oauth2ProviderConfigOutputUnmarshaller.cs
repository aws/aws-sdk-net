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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Oauth2ProviderConfigOutput Object
    /// </summary>  
    public class Oauth2ProviderConfigOutputUnmarshaller : IUnmarshaller<Oauth2ProviderConfigOutput, XmlUnmarshallerContext>, IUnmarshaller<Oauth2ProviderConfigOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Oauth2ProviderConfigOutput IUnmarshaller<Oauth2ProviderConfigOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Oauth2ProviderConfigOutput Unmarshall(JsonUnmarshallerContext context)
        {
            Oauth2ProviderConfigOutput unmarshalledObject = new Oauth2ProviderConfigOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("atlassianOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = AtlassianOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.AtlassianOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = CustomOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.CustomOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("githubOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = GithubOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.GithubOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("googleOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = GoogleOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.GoogleOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("includedOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = IncludedOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.IncludedOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linkedinOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = LinkedinOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.LinkedinOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("microsoftOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = MicrosoftOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("salesforceOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = SalesforceOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.SalesforceOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slackOauth2ProviderConfig", targetDepth))
                {
                    var unmarshaller = SlackOauth2ProviderConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.SlackOauth2ProviderConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Oauth2ProviderConfigOutputUnmarshaller _instance = new Oauth2ProviderConfigOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Oauth2ProviderConfigOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}