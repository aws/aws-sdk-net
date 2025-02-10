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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProject Request Marshaller
    /// </summary>       
    public class UpdateProjectRequestMarshaller : IMarshaller<IRequest, UpdateProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.UpdateProject";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArtifacts())
            {
                context.Writer.WritePropertyName("artifacts");
                context.Writer.WriteStartObject();

                var marshaller = ProjectArtifactsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Artifacts, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoRetryLimit())
            {
                context.Writer.WritePropertyName("autoRetryLimit");
                context.Writer.WriteNumberValue(publicRequest.AutoRetryLimit.Value);
            }

            if(publicRequest.IsSetBadgeEnabled())
            {
                context.Writer.WritePropertyName("badgeEnabled");
                context.Writer.WriteBooleanValue(publicRequest.BadgeEnabled.Value);
            }

            if(publicRequest.IsSetBuildBatchConfig())
            {
                context.Writer.WritePropertyName("buildBatchConfig");
                context.Writer.WriteStartObject();

                var marshaller = ProjectBuildBatchConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.BuildBatchConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCache())
            {
                context.Writer.WritePropertyName("cache");
                context.Writer.WriteStartObject();

                var marshaller = ProjectCacheMarshaller.Instance;
                marshaller.Marshall(publicRequest.Cache, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConcurrentBuildLimit())
            {
                context.Writer.WritePropertyName("concurrentBuildLimit");
                context.Writer.WriteNumberValue(publicRequest.ConcurrentBuildLimit.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEncryptionKey())
            {
                context.Writer.WritePropertyName("encryptionKey");
                context.Writer.WriteStringValue(publicRequest.EncryptionKey);
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteStartObject();

                var marshaller = ProjectEnvironmentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFileSystemLocations())
            {
                context.Writer.WritePropertyName("fileSystemLocations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFileSystemLocationsListValue in publicRequest.FileSystemLocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectFileSystemLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequestFileSystemLocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLogsConfig())
            {
                context.Writer.WritePropertyName("logsConfig");
                context.Writer.WriteStartObject();

                var marshaller = LogsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQueuedTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("queuedTimeoutInMinutes");
                context.Writer.WriteNumberValue(publicRequest.QueuedTimeoutInMinutes.Value);
            }

            if(publicRequest.IsSetSecondaryArtifacts())
            {
                context.Writer.WritePropertyName("secondaryArtifacts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondaryArtifactsListValue in publicRequest.SecondaryArtifacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectArtifactsMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondaryArtifactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSecondarySources())
            {
                context.Writer.WritePropertyName("secondarySources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondarySourcesListValue in publicRequest.SecondarySources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondarySourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSecondarySourceVersions())
            {
                context.Writer.WritePropertyName("secondarySourceVersions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondarySourceVersionsListValue in publicRequest.SecondarySourceVersions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectSourceVersionMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondarySourceVersionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("serviceRole");
                context.Writer.WriteStringValue(publicRequest.ServiceRole);
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = ProjectSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceVersion())
            {
                context.Writer.WritePropertyName("sourceVersion");
                context.Writer.WriteStringValue(publicRequest.SourceVersion);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("timeoutInMinutes");
                context.Writer.WriteNumberValue(publicRequest.TimeoutInMinutes.Value);
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("vpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateProjectRequestMarshaller _instance = new UpdateProjectRequestMarshaller();        

        internal static UpdateProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}