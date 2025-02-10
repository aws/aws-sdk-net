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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnvironmentResourceDescription Object
    /// </summary>  
    public class EnvironmentResourceDescriptionUnmarshaller : IXmlUnmarshaller<EnvironmentResourceDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EnvironmentResourceDescription Unmarshall(XmlUnmarshallerContext context)
        {
            EnvironmentResourceDescription unmarshalledObject = new EnvironmentResourceDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroups/member", targetDepth))
                    {
                        var unmarshaller = AutoScalingGroupUnmarshaller.Instance;
                        if (unmarshalledObject.AutoScalingGroups == null)
                        {
                            unmarshalledObject.AutoScalingGroups = new List<AutoScalingGroup>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AutoScalingGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("LaunchConfigurations/member", targetDepth))
                    {
                        var unmarshaller = LaunchConfigurationUnmarshaller.Instance;
                        if (unmarshalledObject.LaunchConfigurations == null)
                        {
                            unmarshalledObject.LaunchConfigurations = new List<LaunchConfiguration>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LaunchConfigurations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LaunchTemplates/member", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateUnmarshaller.Instance;
                        if (unmarshalledObject.LaunchTemplates == null)
                        {
                            unmarshalledObject.LaunchTemplates = new List<LaunchTemplate>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LaunchTemplates.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LoadBalancers/member", targetDepth))
                    {
                        var unmarshaller = LoadBalancerUnmarshaller.Instance;
                        if (unmarshalledObject.LoadBalancers == null)
                        {
                            unmarshalledObject.LoadBalancers = new List<LoadBalancer>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LoadBalancers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Queues/member", targetDepth))
                    {
                        var unmarshaller = QueueUnmarshaller.Instance;
                        if (unmarshalledObject.Queues == null)
                        {
                            unmarshalledObject.Queues = new List<Queue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Queues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Triggers/member", targetDepth))
                    {
                        var unmarshaller = TriggerUnmarshaller.Instance;
                        if (unmarshalledObject.Triggers == null)
                        {
                            unmarshalledObject.Triggers = new List<Trigger>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Triggers.Add(item);
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

        private static EnvironmentResourceDescriptionUnmarshaller _instance = new EnvironmentResourceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnvironmentResourceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}