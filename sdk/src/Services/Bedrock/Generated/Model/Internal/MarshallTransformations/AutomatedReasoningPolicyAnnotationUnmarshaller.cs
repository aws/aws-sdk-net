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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomatedReasoningPolicyAnnotation Object
    /// </summary>  
    public class AutomatedReasoningPolicyAnnotationUnmarshaller : IUnmarshaller<AutomatedReasoningPolicyAnnotation, XmlUnmarshallerContext>, IUnmarshaller<AutomatedReasoningPolicyAnnotation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomatedReasoningPolicyAnnotation IUnmarshaller<AutomatedReasoningPolicyAnnotation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomatedReasoningPolicyAnnotation Unmarshall(JsonUnmarshallerContext context)
        {
            AutomatedReasoningPolicyAnnotation unmarshalledObject = new AutomatedReasoningPolicyAnnotation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addRule", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyAddRuleAnnotationUnmarshaller.Instance;
                    unmarshalledObject.AddRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("addRuleFromNaturalLanguage", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotationUnmarshaller.Instance;
                    unmarshalledObject.AddRuleFromNaturalLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("addType", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyAddTypeAnnotationUnmarshaller.Instance;
                    unmarshalledObject.AddType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("addVariable", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyAddVariableAnnotationUnmarshaller.Instance;
                    unmarshalledObject.AddVariable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteRule", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyDeleteRuleAnnotationUnmarshaller.Instance;
                    unmarshalledObject.DeleteRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteType", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyDeleteTypeAnnotationUnmarshaller.Instance;
                    unmarshalledObject.DeleteType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteVariable", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyDeleteVariableAnnotationUnmarshaller.Instance;
                    unmarshalledObject.DeleteVariable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingestContent", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyIngestContentAnnotationUnmarshaller.Instance;
                    unmarshalledObject.IngestContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateFromRulesFeedback", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateFromRuleFeedbackAnnotationUnmarshaller.Instance;
                    unmarshalledObject.UpdateFromRulesFeedback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateFromScenarioFeedback", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateFromScenarioFeedbackAnnotationUnmarshaller.Instance;
                    unmarshalledObject.UpdateFromScenarioFeedback = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateRule", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateRuleAnnotationUnmarshaller.Instance;
                    unmarshalledObject.UpdateRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateType", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateTypeAnnotationUnmarshaller.Instance;
                    unmarshalledObject.UpdateType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateVariable", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyUpdateVariableAnnotationUnmarshaller.Instance;
                    unmarshalledObject.UpdateVariable = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomatedReasoningPolicyAnnotationUnmarshaller _instance = new AutomatedReasoningPolicyAnnotationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomatedReasoningPolicyAnnotationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}