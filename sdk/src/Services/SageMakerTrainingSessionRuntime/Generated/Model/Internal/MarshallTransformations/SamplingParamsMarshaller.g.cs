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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SageMakerTrainingSessionRuntime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerTrainingSessionRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SamplingParams Marshaller
    /// </summary>
    public partial class SamplingParamsMarshaller : IRequestMarshaller<SamplingParams, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SamplingParams requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetMaxTokens())
            {
                context.Writer.WritePropertyName("maxTokens");
                context.Writer.WriteNumberValue(requestObject.MaxTokens.Value);
            }

            if (requestObject.IsSetSeed())
            {
                context.Writer.WritePropertyName("seed");
                context.Writer.WriteNumberValue(requestObject.Seed.Value);
            }

            if (requestObject.IsSetStop())
            {
                context.Writer.WritePropertyName("stop");
                context.Writer.WriteStartArray();
                foreach (var requestObjectStopListValue in requestObject.Stop)
                {
                    context.Writer.WriteStringValue(requestObjectStopListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTemperature())
            {
                context.Writer.WritePropertyName("temperature");
                if (StringUtils.IsSpecialDoubleValue(requestObject.Temperature.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Temperature.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Temperature.Value);
                }
            }

            if (requestObject.IsSetTopK())
            {
                context.Writer.WritePropertyName("topK");
                context.Writer.WriteNumberValue(requestObject.TopK.Value);
            }

            if (requestObject.IsSetTopP())
            {
                context.Writer.WritePropertyName("topP");
                if (StringUtils.IsSpecialDoubleValue(requestObject.TopP.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TopP.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TopP.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SamplingParamsMarshaller Instance = new SamplingParamsMarshaller();
    }
}
