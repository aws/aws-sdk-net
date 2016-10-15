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
    /// Response Unmarshaller for AdminCreateUserConfigType Object
    /// </summary>  
    public class AdminCreateUserConfigTypeUnmarshaller : IUnmarshaller<AdminCreateUserConfigType, XmlUnmarshallerContext>, IUnmarshaller<AdminCreateUserConfigType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AdminCreateUserConfigType IUnmarshaller<AdminCreateUserConfigType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AdminCreateUserConfigType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AdminCreateUserConfigType unmarshalledObject = new AdminCreateUserConfigType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowAdminCreateUserOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowAdminCreateUserOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InviteMessageTemplate", targetDepth))
                {
                    var unmarshaller = MessageTemplateTypeUnmarshaller.Instance;
                    unmarshalledObject.InviteMessageTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnusedAccountValidityDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UnusedAccountValidityDays = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AdminCreateUserConfigTypeUnmarshaller _instance = new AdminCreateUserConfigTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminCreateUserConfigTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}