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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LdapServerMetadataOutput Object
    /// </summary>  
    public class LdapServerMetadataOutputUnmarshaller : IUnmarshaller<LdapServerMetadataOutput, XmlUnmarshallerContext>, IUnmarshaller<LdapServerMetadataOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LdapServerMetadataOutput IUnmarshaller<LdapServerMetadataOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LdapServerMetadataOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LdapServerMetadataOutput unmarshalledObject = new LdapServerMetadataOutput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("hosts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Hosts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleBase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleSearchMatching", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleSearchMatching = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleSearchSubtree", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RoleSearchSubtree = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceAccountUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceAccountUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userBase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userRoleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserRoleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userSearchMatching", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserSearchMatching = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userSearchSubtree", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UserSearchSubtree = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LdapServerMetadataOutputUnmarshaller _instance = new LdapServerMetadataOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LdapServerMetadataOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}