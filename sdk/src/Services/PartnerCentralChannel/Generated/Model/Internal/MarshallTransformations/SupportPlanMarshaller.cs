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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SupportPlan Marshaller
    /// </summary>
    public class SupportPlanMarshaller : IRequestMarshaller<SupportPlan, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SupportPlan requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPartnerLedSupport())
            {
                context.Writer.WritePropertyName("partnerLedSupport");
                context.Writer.WriteStartObject();

                var marshaller = PartnerLedSupportMarshaller.Instance;
                marshaller.Marshall(requestObject.PartnerLedSupport, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResoldBusiness())
            {
                context.Writer.WritePropertyName("resoldBusiness");
                context.Writer.WriteStartObject();

                var marshaller = ResoldBusinessMarshaller.Instance;
                marshaller.Marshall(requestObject.ResoldBusiness, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResoldEnterprise())
            {
                context.Writer.WritePropertyName("resoldEnterprise");
                context.Writer.WriteStartObject();

                var marshaller = ResoldEnterpriseMarshaller.Instance;
                marshaller.Marshall(requestObject.ResoldEnterprise, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SupportPlanMarshaller Instance = new SupportPlanMarshaller();

    }
}