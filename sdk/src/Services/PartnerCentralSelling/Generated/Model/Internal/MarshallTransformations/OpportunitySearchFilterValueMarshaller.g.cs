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

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpportunitySearchFilterValue Marshaller
    /// </summary>
    public partial class OpportunitySearchFilterValueMarshaller : IRequestMarshaller<OpportunitySearchFilterValue, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OpportunitySearchFilterValue requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDateValue())
            {
                context.Writer.WritePropertyName("DateValue");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.DateValue));
            }

            if (requestObject.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("DoubleValue");
                if (StringUtils.IsSpecialDoubleValue(requestObject.DoubleValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DoubleValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DoubleValue.Value);
                }
            }

            if (requestObject.IsSetLongValue())
            {
                context.Writer.WritePropertyName("LongValue");
                context.Writer.WriteNumberValue(requestObject.LongValue.Value);
            }

            if (requestObject.IsSetStringListValue())
            {
                context.Writer.WritePropertyName("StringListValue");
                context.Writer.WriteStartArray();
                foreach (var requestObjectStringListValueListValue in requestObject.StringListValue)
                {
                    context.Writer.WriteStringValue(requestObjectStringListValueListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OpportunitySearchFilterValueMarshaller Instance = new OpportunitySearchFilterValueMarshaller();
    }
}
