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
    /// Response Unmarshaller for AutomatedReasoningPolicyDefinitionQualityReport Object
    /// </summary>  
    public class AutomatedReasoningPolicyDefinitionQualityReportUnmarshaller : IUnmarshaller<AutomatedReasoningPolicyDefinitionQualityReport, XmlUnmarshallerContext>, IUnmarshaller<AutomatedReasoningPolicyDefinitionQualityReport, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomatedReasoningPolicyDefinitionQualityReport IUnmarshaller<AutomatedReasoningPolicyDefinitionQualityReport, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomatedReasoningPolicyDefinitionQualityReport Unmarshall(JsonUnmarshallerContext context)
        {
            AutomatedReasoningPolicyDefinitionQualityReport unmarshalledObject = new AutomatedReasoningPolicyDefinitionQualityReport();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("conflictingRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ConflictingRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("disjointRuleSets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutomatedReasoningPolicyDisjointRuleSet, AutomatedReasoningPolicyDisjointRuleSetUnmarshaller>(AutomatedReasoningPolicyDisjointRuleSetUnmarshaller.Instance);
                    unmarshalledObject.DisjointRuleSets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ruleCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RuleCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("typeCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TypeCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unusedTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.UnusedTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unusedTypeValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutomatedReasoningPolicyDefinitionTypeValuePair, AutomatedReasoningPolicyDefinitionTypeValuePairUnmarshaller>(AutomatedReasoningPolicyDefinitionTypeValuePairUnmarshaller.Instance);
                    unmarshalledObject.UnusedTypeValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unusedVariables", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.UnusedVariables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variableCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VariableCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomatedReasoningPolicyDefinitionQualityReportUnmarshaller _instance = new AutomatedReasoningPolicyDefinitionQualityReportUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomatedReasoningPolicyDefinitionQualityReportUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}