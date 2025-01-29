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
    /// ScatterPlotUnaggregatedFieldWells Marshaller
    /// </summary>
    public class ScatterPlotUnaggregatedFieldWellsMarshaller : IRequestMarshaller<ScatterPlotUnaggregatedFieldWells, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScatterPlotUnaggregatedFieldWells requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("Category");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCategoryListValue in requestObject.Category)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategoryListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("Label");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLabelListValue in requestObject.Label)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectLabelListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSize())
            {
                context.Writer.WritePropertyName("Size");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSizeListValue in requestObject.Size)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MeasureFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectSizeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetXAxis())
            {
                context.Writer.WritePropertyName("XAxis");
                context.Writer.WriteStartArray();
                foreach(var requestObjectXAxisListValue in requestObject.XAxis)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectXAxisListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetYAxis())
            {
                context.Writer.WritePropertyName("YAxis");
                context.Writer.WriteStartArray();
                foreach(var requestObjectYAxisListValue in requestObject.YAxis)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectYAxisListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScatterPlotUnaggregatedFieldWellsMarshaller Instance = new ScatterPlotUnaggregatedFieldWellsMarshaller();

    }
}