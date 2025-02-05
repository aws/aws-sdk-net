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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LaunchWizard.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.LaunchWizard.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkloadDeploymentPatternData Object
    /// </summary>  
    public class WorkloadDeploymentPatternDataUnmarshaller : IJsonUnmarshaller<WorkloadDeploymentPatternData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkloadDeploymentPatternData Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            WorkloadDeploymentPatternData unmarshalledObject = new WorkloadDeploymentPatternData();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("deploymentPatternName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentPatternName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("specifications", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DeploymentSpecificationsField, DeploymentSpecificationsFieldUnmarshaller>(DeploymentSpecificationsFieldUnmarshaller.Instance);
                    unmarshalledObject.Specifications = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workloadName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkloadName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workloadVersionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkloadVersionName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkloadDeploymentPatternDataUnmarshaller _instance = new WorkloadDeploymentPatternDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkloadDeploymentPatternDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}