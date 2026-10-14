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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HistoricalUsageEntity Marshaller
    /// </summary>
    public partial class HistoricalUsageEntityMarshaller : IRequestMarshaller<HistoricalUsageEntity, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HistoricalUsageEntity requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBillInterval())
            {
                context.Writer.WritePropertyName("billInterval");
                context.Writer.WriteStartObject();

                var marshaller = BillIntervalMarshaller.Instance;
                marshaller.Marshall(requestObject.BillInterval, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFilterExpression())
            {
                context.Writer.WritePropertyName("filterExpression");
                context.Writer.WriteStartObject();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterExpression, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteStringValue(requestObject.Location);
            }

            if (requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("operation");
                context.Writer.WriteStringValue(requestObject.Operation);
            }

            if (requestObject.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("serviceCode");
                context.Writer.WriteStringValue(requestObject.ServiceCode);
            }

            if (requestObject.IsSetUsageAccountId())
            {
                context.Writer.WritePropertyName("usageAccountId");
                context.Writer.WriteStringValue(requestObject.UsageAccountId);
            }

            if (requestObject.IsSetUsageType())
            {
                context.Writer.WritePropertyName("usageType");
                context.Writer.WriteStringValue(requestObject.UsageType);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HistoricalUsageEntityMarshaller Instance = new HistoricalUsageEntityMarshaller();
    }
}
