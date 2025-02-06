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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JDBCConnectorOptions Marshaller
    /// </summary>
    public class JDBCConnectorOptionsMarshaller : IRequestMarshaller<JDBCConnectorOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JDBCConnectorOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataTypeMapping())
            {
                context.Writer.WritePropertyName("DataTypeMapping");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDataTypeMappingKvp in requestObject.DataTypeMapping)
                {
                    context.Writer.WritePropertyName(requestObjectDataTypeMappingKvp.Key);
                    var requestObjectDataTypeMappingValue = requestObjectDataTypeMappingKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDataTypeMappingValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterPredicate())
            {
                context.Writer.WritePropertyName("FilterPredicate");
                context.Writer.WriteStringValue(requestObject.FilterPredicate);
            }

            if(requestObject.IsSetJobBookmarkKeys())
            {
                context.Writer.WritePropertyName("JobBookmarkKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectJobBookmarkKeysListValue in requestObject.JobBookmarkKeys)
                {
                        context.Writer.WriteStringValue(requestObjectJobBookmarkKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJobBookmarkKeysSortOrder())
            {
                context.Writer.WritePropertyName("JobBookmarkKeysSortOrder");
                context.Writer.WriteStringValue(requestObject.JobBookmarkKeysSortOrder);
            }

            if(requestObject.IsSetLowerBound())
            {
                context.Writer.WritePropertyName("LowerBound");
                context.Writer.WriteNumberValue(requestObject.LowerBound.Value);
            }

            if(requestObject.IsSetNumPartitions())
            {
                context.Writer.WritePropertyName("NumPartitions");
                context.Writer.WriteNumberValue(requestObject.NumPartitions.Value);
            }

            if(requestObject.IsSetPartitionColumn())
            {
                context.Writer.WritePropertyName("PartitionColumn");
                context.Writer.WriteStringValue(requestObject.PartitionColumn);
            }

            if(requestObject.IsSetUpperBound())
            {
                context.Writer.WritePropertyName("UpperBound");
                context.Writer.WriteNumberValue(requestObject.UpperBound.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JDBCConnectorOptionsMarshaller Instance = new JDBCConnectorOptionsMarshaller();

    }
}