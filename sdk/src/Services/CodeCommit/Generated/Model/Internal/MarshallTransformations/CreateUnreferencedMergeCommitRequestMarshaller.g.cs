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

using Amazon.CodeCommit.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUnreferencedMergeCommit Request Marshaller
    /// </summary>
    public partial class CreateUnreferencedMergeCommitRequestMarshaller : IMarshaller<IRequest, CreateUnreferencedMergeCommitRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUnreferencedMergeCommitRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateUnreferencedMergeCommitRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.CreateUnreferencedMergeCommit";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAuthorName())
            {
                context.Writer.WritePropertyName("authorName");
                context.Writer.WriteStringValue(publicRequest.AuthorName);
            }
            if (publicRequest.IsSetCommitMessage())
            {
                context.Writer.WritePropertyName("commitMessage");
                context.Writer.WriteStringValue(publicRequest.CommitMessage);
            }
            if (publicRequest.IsSetConflictDetailLevel())
            {
                context.Writer.WritePropertyName("conflictDetailLevel");
                context.Writer.WriteStringValue(publicRequest.ConflictDetailLevel);
            }
            if (publicRequest.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("conflictResolution");
                context.Writer.WriteStartObject();

                var marshaller = ConflictResolutionMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConflictResolution, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetConflictResolutionStrategy())
            {
                context.Writer.WritePropertyName("conflictResolutionStrategy");
                context.Writer.WriteStringValue(publicRequest.ConflictResolutionStrategy);
            }
            if (publicRequest.IsSetDestinationCommitSpecifier())
            {
                context.Writer.WritePropertyName("destinationCommitSpecifier");
                context.Writer.WriteStringValue(publicRequest.DestinationCommitSpecifier);
            }
            if (publicRequest.IsSetEmail())
            {
                context.Writer.WritePropertyName("email");
                context.Writer.WriteStringValue(publicRequest.Email);
            }
            if (publicRequest.IsSetKeepEmptyFolders())
            {
                context.Writer.WritePropertyName("keepEmptyFolders");
                context.Writer.WriteBooleanValue(publicRequest.KeepEmptyFolders.Value);
            }
            if (publicRequest.IsSetMergeOption())
            {
                context.Writer.WritePropertyName("mergeOption");
                context.Writer.WriteStringValue(publicRequest.MergeOption);
            }
            if (publicRequest.IsSetRepositoryName())
            {
                context.Writer.WritePropertyName("repositoryName");
                context.Writer.WriteStringValue(publicRequest.RepositoryName);
            }
            if (publicRequest.IsSetSourceCommitSpecifier())
            {
                context.Writer.WritePropertyName("sourceCommitSpecifier");
                context.Writer.WriteStringValue(publicRequest.SourceCommitSpecifier);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateUnreferencedMergeCommitRequestMarshaller _instance = new();

        internal static CreateUnreferencedMergeCommitRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateUnreferencedMergeCommitRequestMarshaller Instance => _instance;
    }
}
