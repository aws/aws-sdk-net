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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeploymentStageStatusSummary Object
    /// </summary>  
    public class DeploymentStageStatusSummaryUnmarshaller : IUnmarshaller<DeploymentStageStatusSummary, XmlUnmarshallerContext>, IUnmarshaller<DeploymentStageStatusSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DeploymentStageStatusSummary IUnmarshaller<DeploymentStageStatusSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DeploymentStageStatusSummary Unmarshall(JsonUnmarshallerContext context)
        {
            DeploymentStageStatusSummary unmarshalledObject = new DeploymentStageStatusSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeploymentConfig", targetDepth))
                {
                    var unmarshaller = EdgeDeploymentConfigUnmarshaller.Instance;
                    unmarshalledObject.DeploymentConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentStatus", targetDepth))
                {
                    var unmarshaller = EdgeDeploymentStatusUnmarshaller.Instance;
                    unmarshalledObject.DeploymentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceSelectionConfig", targetDepth))
                {
                    var unmarshaller = DeviceSelectionConfigUnmarshaller.Instance;
                    unmarshalledObject.DeviceSelectionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DeploymentStageStatusSummaryUnmarshaller _instance = new DeploymentStageStatusSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeploymentStageStatusSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}