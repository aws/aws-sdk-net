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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BlueGreenDeploymentConfiguration Object
    /// </summary>  
    public class BlueGreenDeploymentConfigurationUnmarshaller : IUnmarshaller<BlueGreenDeploymentConfiguration, XmlUnmarshallerContext>, IUnmarshaller<BlueGreenDeploymentConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BlueGreenDeploymentConfiguration IUnmarshaller<BlueGreenDeploymentConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BlueGreenDeploymentConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BlueGreenDeploymentConfiguration unmarshalledObject = new BlueGreenDeploymentConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("deploymentReadyOption", targetDepth))
                {
                    var unmarshaller = DeploymentReadyOptionUnmarshaller.Instance;
                    unmarshalledObject.DeploymentReadyOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("greenFleetProvisioningOption", targetDepth))
                {
                    var unmarshaller = GreenFleetProvisioningOptionUnmarshaller.Instance;
                    unmarshalledObject.GreenFleetProvisioningOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("terminateBlueInstancesOnDeploymentSuccess", targetDepth))
                {
                    var unmarshaller = BlueInstanceTerminationOptionUnmarshaller.Instance;
                    unmarshalledObject.TerminateBlueInstancesOnDeploymentSuccess = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BlueGreenDeploymentConfigurationUnmarshaller _instance = new BlueGreenDeploymentConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BlueGreenDeploymentConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}