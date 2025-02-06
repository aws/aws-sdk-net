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
    /// ColumnStatisticsData Marshaller
    /// </summary>
    public class ColumnStatisticsDataMarshaller : IRequestMarshaller<ColumnStatisticsData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ColumnStatisticsData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBinaryColumnStatisticsData())
            {
                context.Writer.WritePropertyName("BinaryColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = BinaryColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.BinaryColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBooleanColumnStatisticsData())
            {
                context.Writer.WritePropertyName("BooleanColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = BooleanColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.BooleanColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDateColumnStatisticsData())
            {
                context.Writer.WritePropertyName("DateColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = DateColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.DateColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDecimalColumnStatisticsData())
            {
                context.Writer.WritePropertyName("DecimalColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = DecimalColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.DecimalColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDoubleColumnStatisticsData())
            {
                context.Writer.WritePropertyName("DoubleColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = DoubleColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.DoubleColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLongColumnStatisticsData())
            {
                context.Writer.WritePropertyName("LongColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = LongColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.LongColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStringColumnStatisticsData())
            {
                context.Writer.WritePropertyName("StringColumnStatisticsData");
                context.Writer.WriteStartObject();

                var marshaller = StringColumnStatisticsDataMarshaller.Instance;
                marshaller.Marshall(requestObject.StringColumnStatisticsData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ColumnStatisticsDataMarshaller Instance = new ColumnStatisticsDataMarshaller();

    }
}