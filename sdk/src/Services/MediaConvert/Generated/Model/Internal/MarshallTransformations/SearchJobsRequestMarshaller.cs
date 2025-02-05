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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
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
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchJobs Request Marshaller
    /// </summary>       
    public class SearchJobsRequestMarshaller : IMarshaller<IRequest, SearchJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConvert");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-29";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetInputFile())
                request.Parameters.Add("inputFile", StringUtils.FromString(publicRequest.InputFile));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOrder())
                request.Parameters.Add("order", StringUtils.FromString(publicRequest.Order));
            
            if (publicRequest.IsSetQueue())
                request.Parameters.Add("queue", StringUtils.FromString(publicRequest.Queue));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            request.ResourcePath = "/2017-08-29/search";
            request.UseQueryString = true;

            return request;
        }
        private static SearchJobsRequestMarshaller _instance = new SearchJobsRequestMarshaller();        

        internal static SearchJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}