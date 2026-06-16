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
    /// MouseScrollArguments Marshaller
    /// </summary>
    public class MouseScrollArgumentsMarshaller : IRequestMarshaller<MouseScrollArguments, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MouseScrollArguments requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeltaX())
            {
                context.Writer.WritePropertyName("deltaX");
                context.Writer.WriteNumberValue(requestObject.DeltaX.Value);
            }

            if(requestObject.IsSetDeltaY())
            {
                context.Writer.WritePropertyName("deltaY");
                context.Writer.WriteNumberValue(requestObject.DeltaY.Value);
            }

            if(requestObject.IsSetX())
            {
                context.Writer.WritePropertyName("x");
                context.Writer.WriteNumberValue(requestObject.X.Value);
            }

            if(requestObject.IsSetY())
            {
                context.Writer.WritePropertyName("y");
                context.Writer.WriteNumberValue(requestObject.Y.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MouseScrollArgumentsMarshaller Instance = new MouseScrollArgumentsMarshaller();

    }
}