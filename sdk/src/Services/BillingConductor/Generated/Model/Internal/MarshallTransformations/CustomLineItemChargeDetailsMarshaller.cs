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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomLineItemChargeDetails Marshaller
    /// </summary>
    public class CustomLineItemChargeDetailsMarshaller : IRequestMarshaller<CustomLineItemChargeDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomLineItemChargeDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFlat())
            {
                context.Writer.WritePropertyName("Flat");
                context.Writer.WriteObjectStart();

                var marshaller = CustomLineItemFlatChargeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Flat, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPercentage())
            {
                context.Writer.WritePropertyName("Percentage");
                context.Writer.WriteObjectStart();

                var marshaller = CustomLineItemPercentageChargeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Percentage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomLineItemChargeDetailsMarshaller Instance = new CustomLineItemChargeDetailsMarshaller();

    }
}