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
    /// ColumnStatistics Marshaller
    /// </summary>
    public class ColumnStatisticsMarshaller : IRequestMarshaller<ColumnStatistics, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ColumnStatistics requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnalyzedTime())
            {
                context.Writer.WritePropertyName("AnalyzedTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.AnalyzedTime.Value)));
            }

            if(requestObject.IsSetColumnName())
            {
                context.Writer.WritePropertyName("ColumnName");
                context.Writer.WriteStringValue(requestObject.ColumnName);
            }

            if(requestObject.IsSetColumnType())
            {
                context.Writer.WritePropertyName("ColumnType");
                context.Writer.WriteStringValue(requestObject.ColumnType);
            }

            if(requestObject.IsSetStatisticsData())
            {
                context.Writer.WritePropertyName("StatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = ColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.StatisticsData, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ColumnStatisticsMarshaller Instance = new ColumnStatisticsMarshaller();

    }
}