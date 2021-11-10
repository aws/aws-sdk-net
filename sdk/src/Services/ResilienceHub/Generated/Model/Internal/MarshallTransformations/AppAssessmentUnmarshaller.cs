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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AppAssessment Object
    /// </summary>  
    public class AppAssessmentUnmarshaller : IUnmarshaller<AppAssessment, XmlUnmarshallerContext>, IUnmarshaller<AppAssessment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AppAssessment IUnmarshaller<AppAssessment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AppAssessment Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AppAssessment unmarshalledObject = new AppAssessment();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("appVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compliance", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, DisruptionCompliance, StringUnmarshaller, DisruptionComplianceUnmarshaller>(StringUnmarshaller.Instance, DisruptionComplianceUnmarshaller.Instance);
                    unmarshalledObject.Compliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("complianceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComplianceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cost", targetDepth))
                {
                    var unmarshaller = CostUnmarshaller.Instance;
                    unmarshalledObject.Cost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("invoker", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Invoker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("policy", targetDepth))
                {
                    var unmarshaller = ResiliencyPolicyUnmarshaller.Instance;
                    unmarshalledObject.Policy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resiliencyScore", targetDepth))
                {
                    var unmarshaller = ResiliencyScoreUnmarshaller.Instance;
                    unmarshalledObject.ResiliencyScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AppAssessmentUnmarshaller _instance = new AppAssessmentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AppAssessmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}