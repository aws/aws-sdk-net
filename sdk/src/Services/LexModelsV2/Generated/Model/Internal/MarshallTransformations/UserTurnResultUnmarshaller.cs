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
    /// Response Unmarshaller for UserTurnResult Object
    /// </summary>  
    public class UserTurnResultUnmarshaller : IJsonUnmarshaller<UserTurnResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public UserTurnResult Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            UserTurnResult unmarshalledObject = new UserTurnResult();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actualOutput", targetDepth))
                {
                    var unmarshaller = UserTurnOutputSpecificationUnmarshaller.Instance;
                    unmarshalledObject.ActualOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("conversationLevelResult", targetDepth))
                {
                    var unmarshaller = ConversationLevelResultDetailUnmarshaller.Instance;
                    unmarshalledObject.ConversationLevelResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endToEndResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndToEndResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("errorDetails", targetDepth))
                {
                    var unmarshaller = ExecutionErrorDetailsUnmarshaller.Instance;
                    unmarshalledObject.ErrorDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expectedOutput", targetDepth))
                {
                    var unmarshaller = UserTurnOutputSpecificationUnmarshaller.Instance;
                    unmarshalledObject.ExpectedOutput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = UserTurnInputSpecificationUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("intentMatchResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntentMatchResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slotMatchResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlotMatchResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("speechTranscriptionResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpeechTranscriptionResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UserTurnResultUnmarshaller _instance = new UserTurnResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserTurnResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}