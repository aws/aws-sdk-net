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
    /// Response Unmarshaller for AwsEc2SubnetDetails Object
    /// </summary>  
    public class AwsEc2SubnetDetailsUnmarshaller : IJsonUnmarshaller<AwsEc2SubnetDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsEc2SubnetDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsEc2SubnetDetails unmarshalledObject = new AwsEc2SubnetDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AssignIpv6AddressOnCreation", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AssignIpv6AddressOnCreation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailabilityZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailableIpAddressCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AvailableIpAddressCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DefaultForAz", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DefaultForAz = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Ipv6CidrBlockAssociationSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Ipv6CidrBlockAssociation, Ipv6CidrBlockAssociationUnmarshaller>(Ipv6CidrBlockAssociationUnmarshaller.Instance);
                    unmarshalledObject.Ipv6CidrBlockAssociationSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MapPublicIpOnLaunch", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.MapPublicIpOnLaunch = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubnetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsEc2SubnetDetailsUnmarshaller _instance = new AwsEc2SubnetDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2SubnetDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}