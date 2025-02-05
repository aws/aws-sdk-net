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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2SecurityGroupIpPermission Object
    /// </summary>  
    public class AwsEc2SecurityGroupIpPermissionUnmarshaller : IJsonUnmarshaller<AwsEc2SecurityGroupIpPermission, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2SecurityGroupIpPermission Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2SecurityGroupIpPermission unmarshalledObject = new AwsEc2SecurityGroupIpPermission();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("FromPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FromPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IpProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpProtocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IpRanges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2SecurityGroupIpRange, AwsEc2SecurityGroupIpRangeUnmarshaller>(AwsEc2SecurityGroupIpRangeUnmarshaller.Instance);
                    unmarshalledObject.IpRanges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6Ranges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2SecurityGroupIpv6Range, AwsEc2SecurityGroupIpv6RangeUnmarshaller>(AwsEc2SecurityGroupIpv6RangeUnmarshaller.Instance);
                    unmarshalledObject.Ipv6Ranges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrefixListIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2SecurityGroupPrefixListId, AwsEc2SecurityGroupPrefixListIdUnmarshaller>(AwsEc2SecurityGroupPrefixListIdUnmarshaller.Instance);
                    unmarshalledObject.PrefixListIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ToPort", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ToPort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UserIdGroupPairs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsEc2SecurityGroupUserIdGroupPair, AwsEc2SecurityGroupUserIdGroupPairUnmarshaller>(AwsEc2SecurityGroupUserIdGroupPairUnmarshaller.Instance);
                    unmarshalledObject.UserIdGroupPairs = unmarshaller.Unmarshall(context, ref reader);
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