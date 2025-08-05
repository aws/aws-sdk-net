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
    /// Response Unmarshaller for GuardrailAutomatedReasoningTranslation Object
    /// </summary>  
    public class GuardrailAutomatedReasoningTranslationUnmarshaller : IUnmarshaller<GuardrailAutomatedReasoningTranslation, XmlUnmarshallerContext>, IUnmarshaller<GuardrailAutomatedReasoningTranslation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GuardrailAutomatedReasoningTranslation IUnmarshaller<GuardrailAutomatedReasoningTranslation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GuardrailAutomatedReasoningTranslation Unmarshall(JsonUnmarshallerContext context)
        {
            GuardrailAutomatedReasoningTranslation unmarshalledObject = new GuardrailAutomatedReasoningTranslation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("claims", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningStatement, GuardrailAutomatedReasoningStatementUnmarshaller>(GuardrailAutomatedReasoningStatementUnmarshaller.Instance);
                    unmarshalledObject.Claims = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("confidence", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("premises", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningStatement, GuardrailAutomatedReasoningStatementUnmarshaller>(GuardrailAutomatedReasoningStatementUnmarshaller.Instance);
                    unmarshalledObject.Premises = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("untranslatedClaims", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningInputTextReference, GuardrailAutomatedReasoningInputTextReferenceUnmarshaller>(GuardrailAutomatedReasoningInputTextReferenceUnmarshaller.Instance);
                    unmarshalledObject.UntranslatedClaims = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("untranslatedPremises", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailAutomatedReasoningInputTextReference, GuardrailAutomatedReasoningInputTextReferenceUnmarshaller>(GuardrailAutomatedReasoningInputTextReferenceUnmarshaller.Instance);
                    unmarshalledObject.UntranslatedPremises = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GuardrailAutomatedReasoningTranslationUnmarshaller _instance = new GuardrailAutomatedReasoningTranslationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GuardrailAutomatedReasoningTranslationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}