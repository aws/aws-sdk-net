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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOpportunity Request Marshaller
    /// </summary>       
    public class UpdateOpportunityRequestMarshaller : IMarshaller<IRequest, UpdateOpportunityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOpportunityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOpportunityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralSelling");
            string target = "AWSPartnerCentralSelling.UpdateOpportunity";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("Catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetCustomer())
                {
                    context.Writer.WritePropertyName("Customer");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomerMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Customer, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentifier())
                {
                    context.Writer.WritePropertyName("Identifier");
                    context.Writer.Write(publicRequest.Identifier);
                }

                if(publicRequest.IsSetLastModifiedDate())
                {
                    context.Writer.WritePropertyName("LastModifiedDate");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.LastModifiedDate));
                }

                if(publicRequest.IsSetLifeCycle())
                {
                    context.Writer.WritePropertyName("LifeCycle");
                    context.Writer.WriteObjectStart();

                    var marshaller = LifeCycleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LifeCycle, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMarketing())
                {
                    context.Writer.WritePropertyName("Marketing");
                    context.Writer.WriteObjectStart();

                    var marshaller = MarketingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Marketing, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNationalSecurity())
                {
                    context.Writer.WritePropertyName("NationalSecurity");
                    context.Writer.Write(publicRequest.NationalSecurity);
                }

                if(publicRequest.IsSetOpportunityType())
                {
                    context.Writer.WritePropertyName("OpportunityType");
                    context.Writer.Write(publicRequest.OpportunityType);
                }

                if(publicRequest.IsSetPartnerOpportunityIdentifier())
                {
                    context.Writer.WritePropertyName("PartnerOpportunityIdentifier");
                    context.Writer.Write(publicRequest.PartnerOpportunityIdentifier);
                }

                if(publicRequest.IsSetPrimaryNeedsFromAws())
                {
                    context.Writer.WritePropertyName("PrimaryNeedsFromAws");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPrimaryNeedsFromAwsListValue in publicRequest.PrimaryNeedsFromAws)
                    {
                            context.Writer.Write(publicRequestPrimaryNeedsFromAwsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProject())
                {
                    context.Writer.WritePropertyName("Project");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProjectMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Project, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSoftwareRevenue())
                {
                    context.Writer.WritePropertyName("SoftwareRevenue");
                    context.Writer.WriteObjectStart();

                    var marshaller = SoftwareRevenueMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SoftwareRevenue, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOpportunityRequestMarshaller _instance = new UpdateOpportunityRequestMarshaller();        

        internal static UpdateOpportunityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOpportunityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}