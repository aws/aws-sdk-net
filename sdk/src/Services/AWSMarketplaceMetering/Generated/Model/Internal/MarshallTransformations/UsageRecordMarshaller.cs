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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSMarketplaceMetering.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AWSMarketplaceMetering.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UsageRecord Marshaller
    /// </summary>
    public class UsageRecordMarshaller : IRequestMarshaller<UsageRecord, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UsageRecord requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomerAWSAccountId())
            {
                context.Writer.WritePropertyName("CustomerAWSAccountId");
                context.Writer.WriteStringValue(requestObject.CustomerAWSAccountId);
            }

            if(requestObject.IsSetCustomerIdentifier())
            {
                context.Writer.WritePropertyName("CustomerIdentifier");
                context.Writer.WriteStringValue(requestObject.CustomerIdentifier);
            }

            if(requestObject.IsSetDimension())
            {
                context.Writer.WritePropertyName("Dimension");
                context.Writer.WriteStringValue(requestObject.Dimension);
            }

            if(requestObject.IsSetQuantity())
            {
                context.Writer.WritePropertyName("Quantity");
                context.Writer.WriteNumberValue(requestObject.Quantity.Value);
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.Timestamp.Value)));
            }

            if(requestObject.IsSetUsageAllocations())
            {
                context.Writer.WritePropertyName("UsageAllocations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUsageAllocationsListValue in requestObject.UsageAllocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UsageAllocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectUsageAllocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UsageRecordMarshaller Instance = new UsageRecordMarshaller();

    }
}