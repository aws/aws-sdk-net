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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceDeployment Object
    /// </summary>  
    public class ServiceDeploymentUnmarshaller : IUnmarshaller<ServiceDeployment, XmlUnmarshallerContext>, IUnmarshaller<ServiceDeployment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceDeployment IUnmarshaller<ServiceDeployment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceDeployment Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceDeployment unmarshalledObject = new ServiceDeployment();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alarms", targetDepth))
                {
                    var unmarshaller = ServiceDeploymentAlarmsUnmarshaller.Instance;
                    unmarshalledObject.Alarms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentCircuitBreaker", targetDepth))
                {
                    var unmarshaller = ServiceDeploymentCircuitBreakerUnmarshaller.Instance;
                    unmarshalledObject.DeploymentCircuitBreaker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentConfiguration", targetDepth))
                {
                    var unmarshaller = DeploymentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DeploymentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("finishedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.FinishedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rollback", targetDepth))
                {
                    var unmarshaller = RollbackUnmarshaller.Instance;
                    unmarshalledObject.Rollback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceDeploymentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceDeploymentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServiceRevisions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceRevisionSummary, ServiceRevisionSummaryUnmarshaller>(ServiceRevisionSummaryUnmarshaller.Instance);
                    unmarshalledObject.SourceServiceRevisions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stoppedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StoppedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetServiceRevision", targetDepth))
                {
                    var unmarshaller = ServiceRevisionSummaryUnmarshaller.Instance;
                    unmarshalledObject.TargetServiceRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceDeploymentUnmarshaller _instance = new ServiceDeploymentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceDeploymentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}