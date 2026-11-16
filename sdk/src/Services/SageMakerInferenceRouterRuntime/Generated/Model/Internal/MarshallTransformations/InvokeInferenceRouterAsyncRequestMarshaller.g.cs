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

using Amazon.SageMakerInferenceRouterRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerInferenceRouterRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeInferenceRouterAsync Request Marshaller
    /// </summary>
    public partial class InvokeInferenceRouterAsyncRequestMarshaller : IMarshaller<IRequest, InvokeInferenceRouterAsyncRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeInferenceRouterAsyncRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeInferenceRouterAsyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerInferenceRouterRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccept())
            {
                request.Headers["X-Amzn-SageMaker-Accept"] = publicRequest.Accept;
            }

            if (publicRequest.IsSetContentType())
            {
                request.Headers["X-Amzn-SageMaker-Content-Type"] = publicRequest.ContentType;
            }

            if (publicRequest.IsSetCustomAttributes())
            {
                request.Headers["X-Amzn-SageMaker-Custom-Attributes"] = publicRequest.CustomAttributes;
            }

            if (publicRequest.IsSetFilename())
            {
                request.Headers["X-Amzn-SageMaker-Filename"] = publicRequest.Filename;
            }

            if (publicRequest.IsSetInferenceId())
            {
                request.Headers["X-Amzn-SageMaker-Inference-Id"] = publicRequest.InferenceId;
            }

            if (publicRequest.IsSetInputLocation())
            {
                request.Headers["X-Amzn-SageMaker-InputLocation"] = publicRequest.InputLocation;
            }

            if (publicRequest.IsSetInvocationTimeoutSeconds())
            {
                request.Headers["X-Amzn-SageMaker-InvocationTimeoutSeconds"] = StringUtils.FromInt(publicRequest.InvocationTimeoutSeconds.Value);
            }

            if (publicRequest.IsSetRequestTTLSeconds())
            {
                request.Headers["X-Amzn-SageMaker-RequestTTLSeconds"] = StringUtils.FromInt(publicRequest.RequestTTLSeconds.Value);
            }

            if (publicRequest.IsSetRoutingTargetName())
            {
                request.Headers["X-Amzn-SageMaker-Routing-Target-Name"] = publicRequest.RoutingTargetName;
            }

            if (publicRequest.IsSetS3OutputPathExtension())
            {
                request.Headers["X-Amzn-SageMaker-S3OutputPathExtension"] = publicRequest.S3OutputPathExtension;
            }

            if (!publicRequest.IsSetInferenceRouterName())
            {
                throw new AmazonSageMakerInferenceRouterRuntimeException("Request object does not have required field InferenceRouterName set");
            }
            request.AddPathResource("{InferenceRouterName}", StringUtils.FromString(publicRequest.InferenceRouterName));

            request.ResourcePath = "/inference-routers/{InferenceRouterName}/async-invocations";

            return request;
        }

        private static readonly InvokeInferenceRouterAsyncRequestMarshaller _instance = new();

        internal static InvokeInferenceRouterAsyncRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeInferenceRouterAsyncRequestMarshaller Instance => _instance;
    }
}
