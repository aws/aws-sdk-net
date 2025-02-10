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
    /// BatchUpdateBillScenarioUsageModificationEntry Marshaller
    /// </summary>
    public class BatchUpdateBillScenarioUsageModificationEntryMarshaller : IRequestMarshaller<BatchUpdateBillScenarioUsageModificationEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchUpdateBillScenarioUsageModificationEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmounts())
            {
                context.Writer.WritePropertyName("amounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAmountsListValue in requestObject.Amounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UsageAmountMarshaller.Instance;
                    marshaller.Marshall(requestObjectAmountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteStringValue(requestObject.Group);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchUpdateBillScenarioUsageModificationEntryMarshaller Instance = new BatchUpdateBillScenarioUsageModificationEntryMarshaller();

    }
}