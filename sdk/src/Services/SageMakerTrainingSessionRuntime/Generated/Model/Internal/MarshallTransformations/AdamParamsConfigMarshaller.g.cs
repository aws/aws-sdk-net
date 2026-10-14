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
    /// AdamParamsConfig Marshaller
    /// </summary>
    public partial class AdamParamsConfigMarshaller : IRequestMarshaller<AdamParamsConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AdamParamsConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBeta1())
            {
                context.Writer.WritePropertyName("beta1");
                if (StringUtils.IsSpecialDoubleValue(requestObject.Beta1.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Beta1.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Beta1.Value);
                }
            }

            if (requestObject.IsSetBeta2())
            {
                context.Writer.WritePropertyName("beta2");
                if (StringUtils.IsSpecialDoubleValue(requestObject.Beta2.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Beta2.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Beta2.Value);
                }
            }

            if (requestObject.IsSetEps())
            {
                context.Writer.WritePropertyName("eps");
                if (StringUtils.IsSpecialDoubleValue(requestObject.Eps.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Eps.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Eps.Value);
                }
            }

            if (requestObject.IsSetGradClipNorm())
            {
                context.Writer.WritePropertyName("gradClipNorm");
                if (StringUtils.IsSpecialDoubleValue(requestObject.GradClipNorm.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.GradClipNorm.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.GradClipNorm.Value);
                }
            }

            if (requestObject.IsSetLearningRate())
            {
                context.Writer.WritePropertyName("learningRate");
                if (StringUtils.IsSpecialDoubleValue(requestObject.LearningRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LearningRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LearningRate.Value);
                }
            }

            if (requestObject.IsSetLoraPlusLrRatio())
            {
                context.Writer.WritePropertyName("loraPlusLrRatio");
                if (StringUtils.IsSpecialDoubleValue(requestObject.LoraPlusLrRatio.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LoraPlusLrRatio.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LoraPlusLrRatio.Value);
                }
            }

            if (requestObject.IsSetWeightDecay())
            {
                context.Writer.WritePropertyName("weightDecay");
                if (StringUtils.IsSpecialDoubleValue(requestObject.WeightDecay.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.WeightDecay.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.WeightDecay.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AdamParamsConfigMarshaller Instance = new AdamParamsConfigMarshaller();
    }
}
