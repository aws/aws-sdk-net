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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostOptimizationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ec2AutoScalingGroupConfiguration Object
    /// </summary>  
    public class Ec2AutoScalingGroupConfigurationUnmarshaller : IUnmarshaller<Ec2AutoScalingGroupConfiguration, XmlUnmarshallerContext>, IUnmarshaller<Ec2AutoScalingGroupConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Ec2AutoScalingGroupConfiguration IUnmarshaller<Ec2AutoScalingGroupConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Ec2AutoScalingGroupConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            Ec2AutoScalingGroupConfiguration unmarshalledObject = new Ec2AutoScalingGroupConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allocationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllocationStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instance", targetDepth))
                {
                    var unmarshaller = InstanceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Instance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mixedInstances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MixedInstanceConfiguration, MixedInstanceConfigurationUnmarshaller>(MixedInstanceConfigurationUnmarshaller.Instance);
                    unmarshalledObject.MixedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Ec2AutoScalingGroupConfigurationUnmarshaller _instance = new Ec2AutoScalingGroupConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ec2AutoScalingGroupConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}