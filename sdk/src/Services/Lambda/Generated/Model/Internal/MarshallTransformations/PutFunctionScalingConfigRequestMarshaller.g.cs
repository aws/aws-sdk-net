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
    /// PutFunctionScalingConfig Request Marshaller
    /// </summary>
    public partial class PutFunctionScalingConfigRequestMarshaller : IMarshaller<IRequest, PutFunctionScalingConfigRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutFunctionScalingConfigRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutFunctionScalingConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (string.IsNullOrEmpty(publicRequest.Qualifier))
            {
                throw new AmazonLambdaException("Request object does not have required field Qualifier set");
            }

            if (publicRequest.IsSetQualifier())
            {
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            }

            if (!publicRequest.IsSetFunctionName())
            {
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            }
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));

            request.ResourcePath = "/2025-11-30/functions/{FunctionName}/function-scaling-config";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFunctionScalingConfig())
            {
                context.Writer.WritePropertyName("FunctionScalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = FunctionScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.FunctionScalingConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly PutFunctionScalingConfigRequestMarshaller _instance = new();

        internal static PutFunctionScalingConfigRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutFunctionScalingConfigRequestMarshaller Instance => _instance;
    }
}
