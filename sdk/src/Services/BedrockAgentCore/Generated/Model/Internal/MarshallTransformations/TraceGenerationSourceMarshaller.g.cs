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

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TraceGenerationSource Marshaller
    /// </summary>
    public partial class TraceGenerationSourceMarshaller : IRequestMarshaller<TraceGenerationSource, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(TraceGenerationSource requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetGroundTruth())
            {
                context.Writer.WritePropertyName("groundTruth");
                context.Writer.WriteStartObject();

                var marshaller = GroundTruthConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.GroundTruth, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRedactionConfiguration())
            {
                context.Writer.WritePropertyName("redactionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RedactionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RedactionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSampling())
            {
                context.Writer.WritePropertyName("sampling");
                context.Writer.WriteStartObject();

                var marshaller = GenerationSamplingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.Sampling, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSelection())
            {
                context.Writer.WritePropertyName("selection");
                context.Writer.WriteStartObject();

                var marshaller = GenerationSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.Selection, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSourceConfig())
            {
                context.Writer.WritePropertyName("sourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = TraceSourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceConfig, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static TraceGenerationSourceMarshaller Instance = new TraceGenerationSourceMarshaller();
    }
}
