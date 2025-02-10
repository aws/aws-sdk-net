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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManualSearchAIAgentConfiguration Object
    /// </summary>  
    public class ManualSearchAIAgentConfigurationUnmarshaller : IJsonUnmarshaller<ManualSearchAIAgentConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ManualSearchAIAgentConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ManualSearchAIAgentConfiguration unmarshalledObject = new ManualSearchAIAgentConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("answerGenerationAIGuardrailId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnswerGenerationAIGuardrailId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("answerGenerationAIPromptId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnswerGenerationAIPromptId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associationConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssociationConfiguration, AssociationConfigurationUnmarshaller>(AssociationConfigurationUnmarshaller.Instance);
                    unmarshalledObject.AssociationConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("locale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Locale = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManualSearchAIAgentConfigurationUnmarshaller _instance = new ManualSearchAIAgentConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManualSearchAIAgentConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}