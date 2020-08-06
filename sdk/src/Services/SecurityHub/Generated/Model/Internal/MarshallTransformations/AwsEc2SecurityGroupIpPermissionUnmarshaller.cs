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
    /// Response Unmarshaller for AwsEc2SecurityGroupIpPermission Object
    /// </summary>  
    public class AwsEc2SecurityGroupIpPermissionUnmarshaller : IUnmarshaller<AwsEc2SecurityGroupIpPermission, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2SecurityGroupIpPermission, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2SecurityGroupIpPermission IUnmarshaller<AwsEc2SecurityGroupIpPermission, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2SecurityGroupIpPermission Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2SecurityGroupIpPermission unmarshalledObject = new AwsEc2SecurityGroupIpPermission();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FromPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FromPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpRanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupIpRange, AwsEc2SecurityGroupIpRangeUnmarshaller>(AwsEc2SecurityGroupIpRangeUnmarshaller.Instance);
                    unmarshalledObject.IpRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ipv6Ranges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupIpv6Range, AwsEc2SecurityGroupIpv6RangeUnmarshaller>(AwsEc2SecurityGroupIpv6RangeUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Ranges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrefixListIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupPrefixListId, AwsEc2SecurityGroupPrefixListIdUnmarshaller>(AwsEc2SecurityGroupPrefixListIdUnmarshaller.Instance);
                    unmarshalledObject.PrefixListIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ToPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ToPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserIdGroupPairs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2SecurityGroupUserIdGroupPair, AwsEc2SecurityGroupUserIdGroupPairUnmarshaller>(AwsEc2SecurityGroupUserIdGroupPairUnmarshaller.Instance);
                    unmarshalledObject.UserIdGroupPairs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2SecurityGroupIpPermissionUnmarshaller _instance = new AwsEc2SecurityGroupIpPermissionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2SecurityGroupIpPermissionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}