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
using ThirdParty.Json.LitJson;

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
                if(StringUtils.IsSpecialDoubleValue(requestObject.Amount))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Amount));
                }
                else
                {
                    context.Writer.Write(requestObject.Amount);
                }
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.Write(requestObject.Group);
            }

            if(requestObject.IsSetHistoricalUsage())
            {
                context.Writer.WritePropertyName("historicalUsage");
                context.Writer.WriteObjectStart();

                var marshaller = HistoricalUsageEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.HistoricalUsage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("operation");
                context.Writer.Write(requestObject.Operation);
            }

            if(requestObject.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("serviceCode");
                context.Writer.Write(requestObject.ServiceCode);
            }

            if(requestObject.IsSetUsageAccountId())
            {
                context.Writer.WritePropertyName("usageAccountId");
                context.Writer.Write(requestObject.UsageAccountId);
            }

            if(requestObject.IsSetUsageType())
            {
                context.Writer.WritePropertyName("usageType");
                context.Writer.Write(requestObject.UsageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateWorkloadEstimateUsageEntryMarshaller Instance = new BatchCreateWorkloadEstimateUsageEntryMarshaller();

    }
}