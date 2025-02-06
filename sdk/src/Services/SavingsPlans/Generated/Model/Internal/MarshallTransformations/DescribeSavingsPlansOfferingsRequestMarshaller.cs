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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCurrencies())
            {
                context.Writer.WritePropertyName("currencies");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCurrenciesListValue in publicRequest.Currencies)
                {
                        context.Writer.WriteStringValue(publicRequestCurrenciesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescriptions())
            {
                context.Writer.WritePropertyName("descriptions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDescriptionsListValue in publicRequest.Descriptions)
                {
                        context.Writer.WriteStringValue(publicRequestDescriptionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDurations())
            {
                context.Writer.WritePropertyName("durations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDurationsListValue in publicRequest.Durations)
                {
                        context.Writer.WriteNumberValue(publicRequestDurationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SavingsPlanOfferingFilterElementMarshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetOfferingIds())
            {
                context.Writer.WritePropertyName("offeringIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOfferingIdsListValue in publicRequest.OfferingIds)
                {
                        context.Writer.WriteStringValue(publicRequestOfferingIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOperations())
            {
                context.Writer.WritePropertyName("operations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOperationsListValue in publicRequest.Operations)
                {
                        context.Writer.WriteStringValue(publicRequestOperationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPaymentOptions())
            {
                context.Writer.WritePropertyName("paymentOptions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPaymentOptionsListValue in publicRequest.PaymentOptions)
                {
                        context.Writer.WriteStringValue(publicRequestPaymentOptionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPlanTypes())
            {
                context.Writer.WritePropertyName("planTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlanTypesListValue in publicRequest.PlanTypes)
                {
                        context.Writer.WriteStringValue(publicRequestPlanTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetProductType())
            {
                context.Writer.WritePropertyName("productType");
                context.Writer.WriteStringValue(publicRequest.ProductType);
            }

            if(publicRequest.IsSetServiceCodes())
            {
                context.Writer.WritePropertyName("serviceCodes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestServiceCodesListValue in publicRequest.ServiceCodes)
                {
                        context.Writer.WriteStringValue(publicRequestServiceCodesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUsageTypes())
            {
                context.Writer.WritePropertyName("usageTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUsageTypesListValue in publicRequest.UsageTypes)
                {
                        context.Writer.WriteStringValue(publicRequestUsageTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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