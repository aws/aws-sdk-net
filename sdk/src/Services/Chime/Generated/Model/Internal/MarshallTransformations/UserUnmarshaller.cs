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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for User Object
    /// </summary>  
    public class UserUnmarshaller : IUnmarshaller<User, XmlUnmarshallerContext>, IUnmarshaller<User, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        User IUnmarshaller<User, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public User Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            User unmarshalledObject = new User();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvitedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.InvitedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PersonalPIN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PersonalPIN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegisteredOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RegisteredOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserInvitationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserInvitationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserRegistrationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserRegistrationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserUnmarshaller _instance = new UserUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}