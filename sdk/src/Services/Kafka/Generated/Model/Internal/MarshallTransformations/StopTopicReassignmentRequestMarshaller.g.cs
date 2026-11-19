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
    /// StopTopicReassignment Request Marshaller
    /// </summary>
    public partial class StopTopicReassignmentRequestMarshaller : IMarshaller<IRequest, StopTopicReassignmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StopTopicReassignmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StopTopicReassignmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kafka");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterArn())
            {
                throw new AmazonKafkaException("Request object does not have required field ClusterArn set");
            }
            request.AddPathResource("{ClusterArn}", StringUtils.FromString(publicRequest.ClusterArn));

            if (!publicRequest.IsSetTopicReassignmentOperationArn())
            {
                throw new AmazonKafkaException("Request object does not have required field TopicReassignmentOperationArn set");
            }
            request.AddPathResource("{TopicReassignmentOperationArn}", StringUtils.FromString(publicRequest.TopicReassignmentOperationArn));

            request.ResourcePath = "/v1/clusters/{ClusterArn}/topic-reassignments/{TopicReassignmentOperationArn}/stop";

            return request;
        }

        private static readonly StopTopicReassignmentRequestMarshaller _instance = new();

        internal static StopTopicReassignmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StopTopicReassignmentRequestMarshaller Instance => _instance;
    }
}
