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
    /// ProspectingResultCustomer Marshaller
    /// </summary>
    public class ProspectingResultCustomerMarshaller : IRequestMarshaller<ProspectingResultCustomer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProspectingResultCustomer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountName())
            {
                context.Writer.WritePropertyName("AccountName");
                context.Writer.WriteStringValue(requestObject.AccountName);
            }

            if(requestObject.IsSetCompanySize())
            {
                context.Writer.WritePropertyName("CompanySize");
                context.Writer.WriteStringValue(requestObject.CompanySize);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetEligiblePrograms())
            {
                context.Writer.WritePropertyName("EligiblePrograms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEligibleProgramsListValue in requestObject.EligiblePrograms)
                {
                        context.Writer.WriteStringValue(requestObjectEligibleProgramsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGeo())
            {
                context.Writer.WritePropertyName("Geo");
                context.Writer.WriteStringValue(requestObject.Geo);
            }

            if(requestObject.IsSetIndustry())
            {
                context.Writer.WritePropertyName("Industry");
                context.Writer.WriteStringValue(requestObject.Industry);
            }

            if(requestObject.IsSetPublicProfileSummary())
            {
                context.Writer.WritePropertyName("PublicProfileSummary");
                context.Writer.WriteStringValue(requestObject.PublicProfileSummary);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetSegment())
            {
                context.Writer.WritePropertyName("Segment");
                context.Writer.WriteStringValue(requestObject.Segment);
            }

            if(requestObject.IsSetSubIndustry())
            {
                context.Writer.WritePropertyName("SubIndustry");
                context.Writer.WriteStringValue(requestObject.SubIndustry);
            }

            if(requestObject.IsSetSubRegion())
            {
                context.Writer.WritePropertyName("SubRegion");
                context.Writer.WriteStringValue(requestObject.SubRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProspectingResultCustomerMarshaller Instance = new ProspectingResultCustomerMarshaller();

    }
}