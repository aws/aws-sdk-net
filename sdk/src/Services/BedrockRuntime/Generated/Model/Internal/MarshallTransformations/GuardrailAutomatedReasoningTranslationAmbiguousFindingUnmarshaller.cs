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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GuardrailAutomatedReasoningTranslationAmbiguousFinding Object
    /// </summary>  
    public class GuardrailAutomatedReasoningTranslationAmbiguousFindingUnmarshaller : IUnmarshaller<GuardrailAutomatedReasoningTranslationAmbiguousFinding, XmlUnmarshallerContext>, IUnmarshaller<GuardrailAutomatedReasoningTranslationAmbiguousFinding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GuardrailAutomatedReasoningTranslationAmbiguousFinding IUnmarshaller<GuardrailAutomatedReasoningTranslationAmbiguousFinding, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GuardrailAutomatedReasoningTranslationAmbiguousFinding Unmarshall(JsonUnmarshallerContext context)
        {
            GuardrailAutomatedReasoningTranslationAmbiguousFinding unmarshalledObject = new GuardrailAutomatedReasoningTranslationAmbiguousFinding();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("differenceScenarios", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningScenario, GuardrailAutomatedReasoningScenarioUnmarshaller>(GuardrailAutomatedReasoningScenarioUnmarshaller.Instance);
                    unmarshalledObject.DifferenceScenarios = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("options", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningTranslationOption, GuardrailAutomatedReasoningTranslationOptionUnmarshaller>(GuardrailAutomatedReasoningTranslationOptionUnmarshaller.Instance);
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GuardrailAutomatedReasoningTranslationAmbiguousFindingUnmarshaller _instance = new GuardrailAutomatedReasoningTranslationAmbiguousFindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GuardrailAutomatedReasoningTranslationAmbiguousFindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}