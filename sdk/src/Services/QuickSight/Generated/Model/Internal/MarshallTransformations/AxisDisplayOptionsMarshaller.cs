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
    /// AxisDisplayOptions Marshaller
    /// </summary>
    public class AxisDisplayOptionsMarshaller : IRequestMarshaller<AxisDisplayOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AxisDisplayOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAxisLineVisibility())
            {
                context.Writer.WritePropertyName("AxisLineVisibility");
                context.Writer.WriteStringValue(requestObject.AxisLineVisibility);
            }

            if(requestObject.IsSetAxisOffset())
            {
                context.Writer.WritePropertyName("AxisOffset");
                context.Writer.WriteStringValue(requestObject.AxisOffset);
            }

            if(requestObject.IsSetDataOptions())
            {
                context.Writer.WritePropertyName("DataOptions");
                context.Writer.WriteStartObject();

                var marshaller = AxisDataOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGridLineVisibility())
            {
                context.Writer.WritePropertyName("GridLineVisibility");
                context.Writer.WriteStringValue(requestObject.GridLineVisibility);
            }

            if(requestObject.IsSetScrollbarOptions())
            {
                context.Writer.WritePropertyName("ScrollbarOptions");
                context.Writer.WriteStartObject();

                var marshaller = ScrollBarOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ScrollbarOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTickLabelOptions())
            {
                context.Writer.WritePropertyName("TickLabelOptions");
                context.Writer.WriteStartObject();

                var marshaller = AxisTickLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.TickLabelOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AxisDisplayOptionsMarshaller Instance = new AxisDisplayOptionsMarshaller();

    }
}