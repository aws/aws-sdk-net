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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AdditionalAuthenticationProvider Object
    /// </summary>  
    public class AdditionalAuthenticationProviderUnmarshaller : IUnmarshaller<AdditionalAuthenticationProvider, XmlUnmarshallerContext>, IUnmarshaller<AdditionalAuthenticationProvider, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AdditionalAuthenticationProvider IUnmarshaller<AdditionalAuthenticationProvider, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AdditionalAuthenticationProvider Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AdditionalAuthenticationProvider unmarshalledObject = new AdditionalAuthenticationProvider();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authenticationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthenticationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDConnectConfig", targetDepth))
                {
                    var unmarshaller = OpenIDConnectConfigUnmarshaller.Instance;
                    unmarshalledObject.OpenIDConnectConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userPoolConfig", targetDepth))
                {
                    var unmarshaller = CognitoUserPoolConfigUnmarshaller.Instance;
                    unmarshalledObject.UserPoolConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AdditionalAuthenticationProviderUnmarshaller _instance = new AdditionalAuthenticationProviderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdditionalAuthenticationProviderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}