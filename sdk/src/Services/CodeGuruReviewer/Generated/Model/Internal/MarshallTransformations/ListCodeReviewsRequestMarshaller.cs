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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruReviewer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCodeReviews Request Marshaller
    /// </summary>       
    public class ListCodeReviewsRequestMarshaller : IMarshaller<IRequest, ListCodeReviewsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCodeReviewsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCodeReviewsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruReviewer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-19";            
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetProviderTypes())
                request.ParameterCollection.Add("ProviderTypes", publicRequest.ProviderTypes);
            
            if (publicRequest.IsSetRepositoryNames())
                request.ParameterCollection.Add("RepositoryNames", publicRequest.RepositoryNames);
            
            if (publicRequest.IsSetStates())
                request.ParameterCollection.Add("States", publicRequest.States);
            
            if (publicRequest.IsSetType())
                request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
            request.ResourcePath = "/codereviews";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListCodeReviewsRequestMarshaller _instance = new ListCodeReviewsRequestMarshaller();        

        internal static ListCodeReviewsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCodeReviewsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}