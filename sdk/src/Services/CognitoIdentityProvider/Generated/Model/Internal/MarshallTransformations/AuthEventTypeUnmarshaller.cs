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
    /// Response Unmarshaller for AuthEventType Object
    /// </summary>  
    public class AuthEventTypeUnmarshaller : IUnmarshaller<AuthEventType, XmlUnmarshallerContext>, IUnmarshaller<AuthEventType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AuthEventType IUnmarshaller<AuthEventType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AuthEventType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AuthEventType unmarshalledObject = new AuthEventType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChallengeResponses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChallengeResponseType, ChallengeResponseTypeUnmarshaller>(ChallengeResponseTypeUnmarshaller.Instance);
                    unmarshalledObject.ChallengeResponses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventContextData", targetDepth))
                {
                    var unmarshaller = EventContextDataTypeUnmarshaller.Instance;
                    unmarshalledObject.EventContextData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventFeedback", targetDepth))
                {
                    var unmarshaller = EventFeedbackTypeUnmarshaller.Instance;
                    unmarshalledObject.EventFeedback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventResponse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventRisk", targetDepth))
                {
                    var unmarshaller = EventRiskTypeUnmarshaller.Instance;
                    unmarshalledObject.EventRisk = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AuthEventTypeUnmarshaller _instance = new AuthEventTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthEventTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}