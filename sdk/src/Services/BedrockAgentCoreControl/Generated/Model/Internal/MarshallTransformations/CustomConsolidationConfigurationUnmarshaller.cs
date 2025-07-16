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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomConsolidationConfiguration Object
    /// </summary>  
    public class CustomConsolidationConfigurationUnmarshaller : IJsonUnmarshaller<CustomConsolidationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CustomConsolidationConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CustomConsolidationConfiguration unmarshalledObject = new CustomConsolidationConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("semanticConsolidationOverride", targetDepth))
                {
                    var unmarshaller = SemanticConsolidationOverrideUnmarshaller.Instance;
                    unmarshalledObject.SemanticConsolidationOverride = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("summaryConsolidationOverride", targetDepth))
                {
                    var unmarshaller = SummaryConsolidationOverrideUnmarshaller.Instance;
                    unmarshalledObject.SummaryConsolidationOverride = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("userPreferenceConsolidationOverride", targetDepth))
                {
                    var unmarshaller = UserPreferenceConsolidationOverrideUnmarshaller.Instance;
                    unmarshalledObject.UserPreferenceConsolidationOverride = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CustomConsolidationConfigurationUnmarshaller _instance = new CustomConsolidationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomConsolidationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}