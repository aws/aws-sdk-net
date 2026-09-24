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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.CodeGuruReviewer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeRecommendationFeedback Request Marshaller
    /// </summary>
    public partial class DescribeRecommendationFeedbackRequestMarshaller : IMarshaller<IRequest, DescribeRecommendationFeedbackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeRecommendationFeedbackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeRecommendationFeedbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruReviewer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-19";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.RecommendationId))
            {
                throw new AmazonCodeGuruReviewerException("Request object does not have required field RecommendationId set");
            }

            if (publicRequest.IsSetRecommendationId())
            {
                request.Parameters.Add("RecommendationId", StringUtils.FromString(publicRequest.RecommendationId));
            }

            if (publicRequest.IsSetUserId())
            {
                request.Parameters.Add("UserId", StringUtils.FromString(publicRequest.UserId));
            }

            if (!publicRequest.IsSetCodeReviewArn())
            {
                throw new AmazonCodeGuruReviewerException("Request object does not have required field CodeReviewArn set");
            }
            request.AddPathResource("{CodeReviewArn}", StringUtils.FromString(publicRequest.CodeReviewArn));

            request.ResourcePath = "/feedback/{CodeReviewArn}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeRecommendationFeedbackRequestMarshaller _instance = new();

        internal static DescribeRecommendationFeedbackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeRecommendationFeedbackRequestMarshaller Instance => _instance;
    }
}
