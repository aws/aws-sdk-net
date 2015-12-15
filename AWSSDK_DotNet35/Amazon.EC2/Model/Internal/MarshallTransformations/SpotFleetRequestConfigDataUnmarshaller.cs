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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
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
    /// Response Unmarshaller for SpotFleetRequestConfigData Object
    /// </summary>  
    public class SpotFleetRequestConfigDataUnmarshaller : IUnmarshaller<SpotFleetRequestConfigData, XmlUnmarshallerContext>, IUnmarshaller<SpotFleetRequestConfigData, JsonUnmarshallerContext>
    {
        public SpotFleetRequestConfigData Unmarshall(XmlUnmarshallerContext context)
        {
            SpotFleetRequestConfigData unmarshalledObject = new SpotFleetRequestConfigData();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("allocationStrategy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllocationStrategy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("iamFleetRole", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IamFleetRole = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("launchSpecifications/item", targetDepth))
                    {
                        var unmarshaller = SpotFleetLaunchSpecificationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LaunchSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("spotPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("targetCapacity", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.TargetCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("terminateInstancesWithExpiration", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.TerminateInstancesWithExpiration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("validFrom", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ValidFrom = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("validUntil", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
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

        public SpotFleetRequestConfigData Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SpotFleetRequestConfigDataUnmarshaller _instance = new SpotFleetRequestConfigDataUnmarshaller();        

        public static SpotFleetRequestConfigDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}