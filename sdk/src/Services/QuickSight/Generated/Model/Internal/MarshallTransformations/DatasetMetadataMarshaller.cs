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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCalculatedFields())
            {
                context.Writer.WritePropertyName("CalculatedFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCalculatedFieldsListValue in requestObject.CalculatedFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicCalculatedFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCalculatedFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumns())
            {
                context.Writer.WritePropertyName("Columns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnsListValue in requestObject.Columns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataAggregation())
            {
                context.Writer.WritePropertyName("DataAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = DataAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatasetArn())
            {
                context.Writer.WritePropertyName("DatasetArn");
                context.Writer.Write(requestObject.DatasetArn);
            }

            if(requestObject.IsSetDatasetDescription())
            {
                context.Writer.WritePropertyName("DatasetDescription");
                context.Writer.Write(requestObject.DatasetDescription);
            }

            if(requestObject.IsSetDatasetName())
            {
                context.Writer.WritePropertyName("DatasetName");
                context.Writer.Write(requestObject.DatasetName);
            }

            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNamedEntities())
            {
                context.Writer.WritePropertyName("NamedEntities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNamedEntitiesListValue in requestObject.NamedEntities)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicNamedEntityMarshaller.Instance;
                    marshaller.Marshall(requestObjectNamedEntitiesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatasetMetadataMarshaller Instance = new DatasetMetadataMarshaller();

    }
}