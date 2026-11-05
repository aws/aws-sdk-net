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

using Amazon.Lambda.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Invoke Request Marshaller
    /// </summary>
    public partial class InvokeRequestMarshaller : IMarshaller<IRequest, InvokeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetQualifier())
            {
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            }

            if (publicRequest.IsSetClientContextBase64())
            {
                request.Headers["X-Amz-Client-Context"] = publicRequest.ClientContextBase64;
            }

            if (publicRequest.IsSetDurableExecutionName())
            {
                request.Headers["X-Amz-Durable-Execution-Name"] = publicRequest.DurableExecutionName;
            }

            if (publicRequest.IsSetInvocationType())
            {
                request.Headers["X-Amz-Invocation-Type"] = publicRequest.InvocationType;
            }

            if (publicRequest.IsSetLogType())
            {
                request.Headers["X-Amz-Log-Type"] = publicRequest.LogType;
            }

            if (publicRequest.IsSetTenantId())
            {
                request.Headers["X-Amz-Tenant-Id"] = publicRequest.TenantId;
            }

            if (!publicRequest.IsSetFunctionName())
            {
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            }
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));

            request.ResourcePath = "/2015-03-31/functions/{FunctionName}/invocations";
            request.ContentStream = publicRequest.PayloadStream ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";

            request.UseQueryString = true;

            return request;
        }

        private static readonly InvokeRequestMarshaller _instance = new();

        internal static InvokeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeRequestMarshaller Instance => _instance;
    }
}
