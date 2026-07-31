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
    /// BillScenarioCommitmentModificationAction Marshaller
    /// </summary>
    public class BillScenarioCommitmentModificationActionMarshaller : IRequestMarshaller<BillScenarioCommitmentModificationAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BillScenarioCommitmentModificationAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddReservedInstanceAction())
            {
                context.Writer.WritePropertyName("addReservedInstanceAction");
                context.Writer.WriteStartObject();

                var marshaller = AddReservedInstanceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.AddReservedInstanceAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAddSavingsPlanAction())
            {
                context.Writer.WritePropertyName("addSavingsPlanAction");
                context.Writer.WriteStartObject();

                var marshaller = AddSavingsPlanActionMarshaller.Instance;
                marshaller.Marshall(requestObject.AddSavingsPlanAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNegateReservedInstanceAction())
            {
                context.Writer.WritePropertyName("negateReservedInstanceAction");
                context.Writer.WriteStartObject();

                var marshaller = NegateReservedInstanceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.NegateReservedInstanceAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNegateSavingsPlanAction())
            {
                context.Writer.WritePropertyName("negateSavingsPlanAction");
                context.Writer.WriteStartObject();

                var marshaller = NegateSavingsPlanActionMarshaller.Instance;
                marshaller.Marshall(requestObject.NegateSavingsPlanAction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BillScenarioCommitmentModificationActionMarshaller Instance = new BillScenarioCommitmentModificationActionMarshaller();

    }
}