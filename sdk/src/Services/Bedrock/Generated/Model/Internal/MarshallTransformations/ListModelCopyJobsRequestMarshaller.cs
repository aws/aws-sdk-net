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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
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
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListModelCopyJobs Request Marshaller
    /// </summary>       
    public class ListModelCopyJobsRequestMarshaller : IMarshaller<IRequest, ListModelCopyJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListModelCopyJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListModelCopyJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCreationTimeAfter())
                request.Parameters.Add("creationTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeAfter));
            
            if (publicRequest.IsSetCreationTimeBefore())
                request.Parameters.Add("creationTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeBefore));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSortBy())
                request.Parameters.Add("sortBy", StringUtils.FromString(publicRequest.SortBy));
            
            if (publicRequest.IsSetSortOrder())
                request.Parameters.Add("sortOrder", StringUtils.FromString(publicRequest.SortOrder));
            
            if (publicRequest.IsSetSourceAccountEquals())
                request.Parameters.Add("sourceAccountEquals", StringUtils.FromString(publicRequest.SourceAccountEquals));
            
            if (publicRequest.IsSetSourceModelArnEquals())
                request.Parameters.Add("sourceModelArnEquals", StringUtils.FromString(publicRequest.SourceModelArnEquals));
            
            if (publicRequest.IsSetStatusEquals())
                request.Parameters.Add("statusEquals", StringUtils.FromString(publicRequest.StatusEquals));
            
            if (publicRequest.IsSetTargetModelNameContains())
                request.Parameters.Add("outputModelNameContains", StringUtils.FromString(publicRequest.TargetModelNameContains));
            request.ResourcePath = "/model-copy-jobs";
            request.UseQueryString = true;

            return request;
        }
        private static ListModelCopyJobsRequestMarshaller _instance = new ListModelCopyJobsRequestMarshaller();        

        internal static ListModelCopyJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListModelCopyJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}