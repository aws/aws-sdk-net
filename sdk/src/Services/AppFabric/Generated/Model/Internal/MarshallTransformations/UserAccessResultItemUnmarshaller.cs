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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppFabric.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserAccessResultItem Object
    /// </summary>  
    public class UserAccessResultItemUnmarshaller : IUnmarshaller<UserAccessResultItem, XmlUnmarshallerContext>, IUnmarshaller<UserAccessResultItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserAccessResultItem IUnmarshaller<UserAccessResultItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserAccessResultItem Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserAccessResultItem unmarshalledObject = new UserAccessResultItem();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("app", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.App = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("email", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Email = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resultStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskError", targetDepth))
                {
                    var unmarshaller = TaskErrorUnmarshaller.Instance;
                    unmarshalledObject.TaskError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tenantDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TenantDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tenantId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TenantId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userFirstName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserFirstName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userFullName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserFullName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userLastName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserLastName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserAccessResultItemUnmarshaller _instance = new UserAccessResultItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserAccessResultItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}