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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchContacts Request Marshaller
    /// </summary>       
    public class SearchContactsRequestMarshaller : IMarshaller<IRequest, SearchContactsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchContactsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchContactsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/search-contacts";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
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

                if(publicRequest.IsSetSearchCriteria())
                {
                    context.Writer.WritePropertyName("SearchCriteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = SearchCriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SearchCriteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSort())
                {
                    context.Writer.WritePropertyName("Sort");
                    context.Writer.WriteObjectStart();

                    var marshaller = SortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sort, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeRange())
                {
                    context.Writer.WritePropertyName("TimeRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = SearchContactsTimeRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeRange, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SearchContactsRequestMarshaller _instance = new SearchContactsRequestMarshaller();        

        internal static SearchContactsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchContactsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618