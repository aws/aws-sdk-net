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

using Amazon.AgentRegistryControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPublisherAssociations Request Marshaller
    /// </summary>
    public partial class ListPublisherAssociationsRequestMarshaller : IMarshaller<IRequest, ListPublisherAssociationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPublisherAssociationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListPublisherAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AgentRegistryControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-12-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetPublisherArn())
            {
                request.Parameters.Add("publisherArn", StringUtils.FromString(publicRequest.PublisherArn));
            }

            request.ResourcePath = "/associations";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListPublisherAssociationsRequestMarshaller _instance = new();

        internal static ListPublisherAssociationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListPublisherAssociationsRequestMarshaller Instance => _instance;
    }
}
