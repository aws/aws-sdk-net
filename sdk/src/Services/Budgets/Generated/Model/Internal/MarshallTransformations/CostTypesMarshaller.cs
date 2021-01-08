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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetIncludeCredit())
            {
                context.Writer.WritePropertyName("IncludeCredit");
                context.Writer.Write(requestObject.IncludeCredit);
            }

            if(requestObject.IsSetIncludeDiscount())
            {
                context.Writer.WritePropertyName("IncludeDiscount");
                context.Writer.Write(requestObject.IncludeDiscount);
            }

            if(requestObject.IsSetIncludeOtherSubscription())
            {
                context.Writer.WritePropertyName("IncludeOtherSubscription");
                context.Writer.Write(requestObject.IncludeOtherSubscription);
            }

            if(requestObject.IsSetIncludeRecurring())
            {
                context.Writer.WritePropertyName("IncludeRecurring");
                context.Writer.Write(requestObject.IncludeRecurring);
            }

            if(requestObject.IsSetIncludeRefund())
            {
                context.Writer.WritePropertyName("IncludeRefund");
                context.Writer.Write(requestObject.IncludeRefund);
            }

            if(requestObject.IsSetIncludeSubscription())
            {
                context.Writer.WritePropertyName("IncludeSubscription");
                context.Writer.Write(requestObject.IncludeSubscription);
            }

            if(requestObject.IsSetIncludeSupport())
            {
                context.Writer.WritePropertyName("IncludeSupport");
                context.Writer.Write(requestObject.IncludeSupport);
            }

            if(requestObject.IsSetIncludeTax())
            {
                context.Writer.WritePropertyName("IncludeTax");
                context.Writer.Write(requestObject.IncludeTax);
            }

            if(requestObject.IsSetIncludeUpfront())
            {
                context.Writer.WritePropertyName("IncludeUpfront");
                context.Writer.Write(requestObject.IncludeUpfront);
            }

            if(requestObject.IsSetUseAmortized())
            {
                context.Writer.WritePropertyName("UseAmortized");
                context.Writer.Write(requestObject.UseAmortized);
            }

            if(requestObject.IsSetUseBlended())
            {
                context.Writer.WritePropertyName("UseBlended");
                context.Writer.Write(requestObject.UseBlended);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CostTypesMarshaller Instance = new CostTypesMarshaller();

    }
}