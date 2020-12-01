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
    /// Response Unmarshaller for BackendAPIAppSyncAuthSettings Object
    /// </summary>  
    public class BackendAPIAppSyncAuthSettingsUnmarshaller : IUnmarshaller<BackendAPIAppSyncAuthSettings, XmlUnmarshallerContext>, IUnmarshaller<BackendAPIAppSyncAuthSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BackendAPIAppSyncAuthSettings IUnmarshaller<BackendAPIAppSyncAuthSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BackendAPIAppSyncAuthSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BackendAPIAppSyncAuthSettings unmarshalledObject = new BackendAPIAppSyncAuthSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cognitoUserPoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CognitoUserPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expirationTime", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ExpirationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDAuthTTL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenIDAuthTTL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDClientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenIDClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDIatTTL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenIDIatTTL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDIssueURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenIDIssueURL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openIDProviderName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpenIDProviderName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BackendAPIAppSyncAuthSettingsUnmarshaller _instance = new BackendAPIAppSyncAuthSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BackendAPIAppSyncAuthSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}