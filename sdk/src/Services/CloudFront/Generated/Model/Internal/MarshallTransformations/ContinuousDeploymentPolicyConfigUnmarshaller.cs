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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContinuousDeploymentPolicyConfig Object
    /// </summary>  
    public class ContinuousDeploymentPolicyConfigUnmarshaller : IXmlUnmarshaller<ContinuousDeploymentPolicyConfig, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ContinuousDeploymentPolicyConfig Unmarshall(XmlUnmarshallerContext context)
        {
            ContinuousDeploymentPolicyConfig unmarshalledObject = new ContinuousDeploymentPolicyConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StagingDistributionDnsNames", targetDepth))
                    {
                        var unmarshaller = StagingDistributionDnsNamesUnmarshaller.Instance;
                        unmarshalledObject.StagingDistributionDnsNames = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrafficConfig", targetDepth))
                    {
                        var unmarshaller = TrafficConfigUnmarshaller.Instance;
                        unmarshalledObject.TrafficConfig = unmarshaller.Unmarshall(context);
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
        private static ContinuousDeploymentPolicyConfigUnmarshaller _instance = new ContinuousDeploymentPolicyConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContinuousDeploymentPolicyConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}