/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SavingsPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SavingsPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSavingsPlansOfferings Request Marshaller
    /// </summary>       
    public class DescribeSavingsPlansOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeSavingsPlansOfferingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSavingsPlansOfferingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeSavingsPlansOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SavingsPlans");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/DescribeSavingsPlansOfferings";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCurrencies())
                {
                    context.Writer.WritePropertyName("currencies");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCurrenciesListValue in publicRequest.Currencies)
                    {
                            context.Writer.Write(publicRequestCurrenciesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescriptions())
                {
                    context.Writer.WritePropertyName("descriptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDescriptionsListValue in publicRequest.Descriptions)
                    {
                            context.Writer.Write(publicRequestDescriptionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDurations())
                {
                    context.Writer.WritePropertyName("durations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDurationsListValue in publicRequest.Durations)
                    {
                            context.Writer.Write(publicRequestDurationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SavingsPlanOfferingFilterElementMarshaller.Instance;
                        marshaller.Marshall(publicRequestFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetOfferingIds())
                {
                    context.Writer.WritePropertyName("offeringIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOfferingIdsListValue in publicRequest.OfferingIds)
                    {
                            context.Writer.Write(publicRequestOfferingIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOperations())
                {
                    context.Writer.WritePropertyName("operations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOperationsListValue in publicRequest.Operations)
                    {
                            context.Writer.Write(publicRequestOperationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPaymentOptions())
                {
                    context.Writer.WritePropertyName("paymentOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPaymentOptionsListValue in publicRequest.PaymentOptions)
                    {
                            context.Writer.Write(publicRequestPaymentOptionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPlanTypes())
                {
                    context.Writer.WritePropertyName("planTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlanTypesListValue in publicRequest.PlanTypes)
                    {
                            context.Writer.Write(publicRequestPlanTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProductType())
                {
                    context.Writer.WritePropertyName("productType");
                    context.Writer.Write(publicRequest.ProductType);
                }

                if(publicRequest.IsSetServiceCodes())
                {
                    context.Writer.WritePropertyName("serviceCodes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestServiceCodesListValue in publicRequest.ServiceCodes)
                    {
                            context.Writer.Write(publicRequestServiceCodesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUsageTypes())
                {
                    context.Writer.WritePropertyName("usageTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUsageTypesListValue in publicRequest.UsageTypes)
                    {
                            context.Writer.Write(publicRequestUsageTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeSavingsPlansOfferingsRequestMarshaller _instance = new DescribeSavingsPlansOfferingsRequestMarshaller();        

        internal static DescribeSavingsPlansOfferingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeSavingsPlansOfferingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}