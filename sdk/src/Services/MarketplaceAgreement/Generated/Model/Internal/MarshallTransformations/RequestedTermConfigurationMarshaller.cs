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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestedTermConfiguration Marshaller
    /// </summary>
    public class RequestedTermConfigurationMarshaller : IRequestMarshaller<RequestedTermConfiguration, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestedTermConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetConfigurableUpfrontPricingTermConfiguration())
            {
                context.Writer.WriteTextString("configurableUpfrontPricingTermConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = ConfigurableUpfrontPricingTermConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurableUpfrontPricingTermConfiguration, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetRenewalTermConfiguration())
            {
                context.Writer.WriteTextString("renewalTermConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = RenewalTermConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RenewalTermConfiguration, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetVariablePaymentTermConfiguration())
            {
                context.Writer.WriteTextString("variablePaymentTermConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = VariablePaymentTermConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VariablePaymentTermConfiguration, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestedTermConfigurationMarshaller Instance = new RequestedTermConfigurationMarshaller();

    }
}