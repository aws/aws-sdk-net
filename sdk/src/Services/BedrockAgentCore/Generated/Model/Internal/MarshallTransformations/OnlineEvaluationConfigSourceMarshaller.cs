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
    /// OnlineEvaluationConfigSource Marshaller
    /// </summary>
    public class OnlineEvaluationConfigSourceMarshaller : IRequestMarshaller<OnlineEvaluationConfigSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OnlineEvaluationConfigSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOnlineEvaluationConfigArn())
            {
                context.Writer.WritePropertyName("onlineEvaluationConfigArn");
                context.Writer.WriteStringValue(requestObject.OnlineEvaluationConfigArn);
            }

            if(requestObject.IsSetSessionFilterConfig())
            {
                context.Writer.WritePropertyName("sessionFilterConfig");
                context.Writer.WriteStartObject();

                var marshaller = SessionFilterConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.SessionFilterConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OnlineEvaluationConfigSourceMarshaller Instance = new OnlineEvaluationConfigSourceMarshaller();

    }
}