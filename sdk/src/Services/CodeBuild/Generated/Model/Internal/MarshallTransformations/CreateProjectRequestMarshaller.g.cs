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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProject Request Marshaller
    /// </summary>
    public partial class CreateProjectRequestMarshaller : IMarshaller<IRequest, CreateProjectRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProjectRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeBuild_20161006/operation/CreateProject";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetArtifacts())
                {
                    context.Writer.WriteTextString("artifacts");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectArtifactsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Artifacts, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetAutoRetryLimit())
                {
                    context.Writer.WriteTextString("autoRetryLimit");
                    context.Writer.WriteInt32(publicRequest.AutoRetryLimit.Value);
                }
                if (publicRequest.IsSetBadgeEnabled())
                {
                    context.Writer.WriteTextString("badgeEnabled");
                    context.Writer.WriteBoolean(publicRequest.BadgeEnabled.Value);
                }
                if (publicRequest.IsSetBuildBatchConfig())
                {
                    context.Writer.WriteTextString("buildBatchConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectBuildBatchConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BuildBatchConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCache())
                {
                    context.Writer.WriteTextString("cache");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectCacheMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Cache, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetConcurrentBuildLimit())
                {
                    context.Writer.WriteTextString("concurrentBuildLimit");
                    context.Writer.WriteInt32(publicRequest.ConcurrentBuildLimit.Value);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEncryptionKey())
                {
                    context.Writer.WriteTextString("encryptionKey");
                    context.Writer.WriteTextString(publicRequest.EncryptionKey);
                }
                if (publicRequest.IsSetEnvironment())
                {
                    context.Writer.WriteTextString("environment");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectEnvironmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Environment, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFileSystemLocations())
                {
                    context.Writer.WriteTextString("fileSystemLocations");
                    context.Writer.WriteStartArray(publicRequest.FileSystemLocations.Count);
                    foreach (var publicRequestFileSystemLocationsListValue in publicRequest.FileSystemLocations)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectFileSystemLocationMarshaller.Instance;
                        marshaller.Marshall(publicRequestFileSystemLocationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLogsConfig())
                {
                    context.Writer.WriteTextString("logsConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LogsConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogsConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetQueuedTimeoutInMinutes())
                {
                    context.Writer.WriteTextString("queuedTimeoutInMinutes");
                    context.Writer.WriteInt32(publicRequest.QueuedTimeoutInMinutes.Value);
                }
                if (publicRequest.IsSetSecondaryArtifacts())
                {
                    context.Writer.WriteTextString("secondaryArtifacts");
                    context.Writer.WriteStartArray(publicRequest.SecondaryArtifacts.Count);
                    foreach (var publicRequestSecondaryArtifactsListValue in publicRequest.SecondaryArtifacts)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectArtifactsMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondaryArtifactsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSecondarySourceVersions())
                {
                    context.Writer.WriteTextString("secondarySourceVersions");
                    context.Writer.WriteStartArray(publicRequest.SecondarySourceVersions.Count);
                    foreach (var publicRequestSecondarySourceVersionsListValue in publicRequest.SecondarySourceVersions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectSourceVersionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondarySourceVersionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSecondarySources())
                {
                    context.Writer.WriteTextString("secondarySources");
                    context.Writer.WriteStartArray(publicRequest.SecondarySources.Count);
                    foreach (var publicRequestSecondarySourcesListValue in publicRequest.SecondarySources)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondarySourcesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetServiceRole())
                {
                    context.Writer.WriteTextString("serviceRole");
                    context.Writer.WriteTextString(publicRequest.ServiceRole);
                }
                if (publicRequest.IsSetSource())
                {
                    context.Writer.WriteTextString("source");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Source, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSourceVersion())
                {
                    context.Writer.WriteTextString("sourceVersion");
                    context.Writer.WriteTextString(publicRequest.SourceVersion);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTimeoutInMinutes())
                {
                    context.Writer.WriteTextString("timeoutInMinutes");
                    context.Writer.WriteInt32(publicRequest.TimeoutInMinutes.Value);
                }
                if (publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WriteTextString("vpcConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateProjectRequestMarshaller _instance = new();

        internal static CreateProjectRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProjectRequestMarshaller Instance => _instance;
    }
}
