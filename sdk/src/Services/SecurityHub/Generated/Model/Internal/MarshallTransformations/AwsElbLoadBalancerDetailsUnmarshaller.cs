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
    /// Response Unmarshaller for AwsElbLoadBalancerDetails Object
    /// </summary>  
    public class AwsElbLoadBalancerDetailsUnmarshaller : IUnmarshaller<AwsElbLoadBalancerDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsElbLoadBalancerDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsElbLoadBalancerDetails IUnmarshaller<AwsElbLoadBalancerDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsElbLoadBalancerDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsElbLoadBalancerDetails unmarshalledObject = new AwsElbLoadBalancerDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AvailabilityZones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackendServerDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsElbLoadBalancerBackendServerDescription, AwsElbLoadBalancerBackendServerDescriptionUnmarshaller>(AwsElbLoadBalancerBackendServerDescriptionUnmarshaller.Instance);
                    unmarshalledObject.BackendServerDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CanonicalHostedZoneName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanonicalHostedZoneName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CanonicalHostedZoneNameID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanonicalHostedZoneNameID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthCheck", targetDepth))
                {
                    var unmarshaller = AwsElbLoadBalancerHealthCheckUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Instances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsElbLoadBalancerInstance, AwsElbLoadBalancerInstanceUnmarshaller>(AwsElbLoadBalancerInstanceUnmarshaller.Instance);
                    unmarshalledObject.Instances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListenerDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsElbLoadBalancerListenerDescription, AwsElbLoadBalancerListenerDescriptionUnmarshaller>(AwsElbLoadBalancerListenerDescriptionUnmarshaller.Instance);
                    unmarshalledObject.ListenerDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoadBalancerAttributes", targetDepth))
                {
                    var unmarshaller = AwsElbLoadBalancerAttributesUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoadBalancerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Policies", targetDepth))
                {
                    var unmarshaller = AwsElbLoadBalancerPoliciesUnmarshaller.Instance;
                    unmarshalledObject.Policies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Scheme", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scheme = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceSecurityGroup", targetDepth))
                {
                    var unmarshaller = AwsElbLoadBalancerSourceSecurityGroupUnmarshaller.Instance;
                    unmarshalledObject.SourceSecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subnets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Subnets = unmarshaller.Unmarshall(context);
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


        private static AwsElbLoadBalancerDetailsUnmarshaller _instance = new AwsElbLoadBalancerDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsElbLoadBalancerDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}