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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CostTypes Marshaller
    /// </summary>
    public class CostTypesMarshaller : IRequestMarshaller<CostTypes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CostTypes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIncludeCredit())
            {
                context.Writer.WritePropertyName("IncludeCredit");
                context.Writer.WriteBooleanValue(requestObject.IncludeCredit.Value);
            }

            if(requestObject.IsSetIncludeDiscount())
            {
                context.Writer.WritePropertyName("IncludeDiscount");
                context.Writer.WriteBooleanValue(requestObject.IncludeDiscount.Value);
            }

            if(requestObject.IsSetIncludeOtherSubscription())
            {
                context.Writer.WritePropertyName("IncludeOtherSubscription");
                context.Writer.WriteBooleanValue(requestObject.IncludeOtherSubscription.Value);
            }

            if(requestObject.IsSetIncludeRecurring())
            {
                context.Writer.WritePropertyName("IncludeRecurring");
                context.Writer.WriteBooleanValue(requestObject.IncludeRecurring.Value);
            }

            if(requestObject.IsSetIncludeRefund())
            {
                context.Writer.WritePropertyName("IncludeRefund");
                context.Writer.WriteBooleanValue(requestObject.IncludeRefund.Value);
            }

            if(requestObject.IsSetIncludeSubscription())
            {
                context.Writer.WritePropertyName("IncludeSubscription");
                context.Writer.WriteBooleanValue(requestObject.IncludeSubscription.Value);
            }

            if(requestObject.IsSetIncludeSupport())
            {
                context.Writer.WritePropertyName("IncludeSupport");
                context.Writer.WriteBooleanValue(requestObject.IncludeSupport.Value);
            }

            if(requestObject.IsSetIncludeTax())
            {
                context.Writer.WritePropertyName("IncludeTax");
                context.Writer.WriteBooleanValue(requestObject.IncludeTax.Value);
            }

            if(requestObject.IsSetIncludeUpfront())
            {
                context.Writer.WritePropertyName("IncludeUpfront");
                context.Writer.WriteBooleanValue(requestObject.IncludeUpfront.Value);
            }

            if(requestObject.IsSetUseAmortized())
            {
                context.Writer.WritePropertyName("UseAmortized");
                context.Writer.WriteBooleanValue(requestObject.UseAmortized.Value);
            }

            if(requestObject.IsSetUseBlended())
            {
                context.Writer.WritePropertyName("UseBlended");
                context.Writer.WriteBooleanValue(requestObject.UseBlended.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CostTypesMarshaller Instance = new CostTypesMarshaller();

    }
}