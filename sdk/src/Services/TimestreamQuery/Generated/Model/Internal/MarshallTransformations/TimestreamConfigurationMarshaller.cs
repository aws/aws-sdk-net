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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimestreamConfiguration Marshaller
    /// </summary>
    public class TimestreamConfigurationMarshaller : IRequestMarshaller<TimestreamConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TimestreamConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDimensionMappings())
            {
                context.Writer.WritePropertyName("DimensionMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDimensionMappingsListValue in requestObject.DimensionMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DimensionMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMeasureNameColumn())
            {
                context.Writer.WritePropertyName("MeasureNameColumn");
                context.Writer.Write(requestObject.MeasureNameColumn);
            }

            if(requestObject.IsSetMixedMeasureMappings())
            {
                context.Writer.WritePropertyName("MixedMeasureMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMixedMeasureMappingsListValue in requestObject.MixedMeasureMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MixedMeasureMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMixedMeasureMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMultiMeasureMappings())
            {
                context.Writer.WritePropertyName("MultiMeasureMappings");
                context.Writer.WriteObjectStart();

                var marshaller = MultiMeasureMappingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MultiMeasureMappings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.Write(requestObject.TableName);
            }

            if(requestObject.IsSetTimeColumn())
            {
                context.Writer.WritePropertyName("TimeColumn");
                context.Writer.Write(requestObject.TimeColumn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimestreamConfigurationMarshaller Instance = new TimestreamConfigurationMarshaller();

    }
}