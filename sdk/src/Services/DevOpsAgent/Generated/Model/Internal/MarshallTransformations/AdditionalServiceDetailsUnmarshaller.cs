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
    /// Response Unmarshaller for AdditionalServiceDetails Object
    /// </summary>  
    public class AdditionalServiceDetailsUnmarshaller : IJsonUnmarshaller<AdditionalServiceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AdditionalServiceDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AdditionalServiceDetails unmarshalledObject = new AdditionalServiceDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("azuredevops", targetDepth))
                {
                    var unmarshaller = RegisteredAzureDevOpsServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.Azuredevops = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("azureidentity", targetDepth))
                {
                    var unmarshaller = RegisteredAzureIdentityDetailsUnmarshaller.Instance;
                    unmarshalledObject.Azureidentity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("github", targetDepth))
                {
                    var unmarshaller = RegisteredGithubServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.Github = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gitlab", targetDepth))
                {
                    var unmarshaller = RegisteredGitLabServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.Gitlab = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpserver", targetDepth))
                {
                    var unmarshaller = RegisteredMCPServerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpserver = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpserverdatadog", targetDepth))
                {
                    var unmarshaller = RegisteredMCPServerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpserverdatadog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpservergrafana", targetDepth))
                {
                    var unmarshaller = RegisteredGrafanaServerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpservergrafana = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpservernewrelic", targetDepth))
                {
                    var unmarshaller = RegisteredNewRelicDetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpservernewrelic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpserversigv4", targetDepth))
                {
                    var unmarshaller = RegisteredMCPServerSigV4DetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpserversigv4 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mcpserversplunk", targetDepth))
                {
                    var unmarshaller = RegisteredMCPServerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Mcpserversplunk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pagerduty", targetDepth))
                {
                    var unmarshaller = RegisteredPagerDutyDetailsUnmarshaller.Instance;
                    unmarshalledObject.Pagerduty = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("servicenow", targetDepth))
                {
                    var unmarshaller = RegisteredServiceNowDetailsUnmarshaller.Instance;
                    unmarshalledObject.Servicenow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slack", targetDepth))
                {
                    var unmarshaller = RegisteredSlackServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.Slack = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AdditionalServiceDetailsUnmarshaller _instance = new AdditionalServiceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdditionalServiceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}