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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WeightedBalancedSchedulingConfiguration Marshaller
    /// </summary>
    public class WeightedBalancedSchedulingConfigurationMarshaller : IRequestMarshaller<WeightedBalancedSchedulingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WeightedBalancedSchedulingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetErrorWeight())
            {
                context.Writer.WritePropertyName("errorWeight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ErrorWeight.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ErrorWeight.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ErrorWeight.Value);
                }
            }

            if(requestObject.IsSetMaxPriorityOverride())
            {
                context.Writer.WritePropertyName("maxPriorityOverride");
                context.Writer.WriteStartObject();

                var marshaller = SchedulingMaxPriorityOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.MaxPriorityOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinPriorityOverride())
            {
                context.Writer.WritePropertyName("minPriorityOverride");
                context.Writer.WriteStartObject();

                var marshaller = SchedulingMinPriorityOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.MinPriorityOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPriorityWeight())
            {
                context.Writer.WritePropertyName("priorityWeight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.PriorityWeight.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.PriorityWeight.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.PriorityWeight.Value);
                }
            }

            if(requestObject.IsSetRenderingTaskBuffer())
            {
                context.Writer.WritePropertyName("renderingTaskBuffer");
                context.Writer.WriteNumberValue(requestObject.RenderingTaskBuffer.Value);
            }

            if(requestObject.IsSetRenderingTaskWeight())
            {
                context.Writer.WritePropertyName("renderingTaskWeight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.RenderingTaskWeight.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.RenderingTaskWeight.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.RenderingTaskWeight.Value);
                }
            }

            if(requestObject.IsSetSubmissionTimeWeight())
            {
                context.Writer.WritePropertyName("submissionTimeWeight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SubmissionTimeWeight.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SubmissionTimeWeight.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SubmissionTimeWeight.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WeightedBalancedSchedulingConfigurationMarshaller Instance = new WeightedBalancedSchedulingConfigurationMarshaller();

    }
}