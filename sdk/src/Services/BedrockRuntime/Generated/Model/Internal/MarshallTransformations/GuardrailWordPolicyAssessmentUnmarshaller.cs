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
    /// Response Unmarshaller for GuardrailWordPolicyAssessment Object
    /// </summary>  
    public class GuardrailWordPolicyAssessmentUnmarshaller : IUnmarshaller<GuardrailWordPolicyAssessment, XmlUnmarshallerContext>, IUnmarshaller<GuardrailWordPolicyAssessment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GuardrailWordPolicyAssessment IUnmarshaller<GuardrailWordPolicyAssessment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GuardrailWordPolicyAssessment Unmarshall(JsonUnmarshallerContext context)
        {
            GuardrailWordPolicyAssessment unmarshalledObject = new GuardrailWordPolicyAssessment();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("customWords", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailCustomWord, GuardrailCustomWordUnmarshaller>(GuardrailCustomWordUnmarshaller.Instance);
                    unmarshalledObject.CustomWords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedWordLists", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<GuardrailManagedWord, GuardrailManagedWordUnmarshaller>(GuardrailManagedWordUnmarshaller.Instance);
                    unmarshalledObject.ManagedWordLists = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GuardrailWordPolicyAssessmentUnmarshaller _instance = new GuardrailWordPolicyAssessmentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GuardrailWordPolicyAssessmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}