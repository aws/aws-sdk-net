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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChatContactMetrics Object
    /// </summary>  
    public class ChatContactMetricsUnmarshaller : IUnmarshaller<ChatContactMetrics, XmlUnmarshallerContext>, IUnmarshaller<ChatContactMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ChatContactMetrics IUnmarshaller<ChatContactMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ChatContactMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            ChatContactMetrics unmarshalledObject = new ChatContactMetrics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AgentFirstResponseTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.AgentFirstResponseTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AgentFirstResponseTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AgentFirstResponseTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConversationCloseTimeInMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ConversationCloseTimeInMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConversationTurnCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConversationTurnCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiParty", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MultiParty = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalBotMessageLengthInChars", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalBotMessageLengthInChars = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalBotMessages", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalBotMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalMessages", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalMessages = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ChatContactMetricsUnmarshaller _instance = new ChatContactMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChatContactMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}