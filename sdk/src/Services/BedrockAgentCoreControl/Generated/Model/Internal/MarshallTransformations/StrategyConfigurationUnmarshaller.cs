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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StrategyConfiguration Object
    /// </summary>  
    public class StrategyConfigurationUnmarshaller : IUnmarshaller<StrategyConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StrategyConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StrategyConfiguration IUnmarshaller<StrategyConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StrategyConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            StrategyConfiguration unmarshalledObject = new StrategyConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("consolidation", targetDepth))
                {
                    var unmarshaller = ConsolidationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Consolidation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extraction", targetDepth))
                {
                    var unmarshaller = ExtractionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Extraction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("selfManagedConfiguration", targetDepth))
                {
                    var unmarshaller = SelfManagedConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SelfManagedConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StrategyConfigurationUnmarshaller _instance = new StrategyConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StrategyConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}