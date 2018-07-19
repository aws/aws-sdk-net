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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponseLaunchTemplateData Object
    /// </summary>  
    public class ResponseLaunchTemplateDataUnmarshaller : IUnmarshaller<ResponseLaunchTemplateData, XmlUnmarshallerContext>, IUnmarshaller<ResponseLaunchTemplateData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseLaunchTemplateData Unmarshall(XmlUnmarshallerContext context)
        {
            ResponseLaunchTemplateData unmarshalledObject = new ResponseLaunchTemplateData();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("blockDeviceMappingSet/item", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateBlockDeviceMappingUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("cpuOptions", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateCpuOptionsUnmarshaller.Instance;
                        unmarshalledObject.CpuOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("creditSpecification", targetDepth))
                    {
                        var unmarshaller = CreditSpecificationUnmarshaller.Instance;
                        unmarshalledObject.CreditSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("disableApiTermination", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.DisableApiTermination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("elasticGpuSpecificationSet/item", targetDepth))
                    {
                        var unmarshaller = ElasticGpuSpecificationResponseUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ElasticGpuSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("iamInstanceProfile", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateIamInstanceProfileSpecificationUnmarshaller.Instance;
                        unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceInitiatedShutdownBehavior", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceInitiatedShutdownBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceMarketOptions", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateInstanceMarketOptionsUnmarshaller.Instance;
                        unmarshalledObject.InstanceMarketOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("keyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KeyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("monitoring", targetDepth))
                    {
                        var unmarshaller = LaunchTemplatesMonitoringUnmarshaller.Instance;
                        unmarshalledObject.Monitoring = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceSet/item", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateInstanceNetworkInterfaceSpecificationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkInterfaces.Add(item);
                        continue;
                    }
                    if (context.TestExpression("placement", targetDepth))
                    {
                        var unmarshaller = LaunchTemplatePlacementUnmarshaller.Instance;
                        unmarshalledObject.Placement = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ramDiskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamDiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupIdSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroupIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("securityGroupSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tagSpecificationSet/item", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateTagSpecificationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("userData", targetDepth))
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseLaunchTemplateData Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ResponseLaunchTemplateDataUnmarshaller _instance = new ResponseLaunchTemplateDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseLaunchTemplateDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}