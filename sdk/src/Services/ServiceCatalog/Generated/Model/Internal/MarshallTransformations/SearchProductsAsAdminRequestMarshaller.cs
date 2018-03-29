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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchProductsAsAdmin Request Marshaller
    /// </summary>       
    public class SearchProductsAsAdminRequestMarshaller : IMarshaller<IRequest, SearchProductsAsAdminRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchProductsAsAdminRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchProductsAsAdminRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.SearchProductsAsAdmin";
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
                if(publicRequest.IsSetAcceptLanguage())
                {
                    context.Writer.WritePropertyName("AcceptLanguage");
                    context.Writer.Write(publicRequest.AcceptLanguage);
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("Filters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFiltersKvp in publicRequest.Filters)
                    {
                        context.Writer.WritePropertyName(publicRequestFiltersKvp.Key);
                        var publicRequestFiltersValue = publicRequestFiltersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestFiltersValueListValue in publicRequestFiltersValue)
                        {
                                context.Writer.Write(publicRequestFiltersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPageSize())
                {
                    context.Writer.WritePropertyName("PageSize");
                    context.Writer.Write(publicRequest.PageSize);
                }

                if(publicRequest.IsSetPageToken())
                {
                    context.Writer.WritePropertyName("PageToken");
                    context.Writer.Write(publicRequest.PageToken);
                }

                if(publicRequest.IsSetPortfolioId())
                {
                    context.Writer.WritePropertyName("PortfolioId");
                    context.Writer.Write(publicRequest.PortfolioId);
                }

                if(publicRequest.IsSetProductSource())
                {
                    context.Writer.WritePropertyName("ProductSource");
                    context.Writer.Write(publicRequest.ProductSource);
                }

                if(publicRequest.IsSetSortBy())
                {
                    context.Writer.WritePropertyName("SortBy");
                    context.Writer.Write(publicRequest.SortBy);
                }

                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("SortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SearchProductsAsAdminRequestMarshaller _instance = new SearchProductsAsAdminRequestMarshaller();        

        internal static SearchProductsAsAdminRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchProductsAsAdminRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}