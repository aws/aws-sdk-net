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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AIGuardrailData Object
    /// </summary>  
    public class AIGuardrailDataUnmarshaller : IUnmarshaller<AIGuardrailData, XmlUnmarshallerContext>, IUnmarshaller<AIGuardrailData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AIGuardrailData IUnmarshaller<AIGuardrailData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AIGuardrailData Unmarshall(JsonUnmarshallerContext context)
        {
            AIGuardrailData unmarshalledObject = new AIGuardrailData();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aiGuardrailArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AiGuardrailArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("aiGuardrailId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AiGuardrailId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assistantArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssistantArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assistantId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssistantId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockedInputMessaging", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockedInputMessaging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockedOutputsMessaging", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockedOutputsMessaging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contentPolicyConfig", targetDepth))
                {
                    var unmarshaller = AIGuardrailContentPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.ContentPolicyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contextualGroundingPolicyConfig", targetDepth))
                {
                    var unmarshaller = AIGuardrailContextualGroundingPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.ContextualGroundingPolicyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sensitiveInformationPolicyConfig", targetDepth))
                {
                    var unmarshaller = AIGuardrailSensitiveInformationPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.SensitiveInformationPolicyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("topicPolicyConfig", targetDepth))
                {
                    var unmarshaller = AIGuardrailTopicPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.TopicPolicyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("visibilityStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VisibilityStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("wordPolicyConfig", targetDepth))
                {
                    var unmarshaller = AIGuardrailWordPolicyConfigUnmarshaller.Instance;
                    unmarshalledObject.WordPolicyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AIGuardrailDataUnmarshaller _instance = new AIGuardrailDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AIGuardrailDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}