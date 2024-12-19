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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchConfiguration Object
    /// </summary>  
    public class LaunchConfigurationUnmarshaller : IXmlUnmarshaller<LaunchConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            LaunchConfiguration unmarshalledObject = new LaunchConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AssociatePublicIpAddress", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BlockDeviceMappings/member", targetDepth))
                    {
                        var unmarshaller = BlockDeviceMappingUnmarshaller.Instance;
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<BlockDeviceMapping>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ClassicLinkVPCId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClassicLinkVPCId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClassicLinkVPCSecurityGroups/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ClassicLinkVPCSecurityGroups == null)
                        {
                            unmarshalledObject.ClassicLinkVPCSecurityGroups = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ClassicLinkVPCSecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EbsOptimized", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IamInstanceProfile", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceMonitoring", targetDepth))
                    {
                        var unmarshaller = InstanceMonitoringUnmarshaller.Instance;
                        unmarshalledObject.InstanceMonitoring = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KernelId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KeyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KeyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurationARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LaunchConfigurationARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LaunchConfigurationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MetadataOptions", targetDepth))
                    {
                        var unmarshaller = InstanceMetadataOptionsUnmarshaller.Instance;
                        unmarshalledObject.MetadataOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PlacementTenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlacementTenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RamdiskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("SpotPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserData", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserData = unmarshaller.Unmarshall(context);
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

        private static LaunchConfigurationUnmarshaller _instance = new LaunchConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}