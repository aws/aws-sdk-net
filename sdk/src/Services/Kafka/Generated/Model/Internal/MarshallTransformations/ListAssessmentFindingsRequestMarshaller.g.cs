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

using Amazon.Kafka.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAssessmentFindings Request Marshaller
    /// </summary>
    public partial class ListAssessmentFindingsRequestMarshaller : IMarshaller<IRequest, ListAssessmentFindingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAssessmentFindingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAssessmentFindingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCategory())
            {
                request.Parameters.Add("category", StringUtils.FromString(publicRequest.Category));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSeverity())
            {
                request.Parameters.Add("severity", StringUtils.FromString(publicRequest.Severity));
            }

            if (!publicRequest.IsSetAssessmentArn())
            {
                throw new AmazonKafkaException("Request object does not have required field AssessmentArn set");
            }
            request.AddPathResource("{AssessmentArn}", StringUtils.FromString(publicRequest.AssessmentArn));

            if (!publicRequest.IsSetClusterArn())
            {
                throw new AmazonKafkaException("Request object does not have required field ClusterArn set");
            }
            request.AddPathResource("{ClusterArn}", StringUtils.FromString(publicRequest.ClusterArn));

            request.ResourcePath = "/v1/clusters/{ClusterArn}/assessments/{AssessmentArn}/findings";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListAssessmentFindingsRequestMarshaller _instance = new();

        internal static ListAssessmentFindingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAssessmentFindingsRequestMarshaller Instance => _instance;
    }
}
