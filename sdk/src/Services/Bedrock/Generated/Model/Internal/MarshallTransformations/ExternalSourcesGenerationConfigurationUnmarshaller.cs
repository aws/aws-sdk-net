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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExternalSourcesGenerationConfiguration Object
    /// </summary>  
    public class ExternalSourcesGenerationConfigurationUnmarshaller : IJsonUnmarshaller<ExternalSourcesGenerationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ExternalSourcesGenerationConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ExternalSourcesGenerationConfiguration unmarshalledObject = new ExternalSourcesGenerationConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalModelRequestFields", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Amazon.Runtime.Documents.Document, StringUnmarshaller, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(StringUnmarshaller.Instance, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance);
                    unmarshalledObject.AdditionalModelRequestFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("guardrailConfiguration", targetDepth))
                {
                    var unmarshaller = GuardrailConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GuardrailConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kbInferenceConfig", targetDepth))
                {
                    var unmarshaller = KbInferenceConfigUnmarshaller.Instance;
                    unmarshalledObject.KbInferenceConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("promptTemplate", targetDepth))
                {
                    var unmarshaller = PromptTemplateUnmarshaller.Instance;
                    unmarshalledObject.PromptTemplate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExternalSourcesGenerationConfigurationUnmarshaller _instance = new ExternalSourcesGenerationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExternalSourcesGenerationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}