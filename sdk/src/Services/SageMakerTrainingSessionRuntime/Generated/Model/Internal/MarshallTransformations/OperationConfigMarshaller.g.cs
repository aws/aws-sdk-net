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
    /// OperationConfig Marshaller
    /// </summary>
    public partial class OperationConfigMarshaller : IRequestMarshaller<OperationConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OperationConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetForward())
            {
                context.Writer.WritePropertyName("forward");
                context.Writer.WriteStartObject();

                var marshaller = ForwardConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.Forward, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetForwardBackward())
            {
                context.Writer.WritePropertyName("forwardBackward");
                context.Writer.WriteStartObject();

                var marshaller = ForwardBackwardConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardBackward, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetLoadState())
            {
                context.Writer.WritePropertyName("loadState");
                context.Writer.WriteStartObject();

                var marshaller = LoadStateConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LoadState, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetOptimizerStep())
            {
                context.Writer.WritePropertyName("optimizerStep");
                context.Writer.WriteStartObject();

                var marshaller = OptimizerStepConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OptimizerStep, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSaveState())
            {
                context.Writer.WritePropertyName("saveState");
                context.Writer.WriteStartObject();

                var marshaller = SaveStateConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.SaveState, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSaveWeights())
            {
                context.Writer.WritePropertyName("saveWeights");
                context.Writer.WriteStartObject();

                var marshaller = SaveWeightsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.SaveWeights, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OperationConfigMarshaller Instance = new OperationConfigMarshaller();
    }
}
