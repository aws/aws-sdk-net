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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pricing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pricing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPriceLists Request Marshaller
    /// </summary>       
    public class ListPriceListsRequestMarshaller : IMarshaller<IRequest, ListPriceListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPriceListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPriceListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pricing");
            string target = "AWSPriceListService.ListPriceLists";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCurrencyCode())
                {
                    context.Writer.WritePropertyName("CurrencyCode");
                    context.Writer.Write(publicRequest.CurrencyCode);
                }

                if(publicRequest.IsSetEffectiveDate())
                {
                    context.Writer.WritePropertyName("EffectiveDate");
                    context.Writer.Write(publicRequest.EffectiveDate);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetRegionCode())
                {
                    context.Writer.WritePropertyName("RegionCode");
                    context.Writer.Write(publicRequest.RegionCode);
                }

                if(publicRequest.IsSetServiceCode())
                {
                    context.Writer.WritePropertyName("ServiceCode");
                    context.Writer.Write(publicRequest.ServiceCode);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListPriceListsRequestMarshaller _instance = new ListPriceListsRequestMarshaller();        

        internal static ListPriceListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPriceListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}