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
    /// SampleConfig Marshaller
    /// </summary>
    public partial class SampleConfigMarshaller : IRequestMarshaller<SampleConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SampleConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetIncludePromptLogprobs())
            {
                context.Writer.WritePropertyName("includePromptLogprobs");
                context.Writer.WriteBooleanValue(requestObject.IncludePromptLogprobs.Value);
            }

            if (requestObject.IsSetModelPackageArn())
            {
                context.Writer.WritePropertyName("modelPackageArn");
                context.Writer.WriteStringValue(requestObject.ModelPackageArn);
            }

            if (requestObject.IsSetNumSamples())
            {
                context.Writer.WritePropertyName("numSamples");
                context.Writer.WriteNumberValue(requestObject.NumSamples.Value);
            }

            if (requestObject.IsSetPrompt())
            {
                context.Writer.WritePropertyName("prompt");
                context.Writer.WriteStartObject();

                var marshaller = ModelInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Prompt, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSamplingParams())
            {
                context.Writer.WritePropertyName("samplingParams");
                context.Writer.WriteStartObject();

                var marshaller = SamplingParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.SamplingParams, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTopkPromptLogprobs())
            {
                context.Writer.WritePropertyName("topkPromptLogprobs");
                context.Writer.WriteNumberValue(requestObject.TopkPromptLogprobs.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SampleConfigMarshaller Instance = new SampleConfigMarshaller();
    }
}
