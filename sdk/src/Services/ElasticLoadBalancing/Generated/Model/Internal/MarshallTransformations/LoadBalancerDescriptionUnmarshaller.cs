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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LoadBalancerDescription Object
    /// </summary>  
    public class LoadBalancerDescriptionUnmarshaller : IXmlUnmarshaller<LoadBalancerDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LoadBalancerDescription Unmarshall(XmlUnmarshallerContext context)
        {
            LoadBalancerDescription unmarshalledObject = new LoadBalancerDescription();
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
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("BackendServerDescriptions/member", targetDepth))
                    {
                        var unmarshaller = BackendServerDescriptionUnmarshaller.Instance;
                        if (unmarshalledObject.BackendServerDescriptions == null)
                        {
                            unmarshalledObject.BackendServerDescriptions = new List<BackendServerDescription>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BackendServerDescriptions.Add(item);
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
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DNSName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DNSName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthCheck", targetDepth))
                    {
                        var unmarshaller = HealthCheckUnmarshaller.Instance;
                        unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        var unmarshaller = InstanceUnmarshaller.Instance;
                        if (unmarshalledObject.Instances == null)
                        {
                            unmarshalledObject.Instances = new List<Instance>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Instances.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ListenerDescriptions/member", targetDepth))
                    {
                        var unmarshaller = ListenerDescriptionUnmarshaller.Instance;
                        if (unmarshalledObject.ListenerDescriptions == null)
                        {
                            unmarshalledObject.ListenerDescriptions = new List<ListenerDescription>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ListenerDescriptions.Add(item);
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
                        var unmarshaller = PoliciesUnmarshaller.Instance;
                        unmarshalledObject.Policies = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("SourceSecurityGroup", targetDepth))
                    {
                        var unmarshaller = SourceSecurityGroupUnmarshaller.Instance;
                        unmarshalledObject.SourceSecurityGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Subnets/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Subnets == null)
                        {
                            unmarshalledObject.Subnets = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Subnets.Add(item);
                        continue;
                    }
                    if (context.TestExpression("VPCId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VPCId = unmarshaller.Unmarshall(context);
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

        private static LoadBalancerDescriptionUnmarshaller _instance = new LoadBalancerDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoadBalancerDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}