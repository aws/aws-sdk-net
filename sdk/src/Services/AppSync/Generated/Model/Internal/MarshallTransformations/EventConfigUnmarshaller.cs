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

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventConfig Object
    /// </summary>  
    public class EventConfigUnmarshaller : IUnmarshaller<EventConfig, XmlUnmarshallerContext>, IUnmarshaller<EventConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EventConfig IUnmarshaller<EventConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EventConfig Unmarshall(JsonUnmarshallerContext context)
        {
            EventConfig unmarshalledObject = new EventConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authProviders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthProvider, AuthProviderUnmarshaller>(AuthProviderUnmarshaller.Instance);
                    unmarshalledObject.AuthProviders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionAuthModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthMode, AuthModeUnmarshaller>(AuthModeUnmarshaller.Instance);
                    unmarshalledObject.ConnectionAuthModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultPublishAuthModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthMode, AuthModeUnmarshaller>(AuthModeUnmarshaller.Instance);
                    unmarshalledObject.DefaultPublishAuthModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultSubscribeAuthModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthMode, AuthModeUnmarshaller>(AuthModeUnmarshaller.Instance);
                    unmarshalledObject.DefaultSubscribeAuthModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logConfig", targetDepth))
                {
                    var unmarshaller = EventLogConfigUnmarshaller.Instance;
                    unmarshalledObject.LogConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EventConfigUnmarshaller _instance = new EventConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EventConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}