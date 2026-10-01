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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChannelParameters Object
    /// </summary>  
    public class ChannelParametersUnmarshaller : IJsonUnmarshaller<ChannelParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ChannelParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ChannelParameters unmarshalledObject = new ChannelParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("notify", targetDepth, ref reader))
                {
                    var unmarshaller = NotifyParametersUnmarshaller.Instance;
                    unmarshalledObject.Notify = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("text", targetDepth, ref reader))
                {
                    var unmarshaller = TextParametersUnmarshaller.Instance;
                    unmarshalledObject.Text = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("voice", targetDepth, ref reader))
                {
                    var unmarshaller = VoiceParametersUnmarshaller.Instance;
                    unmarshalledObject.Voice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("whatsApp", targetDepth, ref reader))
                {
                    var unmarshaller = WhatsAppParametersUnmarshaller.Instance;
                    unmarshalledObject.WhatsApp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ChannelParametersUnmarshaller _instance = new ChannelParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChannelParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}