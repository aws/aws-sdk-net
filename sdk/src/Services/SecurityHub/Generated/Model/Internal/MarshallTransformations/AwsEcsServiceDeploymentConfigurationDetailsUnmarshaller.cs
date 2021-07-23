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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcsServiceDeploymentConfigurationDetails Object
    /// </summary>  
    public class AwsEcsServiceDeploymentConfigurationDetailsUnmarshaller : IUnmarshaller<AwsEcsServiceDeploymentConfigurationDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEcsServiceDeploymentConfigurationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcsServiceDeploymentConfigurationDetails IUnmarshaller<AwsEcsServiceDeploymentConfigurationDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcsServiceDeploymentConfigurationDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcsServiceDeploymentConfigurationDetails unmarshalledObject = new AwsEcsServiceDeploymentConfigurationDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeploymentCircuitBreaker", targetDepth))
                {
                    var unmarshaller = AwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerDetailsUnmarshaller.Instance;
                    unmarshalledObject.DeploymentCircuitBreaker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumPercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumPercent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimumHealthyPercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinimumHealthyPercent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcsServiceDeploymentConfigurationDetailsUnmarshaller _instance = new AwsEcsServiceDeploymentConfigurationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsServiceDeploymentConfigurationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}