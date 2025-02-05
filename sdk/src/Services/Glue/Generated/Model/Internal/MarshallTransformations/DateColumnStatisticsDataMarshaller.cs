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
    /// DateColumnStatisticsData Marshaller
    /// </summary>
    public class DateColumnStatisticsDataMarshaller : IRequestMarshaller<DateColumnStatisticsData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DateColumnStatisticsData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaximumValue())
            {
                context.Writer.WritePropertyName("MaximumValue");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.MaximumValue.Value)));
            }

            if(requestObject.IsSetMinimumValue())
            {
                context.Writer.WritePropertyName("MinimumValue");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.MinimumValue.Value)));
            }

            if(requestObject.IsSetNumberOfDistinctValues())
            {
                context.Writer.WritePropertyName("NumberOfDistinctValues");
                context.Writer.WriteNumberValue(requestObject.NumberOfDistinctValues.Value);
            }

            if(requestObject.IsSetNumberOfNulls())
            {
                context.Writer.WritePropertyName("NumberOfNulls");
                context.Writer.WriteNumberValue(requestObject.NumberOfNulls.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DateColumnStatisticsDataMarshaller Instance = new DateColumnStatisticsDataMarshaller();

    }
}