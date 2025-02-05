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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SessionSpecification Object
    /// </summary>  
    public class SessionSpecificationUnmarshaller : IJsonUnmarshaller<SessionSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SessionSpecification Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SessionSpecification unmarshalledObject = new SessionSpecification();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("botAliasId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotAliasId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("botVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("channel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conversationDurationSeconds", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ConversationDurationSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conversationEndState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConversationEndState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conversationEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConversationEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conversationStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConversationStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("invokedIntentSamples", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InvokedIntentSample, InvokedIntentSampleUnmarshaller>(InvokedIntentSampleUnmarshaller.Instance);
                    unmarshalledObject.InvokedIntentSamples = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("localeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocaleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberOfTurns", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfTurns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("originatingRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginatingRequestId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sessionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SessionSpecificationUnmarshaller _instance = new SessionSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SessionSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}