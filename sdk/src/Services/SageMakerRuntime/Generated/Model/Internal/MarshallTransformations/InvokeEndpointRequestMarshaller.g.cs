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

using Amazon.SageMakerRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeEndpoint Request Marshaller
    /// </summary>
    public partial class InvokeEndpointRequestMarshaller : IMarshaller<IRequest, InvokeEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerRuntime");
            request.Headers["Content-Type"] = "application/octet-stream";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-05-13";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccept())
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }

            if (publicRequest.IsSetContentType())
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }

            if (publicRequest.IsSetCustomAttributes())
            {
                request.Headers["X-Amzn-SageMaker-Custom-Attributes"] = publicRequest.CustomAttributes;
            }

            if (publicRequest.IsSetEnableExplanations())
            {
                request.Headers["X-Amzn-SageMaker-Enable-Explanations"] = publicRequest.EnableExplanations;
            }

            if (publicRequest.IsSetInferenceComponentName())
            {
                request.Headers["X-Amzn-SageMaker-Inference-Component"] = publicRequest.InferenceComponentName;
            }

            if (publicRequest.IsSetInferenceId())
            {
                request.Headers["X-Amzn-SageMaker-Inference-Id"] = publicRequest.InferenceId;
            }

            if (publicRequest.IsSetPrefixAwareId())
            {
                request.Headers["X-Amzn-SageMaker-Prefix-Aware-Id"] = publicRequest.PrefixAwareId;
            }

            if (publicRequest.IsSetSessionId())
            {
                request.Headers["X-Amzn-SageMaker-Session-Id"] = publicRequest.SessionId;
            }

            if (publicRequest.IsSetTargetContainerHostname())
            {
                request.Headers["X-Amzn-SageMaker-Target-Container-Hostname"] = publicRequest.TargetContainerHostname;
            }

            if (publicRequest.IsSetTargetModel())
            {
                request.Headers["X-Amzn-SageMaker-Target-Model"] = publicRequest.TargetModel;
            }

            if (publicRequest.IsSetTargetVariant())
            {
                request.Headers["X-Amzn-SageMaker-Target-Variant"] = publicRequest.TargetVariant;
            }

            if (!publicRequest.IsSetEndpointName())
            {
                throw new AmazonSageMakerRuntimeException("Request object does not have required field EndpointName set");
            }
            request.AddPathResource("{EndpointName}", StringUtils.FromString(publicRequest.EndpointName));

            request.ResourcePath = "/endpoints/{EndpointName}/invocations";
            request.ContentStream = publicRequest.Body ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);

            return request;
        }

        private static readonly InvokeEndpointRequestMarshaller _instance = new();

        internal static InvokeEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeEndpointRequestMarshaller Instance => _instance;
    }
}
