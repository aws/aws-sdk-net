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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LinkedAccountOAuth2 Marshaller
    /// </summary>
    public class LinkedAccountOAuth2Marshaller : IRequestMarshaller<LinkedAccountOAuth2, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LinkedAccountOAuth2 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApple())
            {
                context.Writer.WritePropertyName("apple");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2AuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.Apple, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGithub())
            {
                context.Writer.WritePropertyName("github");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2AuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.Github, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGoogle())
            {
                context.Writer.WritePropertyName("google");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2AuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.Google, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTelegram())
            {
                context.Writer.WritePropertyName("telegram");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2AuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.Telegram, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetX())
            {
                context.Writer.WritePropertyName("x");
                context.Writer.WriteStartObject();

                var marshaller = OAuth2AuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.X, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LinkedAccountOAuth2Marshaller Instance = new LinkedAccountOAuth2Marshaller();

    }
}