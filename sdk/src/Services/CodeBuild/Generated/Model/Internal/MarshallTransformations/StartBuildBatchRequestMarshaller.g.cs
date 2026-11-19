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
    /// StartBuildBatch Request Marshaller
    /// </summary>
    public partial class StartBuildBatchRequestMarshaller : IMarshaller<IRequest, StartBuildBatchRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBuildBatchRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartBuildBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/CodeBuild_20161006/operation/StartBuildBatch";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetArtifactsOverride())
                {
                    context.Writer.WriteTextString("artifactsOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectArtifactsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ArtifactsOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBuildBatchConfigOverride())
                {
                    context.Writer.WriteTextString("buildBatchConfigOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectBuildBatchConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BuildBatchConfigOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBuildTimeoutInMinutesOverride())
                {
                    context.Writer.WriteTextString("buildTimeoutInMinutesOverride");
                    context.Writer.WriteInt32(publicRequest.BuildTimeoutInMinutesOverride.Value);
                }
                if (publicRequest.IsSetBuildspecOverride())
                {
                    context.Writer.WriteTextString("buildspecOverride");
                    context.Writer.WriteTextString(publicRequest.BuildspecOverride);
                }
                if (publicRequest.IsSetCacheOverride())
                {
                    context.Writer.WriteTextString("cacheOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProjectCacheMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CacheOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCertificateOverride())
                {
                    context.Writer.WriteTextString("certificateOverride");
                    context.Writer.WriteTextString(publicRequest.CertificateOverride);
                }
                if (publicRequest.IsSetComputeTypeOverride())
                {
                    context.Writer.WriteTextString("computeTypeOverride");
                    context.Writer.WriteTextString(publicRequest.ComputeTypeOverride);
                }
                if (publicRequest.IsSetDebugSessionEnabled())
                {
                    context.Writer.WriteTextString("debugSessionEnabled");
                    context.Writer.WriteBoolean(publicRequest.DebugSessionEnabled.Value);
                }
                if (publicRequest.IsSetEncryptionKeyOverride())
                {
                    context.Writer.WriteTextString("encryptionKeyOverride");
                    context.Writer.WriteTextString(publicRequest.EncryptionKeyOverride);
                }
                if (publicRequest.IsSetEnvironmentTypeOverride())
                {
                    context.Writer.WriteTextString("environmentTypeOverride");
                    context.Writer.WriteTextString(publicRequest.EnvironmentTypeOverride);
                }
                if (publicRequest.IsSetEnvironmentVariablesOverride())
                {
                    context.Writer.WriteTextString("environmentVariablesOverride");
                    context.Writer.WriteStartArray(publicRequest.EnvironmentVariablesOverride.Count);
                    foreach (var publicRequestEnvironmentVariablesOverrideListValue in publicRequest.EnvironmentVariablesOverride)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = EnvironmentVariableMarshaller.Instance;
                        marshaller.Marshall(publicRequestEnvironmentVariablesOverrideListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetGitCloneDepthOverride())
                {
                    context.Writer.WriteTextString("gitCloneDepthOverride");
                    context.Writer.WriteInt32(publicRequest.GitCloneDepthOverride.Value);
                }
                if (publicRequest.IsSetGitSubmodulesConfigOverride())
                {
                    context.Writer.WriteTextString("gitSubmodulesConfigOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = GitSubmodulesConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GitSubmodulesConfigOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WriteTextString("idempotencyToken");
                    context.Writer.WriteTextString(publicRequest.IdempotencyToken);
                }
                if (publicRequest.IsSetImageOverride())
                {
                    context.Writer.WriteTextString("imageOverride");
                    context.Writer.WriteTextString(publicRequest.ImageOverride);
                }
                if (publicRequest.IsSetImagePullCredentialsTypeOverride())
                {
                    context.Writer.WriteTextString("imagePullCredentialsTypeOverride");
                    context.Writer.WriteTextString(publicRequest.ImagePullCredentialsTypeOverride);
                }
                if (publicRequest.IsSetInsecureSslOverride())
                {
                    context.Writer.WriteTextString("insecureSslOverride");
                    context.Writer.WriteBoolean(publicRequest.InsecureSslOverride.Value);
                }
                if (publicRequest.IsSetLogsConfigOverride())
                {
                    context.Writer.WriteTextString("logsConfigOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LogsConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogsConfigOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPrivilegedModeOverride())
                {
                    context.Writer.WriteTextString("privilegedModeOverride");
                    context.Writer.WriteBoolean(publicRequest.PrivilegedModeOverride.Value);
                }
                if (publicRequest.IsSetProjectName())
                {
                    context.Writer.WriteTextString("projectName");
                    context.Writer.WriteTextString(publicRequest.ProjectName);
                }
                if (publicRequest.IsSetQueuedTimeoutInMinutesOverride())
                {
                    context.Writer.WriteTextString("queuedTimeoutInMinutesOverride");
                    context.Writer.WriteInt32(publicRequest.QueuedTimeoutInMinutesOverride.Value);
                }
                if (publicRequest.IsSetRegistryCredentialOverride())
                {
                    context.Writer.WriteTextString("registryCredentialOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RegistryCredentialMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RegistryCredentialOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetReportBuildBatchStatusOverride())
                {
                    context.Writer.WriteTextString("reportBuildBatchStatusOverride");
                    context.Writer.WriteBoolean(publicRequest.ReportBuildBatchStatusOverride.Value);
                }
                if (publicRequest.IsSetSecondaryArtifactsOverride())
                {
                    context.Writer.WriteTextString("secondaryArtifactsOverride");
                    context.Writer.WriteStartArray(publicRequest.SecondaryArtifactsOverride.Count);
                    foreach (var publicRequestSecondaryArtifactsOverrideListValue in publicRequest.SecondaryArtifactsOverride)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectArtifactsMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondaryArtifactsOverrideListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSecondarySourcesOverride())
                {
                    context.Writer.WriteTextString("secondarySourcesOverride");
                    context.Writer.WriteStartArray(publicRequest.SecondarySourcesOverride.Count);
                    foreach (var publicRequestSecondarySourcesOverrideListValue in publicRequest.SecondarySourcesOverride)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondarySourcesOverrideListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSecondarySourcesVersionOverride())
                {
                    context.Writer.WriteTextString("secondarySourcesVersionOverride");
                    context.Writer.WriteStartArray(publicRequest.SecondarySourcesVersionOverride.Count);
                    foreach (var publicRequestSecondarySourcesVersionOverrideListValue in publicRequest.SecondarySourcesVersionOverride)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ProjectSourceVersionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSecondarySourcesVersionOverrideListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetServiceRoleOverride())
                {
                    context.Writer.WriteTextString("serviceRoleOverride");
                    context.Writer.WriteTextString(publicRequest.ServiceRoleOverride);
                }
                if (publicRequest.IsSetSourceAuthOverride())
                {
                    context.Writer.WriteTextString("sourceAuthOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SourceAuthMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceAuthOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSourceLocationOverride())
                {
                    context.Writer.WriteTextString("sourceLocationOverride");
                    context.Writer.WriteTextString(publicRequest.SourceLocationOverride);
                }
                if (publicRequest.IsSetSourceTypeOverride())
                {
                    context.Writer.WriteTextString("sourceTypeOverride");
                    context.Writer.WriteTextString(publicRequest.SourceTypeOverride);
                }
                if (publicRequest.IsSetSourceVersion())
                {
                    context.Writer.WriteTextString("sourceVersion");
                    context.Writer.WriteTextString(publicRequest.SourceVersion);
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

        private static readonly StartBuildBatchRequestMarshaller _instance = new();

        internal static StartBuildBatchRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartBuildBatchRequestMarshaller Instance => _instance;
    }
}
