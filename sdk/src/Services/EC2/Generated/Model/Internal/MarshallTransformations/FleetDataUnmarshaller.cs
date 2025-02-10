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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FleetData Object
    /// </summary>  
    public class FleetDataUnmarshaller : IXmlUnmarshaller<FleetData, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FleetData Unmarshall(XmlUnmarshallerContext context)
        {
            FleetData unmarshalledObject = new FleetData();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("activityStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("context", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("createTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("errorSet/item", targetDepth))
                    {
                        var unmarshaller = DescribeFleetErrorUnmarshaller.Instance;
                        if (unmarshalledObject.Errors == null)
                        {
                            unmarshalledObject.Errors = new List<DescribeFleetError>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Errors.Add(item);
                        continue;
                    }
                    if (context.TestExpression("excessCapacityTerminationPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExcessCapacityTerminationPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fleetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fleetState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FleetState = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fulfilledCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.FulfilledCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fulfilledOnDemandCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.FulfilledOnDemandCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fleetInstanceSet/item", targetDepth))
                    {
                        var unmarshaller = DescribeFleetsInstancesUnmarshaller.Instance;
                        if (unmarshalledObject.Instances == null)
                        {
                            unmarshalledObject.Instances = new List<DescribeFleetsInstances>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Instances.Add(item);
                        continue;
                    }
                    if (context.TestExpression("launchTemplateConfigs/item", targetDepth))
                    {
                        var unmarshaller = FleetLaunchTemplateConfigUnmarshaller.Instance;
                        if (unmarshalledObject.LaunchTemplateConfigs == null)
                        {
                            unmarshalledObject.LaunchTemplateConfigs = new List<FleetLaunchTemplateConfig>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LaunchTemplateConfigs.Add(item);
                        continue;
                    }
                    if (context.TestExpression("onDemandOptions", targetDepth))
                    {
                        var unmarshaller = OnDemandOptionsUnmarshaller.Instance;
                        unmarshalledObject.OnDemandOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("replaceUnhealthyInstances", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ReplaceUnhealthyInstances = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("spotOptions", targetDepth))
                    {
                        var unmarshaller = SpotOptionsUnmarshaller.Instance;
                        unmarshalledObject.SpotOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("targetCapacitySpecification", targetDepth))
                    {
                        var unmarshaller = TargetCapacitySpecificationUnmarshaller.Instance;
                        unmarshalledObject.TargetCapacitySpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("terminateInstancesWithExpiration", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.TerminateInstancesWithExpiration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("validFrom", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ValidFrom = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("validUntil", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ValidUntil = unmarshaller.Unmarshall(context);
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

        private static FleetDataUnmarshaller _instance = new FleetDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FleetDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}