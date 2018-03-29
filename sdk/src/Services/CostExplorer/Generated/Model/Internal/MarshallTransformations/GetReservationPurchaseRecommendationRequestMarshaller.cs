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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReservationPurchaseRecommendation Request Marshaller
    /// </summary>       
    public class GetReservationPurchaseRecommendationRequestMarshaller : IMarshaller<IRequest, GetReservationPurchaseRecommendationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReservationPurchaseRecommendationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReservationPurchaseRecommendationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.GetReservationPurchaseRecommendation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetAccountScope())
                {
                    context.Writer.WritePropertyName("AccountScope");
                    context.Writer.Write(publicRequest.AccountScope);
                }

                if(publicRequest.IsSetLookbackPeriodInDays())
                {
                    context.Writer.WritePropertyName("LookbackPeriodInDays");
                    context.Writer.Write(publicRequest.LookbackPeriodInDays);
                }

                if(publicRequest.IsSetNextPageToken())
                {
                    context.Writer.WritePropertyName("NextPageToken");
                    context.Writer.Write(publicRequest.NextPageToken);
                }

                if(publicRequest.IsSetPageSize())
                {
                    context.Writer.WritePropertyName("PageSize");
                    context.Writer.Write(publicRequest.PageSize);
                }

                if(publicRequest.IsSetPaymentOption())
                {
                    context.Writer.WritePropertyName("PaymentOption");
                    context.Writer.Write(publicRequest.PaymentOption);
                }

                if(publicRequest.IsSetService())
                {
                    context.Writer.WritePropertyName("Service");
                    context.Writer.Write(publicRequest.Service);
                }

                if(publicRequest.IsSetServiceSpecification())
                {
                    context.Writer.WritePropertyName("ServiceSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServiceSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTermInYears())
                {
                    context.Writer.WritePropertyName("TermInYears");
                    context.Writer.Write(publicRequest.TermInYears);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetReservationPurchaseRecommendationRequestMarshaller _instance = new GetReservationPurchaseRecommendationRequestMarshaller();        

        internal static GetReservationPurchaseRecommendationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReservationPurchaseRecommendationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}