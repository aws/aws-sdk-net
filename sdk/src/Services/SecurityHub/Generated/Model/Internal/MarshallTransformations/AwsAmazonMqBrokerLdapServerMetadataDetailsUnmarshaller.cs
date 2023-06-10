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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsAmazonMqBrokerLdapServerMetadataDetails Object
    /// </summary>  
    public class AwsAmazonMqBrokerLdapServerMetadataDetailsUnmarshaller : IUnmarshaller<AwsAmazonMqBrokerLdapServerMetadataDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsAmazonMqBrokerLdapServerMetadataDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsAmazonMqBrokerLdapServerMetadataDetails IUnmarshaller<AwsAmazonMqBrokerLdapServerMetadataDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsAmazonMqBrokerLdapServerMetadataDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsAmazonMqBrokerLdapServerMetadataDetails unmarshalledObject = new AwsAmazonMqBrokerLdapServerMetadataDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Hosts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Hosts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleBase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleSearchMatching", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleSearchMatching = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleSearchSubtree", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RoleSearchSubtree = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceAccountUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceAccountUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserBase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserBase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserRoleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserRoleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserSearchMatching", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserSearchMatching = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserSearchSubtree", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UserSearchSubtree = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsAmazonMqBrokerLdapServerMetadataDetailsUnmarshaller _instance = new AwsAmazonMqBrokerLdapServerMetadataDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsAmazonMqBrokerLdapServerMetadataDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}