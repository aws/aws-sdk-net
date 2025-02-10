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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Account Marshaller
    /// </summary>
    public class AccountMarshaller : IRequestMarshaller<Account, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Account requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.WriteStartObject();

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.Address, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("AwsAccountId");
                context.Writer.WriteStringValue(requestObject.AwsAccountId);
            }

            if(requestObject.IsSetCompanyName())
            {
                context.Writer.WritePropertyName("CompanyName");
                context.Writer.WriteStringValue(requestObject.CompanyName);
            }

            if(requestObject.IsSetDuns())
            {
                context.Writer.WritePropertyName("Duns");
                context.Writer.WriteStringValue(requestObject.Duns);
            }

            if(requestObject.IsSetIndustry())
            {
                context.Writer.WritePropertyName("Industry");
                context.Writer.WriteStringValue(requestObject.Industry);
            }

            if(requestObject.IsSetOtherIndustry())
            {
                context.Writer.WritePropertyName("OtherIndustry");
                context.Writer.WriteStringValue(requestObject.OtherIndustry);
            }

            if(requestObject.IsSetWebsiteUrl())
            {
                context.Writer.WritePropertyName("WebsiteUrl");
                context.Writer.WriteStringValue(requestObject.WebsiteUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AccountMarshaller Instance = new AccountMarshaller();

    }
}