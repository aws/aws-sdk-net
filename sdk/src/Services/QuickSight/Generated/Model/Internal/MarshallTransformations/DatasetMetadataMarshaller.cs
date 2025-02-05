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
    /// DatasetMetadata Marshaller
    /// </summary>
    public class DatasetMetadataMarshaller : IRequestMarshaller<DatasetMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatasetMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCalculatedFields())
            {
                context.Writer.WritePropertyName("CalculatedFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCalculatedFieldsListValue in requestObject.CalculatedFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TopicCalculatedFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCalculatedFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetColumns())
            {
                context.Writer.WritePropertyName("Columns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColumnsListValue in requestObject.Columns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TopicColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataAggregation())
            {
                context.Writer.WritePropertyName("DataAggregation");
                context.Writer.WriteStartObject();

                var marshaller = DataAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataAggregation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatasetArn())
            {
                context.Writer.WritePropertyName("DatasetArn");
                context.Writer.WriteStringValue(requestObject.DatasetArn);
            }

            if(requestObject.IsSetDatasetDescription())
            {
                context.Writer.WritePropertyName("DatasetDescription");
                context.Writer.WriteStringValue(requestObject.DatasetDescription);
            }

            if(requestObject.IsSetDatasetName())
            {
                context.Writer.WritePropertyName("DatasetName");
                context.Writer.WriteStringValue(requestObject.DatasetName);
            }

            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TopicFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNamedEntities())
            {
                context.Writer.WritePropertyName("NamedEntities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNamedEntitiesListValue in requestObject.NamedEntities)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TopicNamedEntityMarshaller.Instance;
                    marshaller.Marshall(requestObjectNamedEntitiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatasetMetadataMarshaller Instance = new DatasetMetadataMarshaller();

    }
}