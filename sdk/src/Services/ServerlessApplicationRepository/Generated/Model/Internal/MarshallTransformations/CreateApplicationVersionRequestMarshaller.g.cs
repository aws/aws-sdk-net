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

using Amazon.ServerlessApplicationRepository.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplicationVersion Request Marshaller
    /// </summary>
    public partial class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetSemanticVersion())
            {
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field SemanticVersion set");
            }
            request.AddPathResource("{SemanticVersion}", StringUtils.FromString(publicRequest.SemanticVersion));

            request.ResourcePath = "/applications/{ApplicationId}/versions/{SemanticVersion}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetSourceCodeArchiveUrl())
            {
                context.Writer.WritePropertyName("sourceCodeArchiveUrl");
                context.Writer.WriteStringValue(publicRequest.SourceCodeArchiveUrl);
            }
            if (publicRequest.IsSetSourceCodeUrl())
            {
                context.Writer.WritePropertyName("sourceCodeUrl");
                context.Writer.WriteStringValue(publicRequest.SourceCodeUrl);
            }
            if (publicRequest.IsSetTemplateBody())
            {
                context.Writer.WritePropertyName("templateBody");
                context.Writer.WriteStringValue(publicRequest.TemplateBody);
            }
            if (publicRequest.IsSetTemplateUrl())
            {
                context.Writer.WritePropertyName("templateUrl");
                context.Writer.WriteStringValue(publicRequest.TemplateUrl);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateApplicationVersionRequestMarshaller _instance = new();

        internal static CreateApplicationVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateApplicationVersionRequestMarshaller Instance => _instance;
    }
}
