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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
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
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPolicyPreviewJobs Request Marshaller
    /// </summary>       
    public class ListPolicyPreviewJobsRequestMarshaller : IMarshaller<IRequest, ListPolicyPreviewJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPolicyPreviewJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPolicyPreviewJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetFilters())
            {
                foreach(var kvp in publicRequest.Filters)
                {
                    if(request.Parameters.ContainsKey(kvp.Key))
                       continue;
                    else
                       request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));
                }
            }
            if (publicRequest.IsSetMaxResults())
            {
                if(request.Parameters.ContainsKey("maxResults"))
                   request.Parameters.Remove("maxResults");
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            }
            if (publicRequest.IsSetNextToken())
            {
                if(request.Parameters.ContainsKey("nextToken"))
                   request.Parameters.Remove("nextToken");
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            request.ResourcePath = "/policy/preview";
            request.UseQueryString = true;

            return request;
        }
        private static ListPolicyPreviewJobsRequestMarshaller _instance = new ListPolicyPreviewJobsRequestMarshaller();        

        internal static ListPolicyPreviewJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPolicyPreviewJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}