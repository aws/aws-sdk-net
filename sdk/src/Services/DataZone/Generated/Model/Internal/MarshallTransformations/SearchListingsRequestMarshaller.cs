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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchListings Request Marshaller
    /// </summary>       
    public class SearchListingsRequestMarshaller : IMarshaller<IRequest, SearchListingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchListingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchListingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/listings/search";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalAttributes())
                {
                    context.Writer.WritePropertyName("additionalAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalAttributesListValue in publicRequest.AdditionalAttributes)
                    {
                            context.Writer.Write(publicRequestAdditionalAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAggregations())
                {
                    context.Writer.WritePropertyName("aggregations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAggregationsListValue in publicRequest.Aggregations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AggregationListItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestAggregationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterClauseMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filters, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetSearchIn())
                {
                    context.Writer.WritePropertyName("searchIn");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSearchInListValue in publicRequest.SearchIn)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SearchInItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestSearchInListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSearchText())
                {
                    context.Writer.WritePropertyName("searchText");
                    context.Writer.Write(publicRequest.SearchText);
                }

                if(publicRequest.IsSetSort())
                {
                    context.Writer.WritePropertyName("sort");
                    context.Writer.WriteObjectStart();

                    var marshaller = SearchSortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sort, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SearchListingsRequestMarshaller _instance = new SearchListingsRequestMarshaller();        

        internal static SearchListingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchListingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}