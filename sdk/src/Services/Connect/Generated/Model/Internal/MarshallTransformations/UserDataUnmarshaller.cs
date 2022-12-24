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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserData Object
    /// </summary>  
    public class UserDataUnmarshaller : IUnmarshaller<UserData, XmlUnmarshallerContext>, IUnmarshaller<UserData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserData IUnmarshaller<UserData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserData unmarshalledObject = new UserData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActiveSlotsByChannel", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    unmarshalledObject.ActiveSlotsByChannel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailableSlotsByChannel", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    unmarshalledObject.AvailableSlotsByChannel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Contacts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AgentContactReference, AgentContactReferenceUnmarshaller>(AgentContactReferenceUnmarshaller.Instance);
                    unmarshalledObject.Contacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HierarchyPath", targetDepth))
                {
                    var unmarshaller = HierarchyPathReferenceUnmarshaller.Instance;
                    unmarshalledObject.HierarchyPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxSlotsByChannel", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    unmarshalledObject.MaxSlotsByChannel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NextStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingProfile", targetDepth))
                {
                    var unmarshaller = RoutingProfileReferenceUnmarshaller.Instance;
                    unmarshalledObject.RoutingProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = AgentStatusReferenceUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("User", targetDepth))
                {
                    var unmarshaller = UserReferenceUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserDataUnmarshaller _instance = new UserDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}