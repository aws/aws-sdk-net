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
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UtteranceSpecification Object
    /// </summary>  
    public class UtteranceSpecificationUnmarshaller : IUnmarshaller<UtteranceSpecification, XmlUnmarshallerContext>, IUnmarshaller<UtteranceSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UtteranceSpecification IUnmarshaller<UtteranceSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UtteranceSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UtteranceSpecification unmarshalledObject = new UtteranceSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associatedIntentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociatedIntentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("associatedSlotName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociatedSlotName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioVoiceDurationMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.AudioVoiceDurationMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botAliasId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotAliasId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botResponseAudioVoiceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotResponseAudioVoiceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botResponses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UtteranceBotResponse, UtteranceBotResponseUnmarshaller>(UtteranceBotResponseUnmarshaller.Instance);
                    unmarshalledObject.BotResponses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conversationEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConversationEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("conversationStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConversationStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dialogActionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DialogActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntentState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocaleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slotsFilledInSession", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlotsFilledInSession = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utterance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Utterance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utteranceRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UtteranceRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utteranceTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UtteranceTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utteranceUnderstood", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UtteranceUnderstood = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UtteranceSpecificationUnmarshaller _instance = new UtteranceSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UtteranceSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}