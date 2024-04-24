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
    /// SearchTasks Request Marshaller
    /// </summary>       
    public class SearchTasksRequestMarshaller : IMarshaller<IRequest, SearchTasksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchTasksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/search/tasks";
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

                if(publicRequest.IsSetItemOffset())
                {
                    context.Writer.WritePropertyName("itemOffset");
                    context.Writer.Write(publicRequest.ItemOffset);
                }

                if(publicRequest.IsSetJobId())
                {
                    context.Writer.WritePropertyName("jobId");
                    context.Writer.Write(publicRequest.JobId);
                }

                if(publicRequest.IsSetPageSize())
                {
                    context.Writer.WritePropertyName("pageSize");
                    context.Writer.Write(publicRequest.PageSize);
                }

                if(publicRequest.IsSetQueueIds())
                {
                    context.Writer.WritePropertyName("queueIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQueueIdsListValue in publicRequest.QueueIds)
                    {
                            context.Writer.Write(publicRequestQueueIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
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
        private static SearchTasksRequestMarshaller _instance = new SearchTasksRequestMarshaller();        

        internal static SearchTasksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchTasksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}