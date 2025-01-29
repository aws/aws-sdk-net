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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateWorkloadEstimateUsageEntry Marshaller
    /// </summary>
    public class BatchCreateWorkloadEstimateUsageEntryMarshaller : IRequestMarshaller<BatchCreateWorkloadEstimateUsageEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateWorkloadEstimateUsageEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmount())
            {
                context.Writer.WritePropertyName("amount");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Amount.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Amount.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Amount.Value);
                }
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteStringValue(requestObject.Group);
            }

            if(requestObject.IsSetHistoricalUsage())
            {
                context.Writer.WritePropertyName("historicalUsage");
                context.Writer.WriteStartObject();

                var marshaller = HistoricalUsageEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.HistoricalUsage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.WriteStringValue(requestObject.Key);
            }

            if(requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("operation");
                context.Writer.WriteStringValue(requestObject.Operation);
            }

            if(requestObject.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("serviceCode");
                context.Writer.WriteStringValue(requestObject.ServiceCode);
            }

            if(requestObject.IsSetUsageAccountId())
            {
                context.Writer.WritePropertyName("usageAccountId");
                context.Writer.WriteStringValue(requestObject.UsageAccountId);
            }

            if(requestObject.IsSetUsageType())
            {
                context.Writer.WritePropertyName("usageType");
                context.Writer.WriteStringValue(requestObject.UsageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateWorkloadEstimateUsageEntryMarshaller Instance = new BatchCreateWorkloadEstimateUsageEntryMarshaller();

    }
}