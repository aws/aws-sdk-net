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
    /// BrowserAction Marshaller
    /// </summary>
    public class BrowserActionMarshaller : IRequestMarshaller<BrowserAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BrowserAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKeyPress())
            {
                context.Writer.WritePropertyName("keyPress");
                context.Writer.WriteStartObject();

                var marshaller = KeyPressArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyPress, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyShortcut())
            {
                context.Writer.WritePropertyName("keyShortcut");
                context.Writer.WriteStartObject();

                var marshaller = KeyShortcutArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyShortcut, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyType())
            {
                context.Writer.WritePropertyName("keyType");
                context.Writer.WriteStartObject();

                var marshaller = KeyTypeArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMouseClick())
            {
                context.Writer.WritePropertyName("mouseClick");
                context.Writer.WriteStartObject();

                var marshaller = MouseClickArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.MouseClick, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMouseDrag())
            {
                context.Writer.WritePropertyName("mouseDrag");
                context.Writer.WriteStartObject();

                var marshaller = MouseDragArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.MouseDrag, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMouseMove())
            {
                context.Writer.WritePropertyName("mouseMove");
                context.Writer.WriteStartObject();

                var marshaller = MouseMoveArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.MouseMove, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMouseScroll())
            {
                context.Writer.WritePropertyName("mouseScroll");
                context.Writer.WriteStartObject();

                var marshaller = MouseScrollArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.MouseScroll, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScreenshot())
            {
                context.Writer.WritePropertyName("screenshot");
                context.Writer.WriteStartObject();

                var marshaller = ScreenshotArgumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.Screenshot, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BrowserActionMarshaller Instance = new BrowserActionMarshaller();

    }
}