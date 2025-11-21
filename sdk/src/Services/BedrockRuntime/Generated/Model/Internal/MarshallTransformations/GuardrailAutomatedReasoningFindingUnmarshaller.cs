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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GuardrailAutomatedReasoningFinding Object
    /// </summary>  
    public class GuardrailAutomatedReasoningFindingUnmarshaller : IJsonUnmarshaller<GuardrailAutomatedReasoningFinding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GuardrailAutomatedReasoningFinding Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GuardrailAutomatedReasoningFinding unmarshalledObject = new GuardrailAutomatedReasoningFinding();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("impossible", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningImpossibleFindingUnmarshaller.Instance;
                    unmarshalledObject.Impossible = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("invalid", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningInvalidFindingUnmarshaller.Instance;
                    unmarshalledObject.Invalid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("noTranslations", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningNoTranslationsFindingUnmarshaller.Instance;
                    unmarshalledObject.NoTranslations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("satisfiable", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningSatisfiableFindingUnmarshaller.Instance;
                    unmarshalledObject.Satisfiable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tooComplex", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningTooComplexFindingUnmarshaller.Instance;
                    unmarshalledObject.TooComplex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("translationAmbiguous", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningTranslationAmbiguousFindingUnmarshaller.Instance;
                    unmarshalledObject.TranslationAmbiguous = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("valid", targetDepth))
                {
                    var unmarshaller = GuardrailAutomatedReasoningValidFindingUnmarshaller.Instance;
                    unmarshalledObject.Valid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GuardrailAutomatedReasoningFindingUnmarshaller _instance = new GuardrailAutomatedReasoningFindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GuardrailAutomatedReasoningFindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}