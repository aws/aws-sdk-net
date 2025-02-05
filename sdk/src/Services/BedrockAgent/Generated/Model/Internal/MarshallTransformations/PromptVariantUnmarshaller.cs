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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PromptVariant Object
    /// </summary>  
    public class PromptVariantUnmarshaller : IJsonUnmarshaller<PromptVariant, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PromptVariant Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PromptVariant unmarshalledObject = new PromptVariant();
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
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.AdditionalModelRequestFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("genAiResource", targetDepth))
                {
                    var unmarshaller = PromptGenAiResourceUnmarshaller.Instance;
                    unmarshalledObject.GenAiResource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inferenceConfiguration", targetDepth))
                {
                    var unmarshaller = PromptInferenceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.InferenceConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("metadata", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PromptMetadataEntry, PromptMetadataEntryUnmarshaller>(PromptMetadataEntryUnmarshaller.Instance);
                    unmarshalledObject.Metadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("templateConfiguration", targetDepth))
                {
                    var unmarshaller = PromptTemplateConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TemplateConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("templateType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PromptVariantUnmarshaller _instance = new PromptVariantUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PromptVariantUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}