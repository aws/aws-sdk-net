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

using Amazon.Greengrass.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateResourceDefinitionVersion Request Marshaller
    /// </summary>
    public partial class CreateResourceDefinitionVersionRequestMarshaller : IMarshaller<IRequest, CreateResourceDefinitionVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResourceDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateResourceDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAmznClientToken())
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.AmznClientToken;
            }

            if (!publicRequest.IsSetResourceDefinitionId())
            {
                throw new AmazonGreengrassException("Request object does not have required field ResourceDefinitionId set");
            }
            request.AddPathResource("{ResourceDefinitionId}", StringUtils.FromString(publicRequest.ResourceDefinitionId));

            request.ResourcePath = "/greengrass/definition/resources/{ResourceDefinitionId}/versions";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartArray();
                foreach (var publicRequestResourcesListValue in publicRequest.Resources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestResourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateResourceDefinitionVersionRequestMarshaller _instance = new();

        internal static CreateResourceDefinitionVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateResourceDefinitionVersionRequestMarshaller Instance => _instance;
    }
}
