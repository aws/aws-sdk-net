/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartBuild Request Marshaller
    /// </summary>       
    public class StartBuildRequestMarshaller : IMarshaller<IRequest, StartBuildRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBuildRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartBuildRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.StartBuild";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArtifactsOverride())
                {
                    context.Writer.WritePropertyName("artifactsOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProjectArtifactsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ArtifactsOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBuildspecOverride())
                {
                    context.Writer.WritePropertyName("buildspecOverride");
                    context.Writer.Write(publicRequest.BuildspecOverride);
                }

                if(publicRequest.IsSetCacheOverride())
                {
                    context.Writer.WritePropertyName("cacheOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProjectCacheMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CacheOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCertificateOverride())
                {
                    context.Writer.WritePropertyName("certificateOverride");
                    context.Writer.Write(publicRequest.CertificateOverride);
                }

                if(publicRequest.IsSetComputeTypeOverride())
                {
                    context.Writer.WritePropertyName("computeTypeOverride");
                    context.Writer.Write(publicRequest.ComputeTypeOverride);
                }

                if(publicRequest.IsSetEnvironmentTypeOverride())
                {
                    context.Writer.WritePropertyName("environmentTypeOverride");
                    context.Writer.Write(publicRequest.EnvironmentTypeOverride);
                }

                if(publicRequest.IsSetEnvironmentVariablesOverride())
                {
                    context.Writer.WritePropertyName("environmentVariablesOverride");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnvironmentVariablesOverrideListValue in publicRequest.EnvironmentVariablesOverride)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EnvironmentVariableMarshaller.Instance;
                        marshaller.Marshall(publicRequestEnvironmentVariablesOverrideListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGitCloneDepthOverride())
                {
                    context.Writer.WritePropertyName("gitCloneDepthOverride");
                    context.Writer.Write(publicRequest.GitCloneDepthOverride);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("idempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                if(publicRequest.IsSetImageOverride())
                {
                    context.Writer.WritePropertyName("imageOverride");
                    context.Writer.Write(publicRequest.ImageOverride);
                }

                if(publicRequest.IsSetInsecureSslOverride())
                {
                    context.Writer.WritePropertyName("insecureSslOverride");
                    context.Writer.Write(publicRequest.InsecureSslOverride);
                }

                if(publicRequest.IsSetPrivilegedModeOverride())
                {
                    context.Writer.WritePropertyName("privilegedModeOverride");
                    context.Writer.Write(publicRequest.PrivilegedModeOverride);
                }

                if(publicRequest.IsSetProjectName())
                {
                    context.Writer.WritePropertyName("projectName");
                    context.Writer.Write(publicRequest.ProjectName);
                }

                if(publicRequest.IsSetServiceRoleOverride())
                {
                    context.Writer.WritePropertyName("serviceRoleOverride");
                    context.Writer.Write(publicRequest.ServiceRoleOverride);
                }

                if(publicRequest.IsSetSourceAuthOverride())
                {
                    context.Writer.WritePropertyName("sourceAuthOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceAuthMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceAuthOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceLocationOverride())
                {
                    context.Writer.WritePropertyName("sourceLocationOverride");
                    context.Writer.Write(publicRequest.SourceLocationOverride);
                }

                if(publicRequest.IsSetSourceTypeOverride())
                {
                    context.Writer.WritePropertyName("sourceTypeOverride");
                    context.Writer.Write(publicRequest.SourceTypeOverride);
                }

                if(publicRequest.IsSetSourceVersion())
                {
                    context.Writer.WritePropertyName("sourceVersion");
                    context.Writer.Write(publicRequest.SourceVersion);
                }

                if(publicRequest.IsSetTimeoutInMinutesOverride())
                {
                    context.Writer.WritePropertyName("timeoutInMinutesOverride");
                    context.Writer.Write(publicRequest.TimeoutInMinutesOverride);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartBuildRequestMarshaller _instance = new StartBuildRequestMarshaller();        

        internal static StartBuildRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartBuildRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}