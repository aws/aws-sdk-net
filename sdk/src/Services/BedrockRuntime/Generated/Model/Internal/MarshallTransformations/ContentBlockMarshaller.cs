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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContentBlock Marshaller
    /// </summary>
    public class ContentBlockMarshaller : IRequestMarshaller<ContentBlock, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContentBlock requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCachePoint())
            {
                context.Writer.WritePropertyName("cachePoint");
                context.Writer.WriteStartObject();

                var marshaller = CachePointBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.CachePoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCitationsContent())
            {
                context.Writer.WritePropertyName("citationsContent");
                context.Writer.WriteStartObject();

                var marshaller = CitationsContentBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.CitationsContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDocument())
            {
                context.Writer.WritePropertyName("document");
                context.Writer.WriteStartObject();

                var marshaller = DocumentBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Document, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGuardContent())
            {
                context.Writer.WritePropertyName("guardContent");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailConverseContentBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.GuardContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStartObject();

                var marshaller = ImageBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Image, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReasoningContent())
            {
                context.Writer.WritePropertyName("reasoningContent");
                context.Writer.WriteStartObject();

                var marshaller = ReasoningContentBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.ReasoningContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("text");
                context.Writer.WriteStringValue(requestObject.Text);
            }

            if(requestObject.IsSetToolResult())
            {
                context.Writer.WritePropertyName("toolResult");
                context.Writer.WriteStartObject();

                var marshaller = ToolResultBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.ToolResult, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetToolUse())
            {
                context.Writer.WritePropertyName("toolUse");
                context.Writer.WriteStartObject();

                var marshaller = ToolUseBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.ToolUse, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVideo())
            {
                context.Writer.WritePropertyName("video");
                context.Writer.WriteStartObject();

                var marshaller = VideoBlockMarshaller.Instance;
                marshaller.Marshall(requestObject.Video, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContentBlockMarshaller Instance = new ContentBlockMarshaller();

    }
}