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

using Amazon.Payments.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Payments.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvoiceDetails Object
    /// </summary>
    public partial class InvoiceDetailsUnmarshaller : IJsonUnmarshaller<InvoiceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InvoiceDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new InvoiceDetails();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("billingPeriod", targetDepth, ref reader))
                {
                    var unmarshaller = BillingPeriodUnmarshaller.Instance;
                    unmarshalledObject.BillingPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dueDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.DueDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dueStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DueStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("invoiceFrequency", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvoiceFrequency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("invoiceId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvoiceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("paymentTerms", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PaymentTerms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static InvoiceDetailsUnmarshaller _instance = new InvoiceDetailsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvoiceDetailsUnmarshaller Instance => _instance;
    }
}
