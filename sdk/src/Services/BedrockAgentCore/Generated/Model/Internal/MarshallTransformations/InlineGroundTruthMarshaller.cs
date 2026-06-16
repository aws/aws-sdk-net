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
    /// InlineGroundTruth Marshaller
    /// </summary>
    public class InlineGroundTruthMarshaller : IRequestMarshaller<InlineGroundTruth, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InlineGroundTruth requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssertions())
            {
                context.Writer.WritePropertyName("assertions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAssertionsListValue in requestObject.Assertions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EvaluationContentMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssertionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExpectedTrajectory())
            {
                context.Writer.WritePropertyName("expectedTrajectory");
                context.Writer.WriteStartObject();

                var marshaller = EvaluationExpectedTrajectoryMarshaller.Instance;
                marshaller.Marshall(requestObject.ExpectedTrajectory, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTurns())
            {
                context.Writer.WritePropertyName("turns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTurnsListValue in requestObject.Turns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GroundTruthTurnMarshaller.Instance;
                    marshaller.Marshall(requestObjectTurnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InlineGroundTruthMarshaller Instance = new InlineGroundTruthMarshaller();

    }
}