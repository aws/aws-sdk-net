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
    /// DescribeSavingsPlansOfferingRates Request Marshaller
    /// </summary>       
    public class DescribeSavingsPlansOfferingRatesRequestMarshaller : IMarshaller<IRequest, DescribeSavingsPlansOfferingRatesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSavingsPlansOfferingRatesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeSavingsPlansOfferingRatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SavingsPlans");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/DescribeSavingsPlansOfferingRates";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SavingsPlanOfferingRateFilterElementMarshaller.Instance;
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

                if(publicRequest.IsSetProducts())
                {
                    context.Writer.WritePropertyName("products");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProductsListValue in publicRequest.Products)
                    {
                            context.Writer.Write(publicRequestProductsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSavingsPlanOfferingIds())
                {
                    context.Writer.WritePropertyName("savingsPlanOfferingIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSavingsPlanOfferingIdsListValue in publicRequest.SavingsPlanOfferingIds)
                    {
                            context.Writer.Write(publicRequestSavingsPlanOfferingIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSavingsPlanPaymentOptions())
                {
                    context.Writer.WritePropertyName("savingsPlanPaymentOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSavingsPlanPaymentOptionsListValue in publicRequest.SavingsPlanPaymentOptions)
                    {
                            context.Writer.Write(publicRequestSavingsPlanPaymentOptionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSavingsPlanTypes())
                {
                    context.Writer.WritePropertyName("savingsPlanTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSavingsPlanTypesListValue in publicRequest.SavingsPlanTypes)
                    {
                            context.Writer.Write(publicRequestSavingsPlanTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
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
        private static DescribeSavingsPlansOfferingRatesRequestMarshaller _instance = new DescribeSavingsPlansOfferingRatesRequestMarshaller();        

        internal static DescribeSavingsPlansOfferingRatesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeSavingsPlansOfferingRatesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}