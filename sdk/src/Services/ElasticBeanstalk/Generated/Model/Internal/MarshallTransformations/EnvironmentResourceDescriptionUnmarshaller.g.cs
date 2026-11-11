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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnvironmentResourceDescription Object
    /// </summary>
    public partial class EnvironmentResourceDescriptionUnmarshaller : IXmlUnmarshaller<EnvironmentResourceDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public EnvironmentResourceDescription Unmarshall(XmlUnmarshallerContext context)
        {
            EnvironmentResourceDescription unmarshalledObject = new EnvironmentResourceDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroups/member", targetDepth))
                    {
                        if (unmarshalledObject.AutoScalingGroups == null)
                        {
                            unmarshalledObject.AutoScalingGroups = new List<AutoScalingGroup>();
                        }
                        var unmarshaller = AutoScalingGroupUnmarshaller.Instance;
                        unmarshalledObject.AutoScalingGroups.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Cluster", targetDepth))
                    {
                        var unmarshaller = ClusterUnmarshaller.Instance;
                        unmarshalledObject.Cluster = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.Instances == null)
                        {
                            unmarshalledObject.Instances = new List<Instance>();
                        }
                        var unmarshaller = InstanceUnmarshaller.Instance;
                        unmarshalledObject.Instances.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("LaunchConfigurations/member", targetDepth))
                    {
                        if (unmarshalledObject.LaunchConfigurations == null)
                        {
                            unmarshalledObject.LaunchConfigurations = new List<LaunchConfiguration>();
                        }
                        var unmarshaller = LaunchConfigurationUnmarshaller.Instance;
                        unmarshalledObject.LaunchConfigurations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("LaunchTemplates/member", targetDepth))
                    {
                        if (unmarshalledObject.LaunchTemplates == null)
                        {
                            unmarshalledObject.LaunchTemplates = new List<LaunchTemplate>();
                        }
                        var unmarshaller = LaunchTemplateUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplates.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("LoadBalancers/member", targetDepth))
                    {
                        if (unmarshalledObject.LoadBalancers == null)
                        {
                            unmarshalledObject.LoadBalancers = new List<LoadBalancer>();
                        }
                        var unmarshaller = LoadBalancerUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancers.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Queues/member", targetDepth))
                    {
                        if (unmarshalledObject.Queues == null)
                        {
                            unmarshalledObject.Queues = new List<Queue>();
                        }
                        var unmarshaller = QueueUnmarshaller.Instance;
                        unmarshalledObject.Queues.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Triggers/member", targetDepth))
                    {
                        if (unmarshalledObject.Triggers == null)
                        {
                            unmarshalledObject.Triggers = new List<Trigger>();
                        }
                        var unmarshaller = TriggerUnmarshaller.Instance;
                        unmarshalledObject.Triggers.Add(unmarshaller.Unmarshall(context));
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
        public static EnvironmentResourceDescriptionUnmarshaller Instance => _instance;
    }
}
