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
    /// Response Unmarshaller for AutomatedReasoningPolicyTestResult Object
    /// </summary>  
    public class AutomatedReasoningPolicyTestResultUnmarshaller : IUnmarshaller<AutomatedReasoningPolicyTestResult, XmlUnmarshallerContext>, IUnmarshaller<AutomatedReasoningPolicyTestResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomatedReasoningPolicyTestResult IUnmarshaller<AutomatedReasoningPolicyTestResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomatedReasoningPolicyTestResult Unmarshall(JsonUnmarshallerContext context)
        {
            AutomatedReasoningPolicyTestResult unmarshalledObject = new AutomatedReasoningPolicyTestResult();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aggregatedTestFindingsResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AggregatedTestFindingsResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("policyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testCase", targetDepth))
                {
                    var unmarshaller = AutomatedReasoningPolicyTestCaseUnmarshaller.Instance;
                    unmarshalledObject.TestCase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutomatedReasoningCheckFinding, AutomatedReasoningCheckFindingUnmarshaller>(AutomatedReasoningCheckFindingUnmarshaller.Instance);
                    unmarshalledObject.TestFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testRunResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TestRunResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testRunStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TestRunStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomatedReasoningPolicyTestResultUnmarshaller _instance = new AutomatedReasoningPolicyTestResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomatedReasoningPolicyTestResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}