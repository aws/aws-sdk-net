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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceFleet Object
    /// </summary>  
    public class InstanceFleetUnmarshaller : IUnmarshaller<InstanceFleet, XmlUnmarshallerContext>, IUnmarshaller<InstanceFleet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceFleet IUnmarshaller<InstanceFleet, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceFleet Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InstanceFleet unmarshalledObject = new InstanceFleet();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceFleetType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceFleetType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceTypeSpecifications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InstanceTypeSpecification, InstanceTypeSpecificationUnmarshaller>(InstanceTypeSpecificationUnmarshaller.Instance);
                    unmarshalledObject.InstanceTypeSpecifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LaunchSpecifications", targetDepth))
                {
                    var unmarshaller = InstanceFleetProvisioningSpecificationsUnmarshaller.Instance;
                    unmarshalledObject.LaunchSpecifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedOnDemandCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedOnDemandCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedSpotCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedSpotCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResizeSpecifications", targetDepth))
                {
                    var unmarshaller = InstanceFleetResizingSpecificationsUnmarshaller.Instance;
                    unmarshalledObject.ResizeSpecifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = InstanceFleetStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetOnDemandCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TargetOnDemandCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetSpotCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TargetSpotCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceFleetUnmarshaller _instance = new InstanceFleetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceFleetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}