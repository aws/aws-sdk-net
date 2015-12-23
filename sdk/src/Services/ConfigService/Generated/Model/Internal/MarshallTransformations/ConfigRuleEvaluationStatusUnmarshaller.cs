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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigRuleEvaluationStatus Object
    /// </summary>  
    public class ConfigRuleEvaluationStatusUnmarshaller : IUnmarshaller<ConfigRuleEvaluationStatus, XmlUnmarshallerContext>, IUnmarshaller<ConfigRuleEvaluationStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfigRuleEvaluationStatus IUnmarshaller<ConfigRuleEvaluationStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfigRuleEvaluationStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfigRuleEvaluationStatus unmarshalledObject = new ConfigRuleEvaluationStatus();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConfigRuleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfigRuleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigRuleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfigRuleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigRuleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfigRuleName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstActivatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.FirstActivatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirstEvaluationStarted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FirstEvaluationStarted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastErrorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastFailedEvaluationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastFailedEvaluationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastFailedInvocationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastFailedInvocationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSuccessfulEvaluationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulEvaluationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSuccessfulInvocationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulInvocationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigRuleEvaluationStatusUnmarshaller _instance = new ConfigRuleEvaluationStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigRuleEvaluationStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}