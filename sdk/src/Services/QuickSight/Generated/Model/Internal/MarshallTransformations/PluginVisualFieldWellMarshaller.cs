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
    /// PluginVisualFieldWell Marshaller
    /// </summary>
    public class PluginVisualFieldWellMarshaller : IRequestMarshaller<PluginVisualFieldWell, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PluginVisualFieldWell requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAxisName())
            {
                context.Writer.WritePropertyName("AxisName");
                context.Writer.WriteStringValue(requestObject.AxisName);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMeasures())
            {
                context.Writer.WritePropertyName("Measures");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMeasuresListValue in requestObject.Measures)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MeasureFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectMeasuresListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUnaggregated())
            {
                context.Writer.WritePropertyName("Unaggregated");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUnaggregatedListValue in requestObject.Unaggregated)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UnaggregatedFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectUnaggregatedListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PluginVisualFieldWellMarshaller Instance = new PluginVisualFieldWellMarshaller();

    }
}