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
    /// Response Unmarshaller for AwsEc2SecurityGroupDetails Object
    /// </summary>  
    public class AwsEc2SecurityGroupDetailsUnmarshaller : IUnmarshaller<AwsEc2SecurityGroupDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2SecurityGroupDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2SecurityGroupDetails IUnmarshaller<AwsEc2SecurityGroupDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2SecurityGroupDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2SecurityGroupDetails unmarshalledObject = new AwsEc2SecurityGroupDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpPermissions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupIpPermission, AwsEc2SecurityGroupIpPermissionUnmarshaller>(AwsEc2SecurityGroupIpPermissionUnmarshaller.Instance);
                    unmarshalledObject.IpPermissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpPermissionsEgress", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupIpPermission, AwsEc2SecurityGroupIpPermissionUnmarshaller>(AwsEc2SecurityGroupIpPermissionUnmarshaller.Instance);
                    unmarshalledObject.IpPermissionsEgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2SecurityGroupDetailsUnmarshaller _instance = new AwsEc2SecurityGroupDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2SecurityGroupDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}