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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchWorkers Request Marshaller
    /// </summary>       
    public class SearchWorkersRequestMarshaller : IMarshaller<IRequest, SearchWorkersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchWorkersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchWorkersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/search/workers";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFilterExpressions())
                {
                    context.Writer.WritePropertyName("filterExpressions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SearchGroupedFilterExpressionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FilterExpressions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFleetIds())
                {
                    context.Writer.WritePropertyName("fleetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFleetIdsListValue in publicRequest.FleetIds)
                    {
                            context.Writer.Write(publicRequestFleetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetItemOffset())
                {
                    context.Writer.WritePropertyName("itemOffset");
                    context.Writer.Write(publicRequest.ItemOffset);
                }

                if(publicRequest.IsSetPageSize())
                {
                    context.Writer.WritePropertyName("pageSize");
                    context.Writer.Write(publicRequest.PageSize);
                }

                if(publicRequest.IsSetSortExpressions())
                {
                    context.Writer.WritePropertyName("sortExpressions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSortExpressionsListValue in publicRequest.SortExpressions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SearchSortExpressionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSortExpressionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"management.";

            return request;
        }
        private static SearchWorkersRequestMarshaller _instance = new SearchWorkersRequestMarshaller();        

        internal static SearchWorkersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchWorkersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}