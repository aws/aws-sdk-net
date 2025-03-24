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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LoadBalancer Object
    /// </summary>  
    public class LoadBalancerUnmarshaller : IXmlUnmarshaller<LoadBalancer, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LoadBalancer Unmarshall(XmlUnmarshallerContext context)
        {
            LoadBalancer unmarshalledObject = new LoadBalancer();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        var unmarshaller = AvailabilityZoneUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<AvailabilityZone>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CanonicalHostedZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CanonicalHostedZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomerOwnedIpv4Pool", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomerOwnedIpv4Pool = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DNSName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DNSName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnablePrefixForIpv6SourceNat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EnablePrefixForIpv6SourceNat = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IpAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IpamPools", targetDepth))
                    {
                        var unmarshaller = IpamPoolsUnmarshaller.Instance;
                        unmarshalledObject.IpamPools = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LoadBalancerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LoadBalancerName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Scheme", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Scheme = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SecurityGroups/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SecurityGroups == null)
                        {
                            unmarshalledObject.SecurityGroups = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("State", targetDepth))
                    {
                        var unmarshaller = LoadBalancerStateUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static LoadBalancerUnmarshaller _instance = new LoadBalancerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoadBalancerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}