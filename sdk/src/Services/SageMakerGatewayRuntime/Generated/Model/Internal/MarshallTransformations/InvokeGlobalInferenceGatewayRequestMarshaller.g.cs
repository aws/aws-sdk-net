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

using Amazon.SageMakerGatewayRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerGatewayRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeGlobalInferenceGateway Request Marshaller
    /// </summary>
    public partial class InvokeGlobalInferenceGatewayRequestMarshaller : IMarshaller<IRequest, InvokeGlobalInferenceGatewayRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeGlobalInferenceGatewayRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeGlobalInferenceGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerGatewayRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-10-01";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccept())
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }

            if (publicRequest.IsSetContentType())
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }

            if (publicRequest.IsSetCustomerIdentityToken())
            {
                request.Headers["X-Amzn-SageMaker-Customer-Identity-Token"] = publicRequest.CustomerIdentityToken;
            }

            if (!publicRequest.IsSetGatewayId())
            {
                throw new AmazonSageMakerGatewayRuntimeException("Request object does not have required field GatewayId set");
            }
            request.AddPathResource("{GatewayId}", StringUtils.FromString(publicRequest.GatewayId));

            request.ResourcePath = "/global-inference-gateway/{GatewayId}/invocations";
            request.ContentStream = publicRequest.Body ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);

            return request;
        }

        private static readonly InvokeGlobalInferenceGatewayRequestMarshaller _instance = new();

        internal static InvokeGlobalInferenceGatewayRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeGlobalInferenceGatewayRequestMarshaller Instance => _instance;
    }
}
