/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentRunAgent Object
    /// </summary>  
    public class AssessmentRunAgentUnmarshaller : IUnmarshaller<AssessmentRunAgent, XmlUnmarshallerContext>, IUnmarshaller<AssessmentRunAgent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssessmentRunAgent IUnmarshaller<AssessmentRunAgent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssessmentRunAgent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssessmentRunAgent unmarshalledObject = new AssessmentRunAgent();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentHealth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentHealth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentHealthCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentHealthCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentHealthDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentHealthDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("agentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentRunArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentRunArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoScalingGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("telemetryMetadata", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TelemetryMetadata, TelemetryMetadataUnmarshaller>(TelemetryMetadataUnmarshaller.Instance);
                    unmarshalledObject.TelemetryMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssessmentRunAgentUnmarshaller _instance = new AssessmentRunAgentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssessmentRunAgentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}