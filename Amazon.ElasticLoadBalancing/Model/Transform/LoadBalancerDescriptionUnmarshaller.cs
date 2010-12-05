/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Transform
{
     /// <summary>
     ///   LoadBalancerDescription Unmarshaller
     /// </summary>
    internal class LoadBalancerDescriptionUnmarshaller : IUnmarshaller<LoadBalancerDescription, UnmarshallerContext> 
    {
        public LoadBalancerDescription Unmarshall(UnmarshallerContext context) 
        {
            LoadBalancerDescription loadBalancerDescription = new LoadBalancerDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("LoadBalancerName", targetDepth))
                    {
                        loadBalancerDescription.LoadBalancerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DNSName", targetDepth))
                    {
                        loadBalancerDescription.DNSName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ListenerDescriptions/member", targetDepth))
                    {
                        loadBalancerDescription.ListenerDescriptions.Add(ListenerDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Policies", targetDepth))
                    {
                        loadBalancerDescription.Policies = PoliciesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        loadBalancerDescription.AvailabilityZones.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        loadBalancerDescription.Instances.Add(InstanceUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("HealthCheck", targetDepth))
                    {
                        loadBalancerDescription.HealthCheck = HealthCheckUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        loadBalancerDescription.CreatedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return loadBalancerDescription;
                }
            }

            return loadBalancerDescription;
        }

        private static LoadBalancerDescriptionUnmarshaller instance;

        public static LoadBalancerDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LoadBalancerDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
