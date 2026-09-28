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

using Amazon.CodeCatalyst.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSourceRepositoryBranch Request Marshaller
    /// </summary>
    public partial class CreateSourceRepositoryBranchRequestMarshaller : IMarshaller<IRequest, CreateSourceRepositoryBranchRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSourceRepositoryBranchRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateSourceRepositoryBranchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCatalyst");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
            {
                throw new AmazonCodeCatalystException("Request object does not have required field Name set");
            }
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));

            if (!publicRequest.IsSetProjectName())
            {
                throw new AmazonCodeCatalystException("Request object does not have required field ProjectName set");
            }
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));

            if (!publicRequest.IsSetSourceRepositoryName())
            {
                throw new AmazonCodeCatalystException("Request object does not have required field SourceRepositoryName set");
            }
            request.AddPathResource("{sourceRepositoryName}", StringUtils.FromString(publicRequest.SourceRepositoryName));

            if (!publicRequest.IsSetSpaceName())
            {
                throw new AmazonCodeCatalystException("Request object does not have required field SpaceName set");
            }
            request.AddPathResource("{spaceName}", StringUtils.FromString(publicRequest.SpaceName));

            request.ResourcePath = "/v1/spaces/{spaceName}/projects/{projectName}/sourceRepositories/{sourceRepositoryName}/branches/{name}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetHeadCommitId())
            {
                context.Writer.WritePropertyName("headCommitId");
                context.Writer.WriteStringValue(publicRequest.HeadCommitId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateSourceRepositoryBranchRequestMarshaller _instance = new();

        internal static CreateSourceRepositoryBranchRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateSourceRepositoryBranchRequestMarshaller Instance => _instance;
    }
}
