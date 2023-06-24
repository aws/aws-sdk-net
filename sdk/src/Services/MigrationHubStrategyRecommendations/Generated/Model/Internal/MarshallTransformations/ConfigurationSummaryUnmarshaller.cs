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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationSummary Object
    /// </summary>  
    public class ConfigurationSummaryUnmarshaller : IUnmarshaller<ConfigurationSummary, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfigurationSummary IUnmarshaller<ConfigurationSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfigurationSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfigurationSummary unmarshalledObject = new ConfigurationSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ipAddressBasedRemoteInfoList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IPAddressBasedRemoteInfo, IPAddressBasedRemoteInfoUnmarshaller>(IPAddressBasedRemoteInfoUnmarshaller.Instance);
                    unmarshalledObject.IpAddressBasedRemoteInfoList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineInfoList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PipelineInfo, PipelineInfoUnmarshaller>(PipelineInfoUnmarshaller.Instance);
                    unmarshalledObject.PipelineInfoList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remoteSourceCodeAnalysisServerInfo", targetDepth))
                {
                    var unmarshaller = RemoteSourceCodeAnalysisServerInfoUnmarshaller.Instance;
                    unmarshalledObject.RemoteSourceCodeAnalysisServerInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vcenterBasedRemoteInfoList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VcenterBasedRemoteInfo, VcenterBasedRemoteInfoUnmarshaller>(VcenterBasedRemoteInfoUnmarshaller.Instance);
                    unmarshalledObject.VcenterBasedRemoteInfoList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("versionControlInfoList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VersionControlInfo, VersionControlInfoUnmarshaller>(VersionControlInfoUnmarshaller.Instance);
                    unmarshalledObject.VersionControlInfoList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigurationSummaryUnmarshaller _instance = new ConfigurationSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurationSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}