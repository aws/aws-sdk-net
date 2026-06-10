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
    /// Response Unmarshaller for AwsElbLoadBalancerDetails Object
    /// </summary>  
    public class AwsElbLoadBalancerDetailsUnmarshaller : IJsonUnmarshaller<AwsElbLoadBalancerDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsElbLoadBalancerDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsElbLoadBalancerDetails unmarshalledObject = new AwsElbLoadBalancerDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AvailabilityZones", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BackendServerDescriptions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsElbLoadBalancerBackendServerDescription, AwsElbLoadBalancerBackendServerDescriptionUnmarshaller>(AwsElbLoadBalancerBackendServerDescriptionUnmarshaller.Instance);
                    unmarshalledObject.BackendServerDescriptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CanonicalHostedZoneName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanonicalHostedZoneName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CanonicalHostedZoneNameID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanonicalHostedZoneNameID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HealthCheck", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbLoadBalancerHealthCheckUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Instances", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsElbLoadBalancerInstance, AwsElbLoadBalancerInstanceUnmarshaller>(AwsElbLoadBalancerInstanceUnmarshaller.Instance);
                    unmarshalledObject.Instances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ListenerDescriptions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsElbLoadBalancerListenerDescription, AwsElbLoadBalancerListenerDescriptionUnmarshaller>(AwsElbLoadBalancerListenerDescriptionUnmarshaller.Instance);
                    unmarshalledObject.ListenerDescriptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoadBalancerAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbLoadBalancerAttributesUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoadBalancerName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Policies", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbLoadBalancerPoliciesUnmarshaller.Instance;
                    unmarshalledObject.Policies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Scheme", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scheme = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceSecurityGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbLoadBalancerSourceSecurityGroupUnmarshaller.Instance;
                    unmarshalledObject.SourceSecurityGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Subnets", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Subnets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context, ref reader);
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