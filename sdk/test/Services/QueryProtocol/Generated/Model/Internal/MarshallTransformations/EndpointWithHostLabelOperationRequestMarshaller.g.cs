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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.QueryProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EndpointWithHostLabelOperation Request Marshaller
    /// </summary>
    public partial class EndpointWithHostLabelOperationRequestMarshaller : IMarshaller<IRequest, EndpointWithHostLabelOperationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EndpointWithHostLabelOperationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(EndpointWithHostLabelOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "EndpointWithHostLabelOperation");
            request.Parameters.Add("Version", "2020-01-08");

            if (publicRequest.IsSetLabel())
            {
                request.Parameters.Add("label", StringUtils.FromString(publicRequest.Label));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            var hostPrefixLabels = new
            {
                label = StringUtils.FromString(publicRequest.Label),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.label))
            {
                throw new AmazonQueryProtocolException("label can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");
            }

            request.HostPrefix = $"foo.{hostPrefixLabels.label}.";

            return request;
        }

        private static readonly EndpointWithHostLabelOperationRequestMarshaller _instance = new();

        internal static EndpointWithHostLabelOperationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EndpointWithHostLabelOperationRequestMarshaller Instance => _instance;
    }
}
