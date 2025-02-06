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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeTargetTimestreamParameters Marshaller
    /// </summary>
    public class PipeTargetTimestreamParametersMarshaller : IRequestMarshaller<PipeTargetTimestreamParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeTargetTimestreamParameters requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetEpochTimeUnit())
            {
                context.Writer.WritePropertyName("EpochTimeUnit");
                context.Writer.WriteStringValue(requestObject.EpochTimeUnit);
            }

            if(requestObject.IsSetMultiMeasureMappings())
            {
                context.Writer.WritePropertyName("MultiMeasureMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMultiMeasureMappingsListValue in requestObject.MultiMeasureMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MultiMeasureMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMultiMeasureMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSingleMeasureMappings())
            {
                context.Writer.WritePropertyName("SingleMeasureMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSingleMeasureMappingsListValue in requestObject.SingleMeasureMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SingleMeasureMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectSingleMeasureMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimeFieldType())
            {
                context.Writer.WritePropertyName("TimeFieldType");
                context.Writer.WriteStringValue(requestObject.TimeFieldType);
            }

            if(requestObject.IsSetTimestampFormat())
            {
                context.Writer.WritePropertyName("TimestampFormat");
                context.Writer.WriteStringValue(requestObject.TimestampFormat);
            }

            if(requestObject.IsSetTimeValue())
            {
                context.Writer.WritePropertyName("TimeValue");
                context.Writer.WriteStringValue(requestObject.TimeValue);
            }

            if(requestObject.IsSetVersionValue())
            {
                context.Writer.WritePropertyName("VersionValue");
                context.Writer.WriteStringValue(requestObject.VersionValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeTargetTimestreamParametersMarshaller Instance = new PipeTargetTimestreamParametersMarshaller();

    }
}