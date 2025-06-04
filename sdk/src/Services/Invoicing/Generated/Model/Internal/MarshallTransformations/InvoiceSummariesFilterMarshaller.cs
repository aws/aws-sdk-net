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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Invoicing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvoiceSummariesFilter Marshaller
    /// </summary>
    public class InvoiceSummariesFilterMarshaller : IRequestMarshaller<InvoiceSummariesFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InvoiceSummariesFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBillingPeriod())
            {
                context.Writer.WritePropertyName("BillingPeriod");
                context.Writer.WriteStartObject();

                var marshaller = BillingPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.BillingPeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInvoicingEntity())
            {
                context.Writer.WritePropertyName("InvoicingEntity");
                context.Writer.WriteStringValue(requestObject.InvoicingEntity);
            }

            if(requestObject.IsSetTimeInterval())
            {
                context.Writer.WritePropertyName("TimeInterval");
                context.Writer.WriteStartObject();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeInterval, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InvoiceSummariesFilterMarshaller Instance = new InvoiceSummariesFilterMarshaller();

    }
}