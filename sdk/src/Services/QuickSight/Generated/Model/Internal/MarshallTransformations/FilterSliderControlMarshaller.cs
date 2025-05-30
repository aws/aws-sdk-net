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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FilterSliderControl Marshaller
    /// </summary>
    public class FilterSliderControlMarshaller : IRequestMarshaller<FilterSliderControl, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterSliderControl requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDisplayOptions())
            {
                context.Writer.WritePropertyName("DisplayOptions");
                context.Writer.WriteStartObject();

                var marshaller = SliderControlDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DisplayOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterControlId())
            {
                context.Writer.WritePropertyName("FilterControlId");
                context.Writer.WriteStringValue(requestObject.FilterControlId);
            }

            if(requestObject.IsSetMaximumValue())
            {
                context.Writer.WritePropertyName("MaximumValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaximumValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MaximumValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MaximumValue.Value);
                }
            }

            if(requestObject.IsSetMinimumValue())
            {
                context.Writer.WritePropertyName("MinimumValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MinimumValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MinimumValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MinimumValue.Value);
                }
            }

            if(requestObject.IsSetSourceFilterId())
            {
                context.Writer.WritePropertyName("SourceFilterId");
                context.Writer.WriteStringValue(requestObject.SourceFilterId);
            }

            if(requestObject.IsSetStepSize())
            {
                context.Writer.WritePropertyName("StepSize");
                if(StringUtils.IsSpecialDoubleValue(requestObject.StepSize.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.StepSize.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.StepSize.Value);
                }
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterSliderControlMarshaller Instance = new FilterSliderControlMarshaller();

    }
}