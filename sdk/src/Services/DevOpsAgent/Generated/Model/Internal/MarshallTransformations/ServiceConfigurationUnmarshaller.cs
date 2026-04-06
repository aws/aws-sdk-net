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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceConfiguration Object
    /// </summary>  
    public class ServiceConfigurationUnmarshaller : IJsonUnmarshaller<ServiceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ServiceConfiguration unmarshalledObject = new ServiceConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("aws", targetDepth))
                {
                    var unmarshaller = AWSConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Aws = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("azure", targetDepth))
                {
                    var unmarshaller = AzureConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Azure = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("azuredevops", targetDepth))
                {
                    var unmarshaller = AzureDevOpsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Azuredevops = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynatrace", targetDepth))
                {
                    var unmarshaller = DynatraceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Dynatrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventChannel", targetDepth))
                {
                    var unmarshaller = EventChannelConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EventChannel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("github", targetDepth))
                {
                    var unmarshaller = GitHubConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Github = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gitlab", targetDepth))
                {
                    var unmarshaller = GitLabConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Gitlab = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpservergrafana", targetDepth))
                {
                    var unmarshaller = MCPServerGrafanaConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Mcpservergrafana = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpservernewrelic", targetDepth))
                {
                    var unmarshaller = MCPServerNewRelicConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Mcpservernewrelic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pagerduty", targetDepth))
                {
                    var unmarshaller = PagerDutyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Pagerduty = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("servicenow", targetDepth))
                {
                    var unmarshaller = ServiceNowConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Servicenow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slack", targetDepth))
                {
                    var unmarshaller = SlackConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Slack = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sourceAws", targetDepth))
                {
                    var unmarshaller = SourceAwsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SourceAws = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceConfigurationUnmarshaller _instance = new ServiceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}