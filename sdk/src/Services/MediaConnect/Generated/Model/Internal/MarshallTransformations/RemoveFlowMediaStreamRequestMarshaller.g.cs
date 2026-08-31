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

using Amazon.MediaConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveFlowMediaStream Request Marshaller
    /// </summary>
    public partial class RemoveFlowMediaStreamRequestMarshaller : IMarshaller<IRequest, RemoveFlowMediaStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveFlowMediaStreamRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RemoveFlowMediaStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetFlowArn())
            {
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            }
            request.AddPathResource("{FlowArn}", StringUtils.FromString(publicRequest.FlowArn));

            if (!publicRequest.IsSetMediaStreamName())
            {
                throw new AmazonMediaConnectException("Request object does not have required field MediaStreamName set");
            }
            request.AddPathResource("{MediaStreamName}", StringUtils.FromString(publicRequest.MediaStreamName));

            request.ResourcePath = "/v1/flows/{FlowArn}/mediaStreams/{MediaStreamName}";

            return request;
        }

        private static readonly RemoveFlowMediaStreamRequestMarshaller _instance = new();

        internal static RemoveFlowMediaStreamRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemoveFlowMediaStreamRequestMarshaller Instance => _instance;
    }
}
