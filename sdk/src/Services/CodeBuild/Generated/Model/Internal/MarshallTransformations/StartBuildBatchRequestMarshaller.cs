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
    /// StartBuildBatch Request Marshaller
    /// </summary>       
    public class StartBuildBatchRequestMarshaller : IMarshaller<IRequest, StartBuildBatchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBuildBatchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartBuildBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.StartBuildBatch";
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
            if(publicRequest.IsSetArtifactsOverride())
            {
                context.Writer.WritePropertyName("artifactsOverride");
                context.Writer.WriteStartObject();

                var marshaller = ProjectArtifactsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ArtifactsOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBuildBatchConfigOverride())
            {
                context.Writer.WritePropertyName("buildBatchConfigOverride");
                context.Writer.WriteStartObject();

                var marshaller = ProjectBuildBatchConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.BuildBatchConfigOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBuildspecOverride())
            {
                context.Writer.WritePropertyName("buildspecOverride");
                context.Writer.WriteStringValue(publicRequest.BuildspecOverride);
            }

            if(publicRequest.IsSetBuildTimeoutInMinutesOverride())
            {
                context.Writer.WritePropertyName("buildTimeoutInMinutesOverride");
                context.Writer.WriteNumberValue(publicRequest.BuildTimeoutInMinutesOverride.Value);
            }

            if(publicRequest.IsSetCacheOverride())
            {
                context.Writer.WritePropertyName("cacheOverride");
                context.Writer.WriteStartObject();

                var marshaller = ProjectCacheMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCertificateOverride())
            {
                context.Writer.WritePropertyName("certificateOverride");
                context.Writer.WriteStringValue(publicRequest.CertificateOverride);
            }

            if(publicRequest.IsSetComputeTypeOverride())
            {
                context.Writer.WritePropertyName("computeTypeOverride");
                context.Writer.WriteStringValue(publicRequest.ComputeTypeOverride);
            }

            if(publicRequest.IsSetDebugSessionEnabled())
            {
                context.Writer.WritePropertyName("debugSessionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DebugSessionEnabled.Value);
            }

            if(publicRequest.IsSetEncryptionKeyOverride())
            {
                context.Writer.WritePropertyName("encryptionKeyOverride");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyOverride);
            }

            if(publicRequest.IsSetEnvironmentTypeOverride())
            {
                context.Writer.WritePropertyName("environmentTypeOverride");
                context.Writer.WriteStringValue(publicRequest.EnvironmentTypeOverride);
            }

            if(publicRequest.IsSetEnvironmentVariablesOverride())
            {
                context.Writer.WritePropertyName("environmentVariablesOverride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnvironmentVariablesOverrideListValue in publicRequest.EnvironmentVariablesOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(publicRequestEnvironmentVariablesOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGitCloneDepthOverride())
            {
                context.Writer.WritePropertyName("gitCloneDepthOverride");
                context.Writer.WriteNumberValue(publicRequest.GitCloneDepthOverride.Value);
            }

            if(publicRequest.IsSetGitSubmodulesConfigOverride())
            {
                context.Writer.WritePropertyName("gitSubmodulesConfigOverride");
                context.Writer.WriteStartObject();

                var marshaller = GitSubmodulesConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.GitSubmodulesConfigOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdempotencyToken())
            {
                context.Writer.WritePropertyName("idempotencyToken");
                context.Writer.WriteStringValue(publicRequest.IdempotencyToken);
            }

            if(publicRequest.IsSetImageOverride())
            {
                context.Writer.WritePropertyName("imageOverride");
                context.Writer.WriteStringValue(publicRequest.ImageOverride);
            }

            if(publicRequest.IsSetImagePullCredentialsTypeOverride())
            {
                context.Writer.WritePropertyName("imagePullCredentialsTypeOverride");
                context.Writer.WriteStringValue(publicRequest.ImagePullCredentialsTypeOverride);
            }

            if(publicRequest.IsSetInsecureSslOverride())
            {
                context.Writer.WritePropertyName("insecureSslOverride");
                context.Writer.WriteBooleanValue(publicRequest.InsecureSslOverride.Value);
            }

            if(publicRequest.IsSetLogsConfigOverride())
            {
                context.Writer.WritePropertyName("logsConfigOverride");
                context.Writer.WriteStartObject();

                var marshaller = LogsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogsConfigOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPrivilegedModeOverride())
            {
                context.Writer.WritePropertyName("privilegedModeOverride");
                context.Writer.WriteBooleanValue(publicRequest.PrivilegedModeOverride.Value);
            }

            if(publicRequest.IsSetProjectName())
            {
                context.Writer.WritePropertyName("projectName");
                context.Writer.WriteStringValue(publicRequest.ProjectName);
            }

            if(publicRequest.IsSetQueuedTimeoutInMinutesOverride())
            {
                context.Writer.WritePropertyName("queuedTimeoutInMinutesOverride");
                context.Writer.WriteNumberValue(publicRequest.QueuedTimeoutInMinutesOverride.Value);
            }

            if(publicRequest.IsSetRegistryCredentialOverride())
            {
                context.Writer.WritePropertyName("registryCredentialOverride");
                context.Writer.WriteStartObject();

                var marshaller = RegistryCredentialMarshaller.Instance;
                marshaller.Marshall(publicRequest.RegistryCredentialOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReportBuildBatchStatusOverride())
            {
                context.Writer.WritePropertyName("reportBuildBatchStatusOverride");
                context.Writer.WriteBooleanValue(publicRequest.ReportBuildBatchStatusOverride.Value);
            }

            if(publicRequest.IsSetSecondaryArtifactsOverride())
            {
                context.Writer.WritePropertyName("secondaryArtifactsOverride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondaryArtifactsOverrideListValue in publicRequest.SecondaryArtifactsOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectArtifactsMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondaryArtifactsOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSecondarySourcesOverride())
            {
                context.Writer.WritePropertyName("secondarySourcesOverride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondarySourcesOverrideListValue in publicRequest.SecondarySourcesOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondarySourcesOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSecondarySourcesVersionOverride())
            {
                context.Writer.WritePropertyName("secondarySourcesVersionOverride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecondarySourcesVersionOverrideListValue in publicRequest.SecondarySourcesVersionOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProjectSourceVersionMarshaller.Instance;
                    marshaller.Marshall(publicRequestSecondarySourcesVersionOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceRoleOverride())
            {
                context.Writer.WritePropertyName("serviceRoleOverride");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleOverride);
            }

            if(publicRequest.IsSetSourceAuthOverride())
            {
                context.Writer.WritePropertyName("sourceAuthOverride");
                context.Writer.WriteStartObject();

                var marshaller = SourceAuthMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceAuthOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceLocationOverride())
            {
                context.Writer.WritePropertyName("sourceLocationOverride");
                context.Writer.WriteStringValue(publicRequest.SourceLocationOverride);
            }

            if(publicRequest.IsSetSourceTypeOverride())
            {
                context.Writer.WritePropertyName("sourceTypeOverride");
                context.Writer.WriteStringValue(publicRequest.SourceTypeOverride);
            }

            if(publicRequest.IsSetSourceVersion())
            {
                context.Writer.WritePropertyName("sourceVersion");
                context.Writer.WriteStringValue(publicRequest.SourceVersion);
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
        private static StartBuildBatchRequestMarshaller _instance = new StartBuildBatchRequestMarshaller();        

        internal static StartBuildBatchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartBuildBatchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}