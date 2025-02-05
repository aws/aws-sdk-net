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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PolicyComplianceStatus Object
    /// </summary>  
    public class PolicyComplianceStatusUnmarshaller : IJsonUnmarshaller<PolicyComplianceStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PolicyComplianceStatus Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PolicyComplianceStatus unmarshalledObject = new PolicyComplianceStatus();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EvaluationResults", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EvaluationResult, EvaluationResultUnmarshaller>(EvaluationResultUnmarshaller.Instance);
                    unmarshalledObject.EvaluationResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IssueInfoMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.IssueInfoMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastUpdated", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MemberAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MemberAccount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyOwner = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PolicyComplianceStatusUnmarshaller _instance = new PolicyComplianceStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicyComplianceStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}