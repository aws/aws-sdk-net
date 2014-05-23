/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnvironmentResourceDescription Object
    /// </summary>  
    public class EnvironmentResourceDescriptionUnmarshaller : IUnmarshaller<EnvironmentResourceDescription, XmlUnmarshallerContext>, IUnmarshaller<EnvironmentResourceDescription, JsonUnmarshallerContext>
    {
        public EnvironmentResourceDescription Unmarshall(XmlUnmarshallerContext context)
        {
            EnvironmentResourceDescription unmarshalledObject = new EnvironmentResourceDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroups/member", targetDepth))
                    {
                        var unmarshaller = AutoScalingGroupUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AutoScalingGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Instances/member", targetDepth))
                    {
                        var unmarshaller = InstanceUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Instances.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurations/member", targetDepth))
                    {
                        var unmarshaller = LaunchConfigurationUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LaunchConfigurations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LoadBalancers/member", targetDepth))
                    {
                        var unmarshaller = LoadBalancerUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LoadBalancers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Queues/member", targetDepth))
                    {
                        var unmarshaller = QueueUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Queues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Triggers/member", targetDepth))
                    {
                        var unmarshaller = TriggerUnmarshaller.GetInstance();
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

        public EnvironmentResourceDescription Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static EnvironmentResourceDescriptionUnmarshaller instance;
        public static EnvironmentResourceDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new EnvironmentResourceDescriptionUnmarshaller();
            }
            return instance;
        }

    }
}