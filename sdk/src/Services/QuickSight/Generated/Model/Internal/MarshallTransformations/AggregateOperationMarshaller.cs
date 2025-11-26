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
    /// AggregateOperation Marshaller
    /// </summary>
    public class AggregateOperationMarshaller : IRequestMarshaller<AggregateOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AggregateOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregations())
            {
                context.Writer.WritePropertyName("Aggregations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggregationsListValue in requestObject.Aggregations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AggregationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAlias())
            {
                context.Writer.WritePropertyName("Alias");
                context.Writer.WriteStringValue(requestObject.Alias);
            }

            if(requestObject.IsSetGroupByColumnNames())
            {
                context.Writer.WritePropertyName("GroupByColumnNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGroupByColumnNamesListValue in requestObject.GroupByColumnNames)
                {
                        context.Writer.WriteStringValue(requestObjectGroupByColumnNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStartObject();

                var marshaller = TransformOperationSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AggregateOperationMarshaller Instance = new AggregateOperationMarshaller();

    }
}