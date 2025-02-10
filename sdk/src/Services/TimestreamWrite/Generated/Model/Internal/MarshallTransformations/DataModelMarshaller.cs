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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataModel Marshaller
    /// </summary>
    public class DataModelMarshaller : IRequestMarshaller<DataModel, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataModel requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDimensionMappings())
            {
                context.Writer.WritePropertyName("DimensionMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionMappingsListValue in requestObject.DimensionMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DimensionMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMeasureNameColumn())
            {
                context.Writer.WritePropertyName("MeasureNameColumn");
                context.Writer.WriteStringValue(requestObject.MeasureNameColumn);
            }

            if(requestObject.IsSetMixedMeasureMappings())
            {
                context.Writer.WritePropertyName("MixedMeasureMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMixedMeasureMappingsListValue in requestObject.MixedMeasureMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MixedMeasureMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMixedMeasureMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMultiMeasureMappings())
            {
                context.Writer.WritePropertyName("MultiMeasureMappings");
                context.Writer.WriteStartObject();

                var marshaller = MultiMeasureMappingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MultiMeasureMappings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeColumn())
            {
                context.Writer.WritePropertyName("TimeColumn");
                context.Writer.WriteStringValue(requestObject.TimeColumn);
            }

            if(requestObject.IsSetTimeUnit())
            {
                context.Writer.WritePropertyName("TimeUnit");
                context.Writer.WriteStringValue(requestObject.TimeUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataModelMarshaller Instance = new DataModelMarshaller();

    }
}