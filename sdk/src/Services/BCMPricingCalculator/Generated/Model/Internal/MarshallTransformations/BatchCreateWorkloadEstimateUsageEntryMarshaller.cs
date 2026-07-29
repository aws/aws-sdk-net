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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateWorkloadEstimateUsageEntry Marshaller
    /// </summary>
    public class BatchCreateWorkloadEstimateUsageEntryMarshaller : IRequestMarshaller<BatchCreateWorkloadEstimateUsageEntry, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateWorkloadEstimateUsageEntry requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAmount())
            {
                context.Writer.WriteTextString("amount");
                context.Writer.WriteOptimizedNumber(requestObject.Amount.Value);
            }
            if (requestObject.IsSetGroup())
            {
                context.Writer.WriteTextString("group");
                context.Writer.WriteTextString(requestObject.Group);
            }
            if (requestObject.IsSetHistoricalUsage())
            {
                context.Writer.WriteTextString("historicalUsage");
                context.Writer.WriteStartMap(null);

                var marshaller = HistoricalUsageEntityMarshaller.Instance;
                marshaller.Marshall(requestObject.HistoricalUsage, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetKey())
            {
                context.Writer.WriteTextString("key");
                context.Writer.WriteTextString(requestObject.Key);
            }
            if (requestObject.IsSetOperation())
            {
                context.Writer.WriteTextString("operation");
                context.Writer.WriteTextString(requestObject.Operation);
            }
            if (requestObject.IsSetServiceCode())
            {
                context.Writer.WriteTextString("serviceCode");
                context.Writer.WriteTextString(requestObject.ServiceCode);
            }
            if (requestObject.IsSetUsageAccountId())
            {
                context.Writer.WriteTextString("usageAccountId");
                context.Writer.WriteTextString(requestObject.UsageAccountId);
            }
            if (requestObject.IsSetUsageType())
            {
                context.Writer.WriteTextString("usageType");
                context.Writer.WriteTextString(requestObject.UsageType);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateWorkloadEstimateUsageEntryMarshaller Instance = new BatchCreateWorkloadEstimateUsageEntryMarshaller();

    }
}