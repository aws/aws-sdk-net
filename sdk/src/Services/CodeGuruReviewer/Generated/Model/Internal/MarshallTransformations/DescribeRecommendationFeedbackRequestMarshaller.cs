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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeRecommendationFeedback Request Marshaller
    /// </summary>       
    public class DescribeRecommendationFeedbackRequestMarshaller : IMarshaller<IRequest, DescribeRecommendationFeedbackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeRecommendationFeedbackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeRecommendationFeedbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruReviewer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCodeReviewArn())
                throw new AmazonCodeGuruReviewerException("Request object does not have required field CodeReviewArn set");
            request.AddPathResource("{CodeReviewArn}", StringUtils.FromString(publicRequest.CodeReviewArn));
            
            if (publicRequest.IsSetRecommendationId())
                request.Parameters.Add("RecommendationId", StringUtils.FromString(publicRequest.RecommendationId));
            
            if (publicRequest.IsSetUserId())
                request.Parameters.Add("UserId", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/feedback/{CodeReviewArn}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeRecommendationFeedbackRequestMarshaller _instance = new DescribeRecommendationFeedbackRequestMarshaller();        

        internal static DescribeRecommendationFeedbackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeRecommendationFeedbackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}