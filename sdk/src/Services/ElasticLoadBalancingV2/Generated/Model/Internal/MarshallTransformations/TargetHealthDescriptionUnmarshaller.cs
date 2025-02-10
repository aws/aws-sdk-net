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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetHealthDescription Object
    /// </summary>  
    public class TargetHealthDescriptionUnmarshaller : IXmlUnmarshaller<TargetHealthDescription, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TargetHealthDescription Unmarshall(XmlUnmarshallerContext context)
        {
            TargetHealthDescription unmarshalledObject = new TargetHealthDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdministrativeOverride", targetDepth))
                    {
                        var unmarshaller = AdministrativeOverrideUnmarshaller.Instance;
                        unmarshalledObject.AdministrativeOverride = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AnomalyDetection", targetDepth))
                    {
                        var unmarshaller = AnomalyDetectionUnmarshaller.Instance;
                        unmarshalledObject.AnomalyDetection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthCheckPort", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckPort = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Target", targetDepth))
                    {
                        var unmarshaller = TargetDescriptionUnmarshaller.Instance;
                        unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetHealth", targetDepth))
                    {
                        var unmarshaller = TargetHealthUnmarshaller.Instance;
                        unmarshalledObject.TargetHealth = unmarshaller.Unmarshall(context);
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

        private static TargetHealthDescriptionUnmarshaller _instance = new TargetHealthDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetHealthDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}