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

using Amazon.AmplifyUIBuilder.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateComponent Request Marshaller
    /// </summary>
    public partial class CreateComponentRequestMarshaller : IMarshaller<IRequest, CreateComponentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateComponentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyUIBuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-11";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            if (!publicRequest.IsSetAppId())
            {
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field AppId set");
            }
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));

            if (!publicRequest.IsSetEnvironmentName())
            {
                throw new AmazonAmplifyUIBuilderException("Request object does not have required field EnvironmentName set");
            }
            request.AddPathResource("{environmentName}", StringUtils.FromString(publicRequest.EnvironmentName));

            request.ResourcePath = "/app/{appId}/environment/{environmentName}/components";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            var context = new JsonMarshallerContext(request, writer);
            context.Writer.WriteStartObject();

            var marshaller = CreateComponentDataMarshaller.Instance;
            marshaller.Marshall(publicRequest.ComponentToCreate, context);

            context.Writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly CreateComponentRequestMarshaller _instance = new();

        internal static CreateComponentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateComponentRequestMarshaller Instance => _instance;
    }
}
