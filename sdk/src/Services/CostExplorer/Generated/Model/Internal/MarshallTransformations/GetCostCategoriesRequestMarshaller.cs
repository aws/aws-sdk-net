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

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCostCategories Request Marshaller
    /// </summary>       
    public class GetCostCategoriesRequestMarshaller : IMarshaller<IRequest, GetCostCategoriesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCostCategoriesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCostCategoriesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.GetCostCategories";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBillingViewArn())
                {
                    context.Writer.WritePropertyName("BillingViewArn");
                    context.Writer.Write(publicRequest.BillingViewArn);
                }

                if(publicRequest.IsSetCostCategoryName())
                {
                    context.Writer.WritePropertyName("CostCategoryName");
                    context.Writer.Write(publicRequest.CostCategoryName);
                }

                if(publicRequest.IsSetFilter())
                {
                    context.Writer.WritePropertyName("Filter");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextPageToken())
                {
                    context.Writer.WritePropertyName("NextPageToken");
                    context.Writer.Write(publicRequest.NextPageToken);
                }

                if(publicRequest.IsSetSearchString())
                {
                    context.Writer.WritePropertyName("SearchString");
                    context.Writer.Write(publicRequest.SearchString);
                }

                if(publicRequest.IsSetSortBy())
                {
                    context.Writer.WritePropertyName("SortBy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSortByListValue in publicRequest.SortBy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SortDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSortByListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimePeriod())
                {
                    context.Writer.WritePropertyName("TimePeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = DateIntervalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimePeriod, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetCostCategoriesRequestMarshaller _instance = new GetCostCategoriesRequestMarshaller();        

        internal static GetCostCategoriesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCostCategoriesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}