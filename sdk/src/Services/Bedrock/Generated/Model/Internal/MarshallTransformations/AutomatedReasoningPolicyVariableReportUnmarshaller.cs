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
    /// Response Unmarshaller for AutomatedReasoningPolicyVariableReport Object
    /// </summary>  
    public class AutomatedReasoningPolicyVariableReportUnmarshaller : IUnmarshaller<AutomatedReasoningPolicyVariableReport, XmlUnmarshallerContext>, IUnmarshaller<AutomatedReasoningPolicyVariableReport, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomatedReasoningPolicyVariableReport IUnmarshaller<AutomatedReasoningPolicyVariableReport, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomatedReasoningPolicyVariableReport Unmarshall(JsonUnmarshallerContext context)
        {
            AutomatedReasoningPolicyVariableReport unmarshalledObject = new AutomatedReasoningPolicyVariableReport();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accuracyJustification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccuracyJustification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("accuracyScore", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.AccuracyScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("groundingJustifications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GroundingJustifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("groundingStatements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutomatedReasoningPolicyStatementReference, AutomatedReasoningPolicyStatementReferenceUnmarshaller>(AutomatedReasoningPolicyStatementReferenceUnmarshaller.Instance);
                    unmarshalledObject.GroundingStatements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("policyVariable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyVariable = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomatedReasoningPolicyVariableReportUnmarshaller _instance = new AutomatedReasoningPolicyVariableReportUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomatedReasoningPolicyVariableReportUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}