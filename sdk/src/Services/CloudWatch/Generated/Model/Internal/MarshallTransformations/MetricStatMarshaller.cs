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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricStat Marshaller
    /// </summary>
    public class MetricStatMarshaller : IRequestMarshaller<MetricStat, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricStat requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetMetric())
            {
                context.Writer.WriteTextString("Metric");
                context.Writer.WriteStartMap(null);

                var marshaller = MetricMarshaller.Instance;
                marshaller.Marshall(requestObject.Metric, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPeriod())
            {
                context.Writer.WriteTextString("Period");
                context.Writer.WriteInt32(requestObject.Period.Value);
            }
            if (requestObject.IsSetStat())
            {
                context.Writer.WriteTextString("Stat");
                context.Writer.WriteTextString(requestObject.Stat);
            }
            if (requestObject.IsSetUnit())
            {
                context.Writer.WriteTextString("Unit");
                context.Writer.WriteTextString(requestObject.Unit);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricStatMarshaller Instance = new MetricStatMarshaller();

    }
}