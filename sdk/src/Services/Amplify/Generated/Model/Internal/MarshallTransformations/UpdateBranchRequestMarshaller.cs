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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
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
namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBranch Request Marshaller
    /// </summary>       
    public class UpdateBranchRequestMarshaller : IMarshaller<IRequest, UpdateBranchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBranchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBranchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetBranchName())
                throw new AmazonAmplifyException("Request object does not have required field BranchName set");
            request.AddPathResource("{branchName}", StringUtils.FromString(publicRequest.BranchName));
            request.ResourcePath = "/apps/{appId}/branches/{branchName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBackend())
            {
                context.Writer.WritePropertyName("backend");
                context.Writer.WriteStartObject();

                var marshaller = BackendMarshaller.Instance;
                marshaller.Marshall(publicRequest.Backend, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBackendEnvironmentArn())
            {
                context.Writer.WritePropertyName("backendEnvironmentArn");
                context.Writer.WriteStringValue(publicRequest.BackendEnvironmentArn);
            }

            if(publicRequest.IsSetBasicAuthCredentials())
            {
                context.Writer.WritePropertyName("basicAuthCredentials");
                context.Writer.WriteStringValue(publicRequest.BasicAuthCredentials);
            }

            if(publicRequest.IsSetBuildSpec())
            {
                context.Writer.WritePropertyName("buildSpec");
                context.Writer.WriteStringValue(publicRequest.BuildSpec);
            }

            if(publicRequest.IsSetComputeRoleArn())
            {
                context.Writer.WritePropertyName("computeRoleArn");
                context.Writer.WriteStringValue(publicRequest.ComputeRoleArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetEnableAutoBuild())
            {
                context.Writer.WritePropertyName("enableAutoBuild");
                context.Writer.WriteBooleanValue(publicRequest.EnableAutoBuild.Value);
            }

            if(publicRequest.IsSetEnableBasicAuth())
            {
                context.Writer.WritePropertyName("enableBasicAuth");
                context.Writer.WriteBooleanValue(publicRequest.EnableBasicAuth.Value);
            }

            if(publicRequest.IsSetEnableNotification())
            {
                context.Writer.WritePropertyName("enableNotification");
                context.Writer.WriteBooleanValue(publicRequest.EnableNotification.Value);
            }

            if(publicRequest.IsSetEnablePerformanceMode())
            {
                context.Writer.WritePropertyName("enablePerformanceMode");
                context.Writer.WriteBooleanValue(publicRequest.EnablePerformanceMode.Value);
            }

            if(publicRequest.IsSetEnablePullRequestPreview())
            {
                context.Writer.WritePropertyName("enablePullRequestPreview");
                context.Writer.WriteBooleanValue(publicRequest.EnablePullRequestPreview.Value);
            }

            if(publicRequest.IsSetEnableSkewProtection())
            {
                context.Writer.WritePropertyName("enableSkewProtection");
                context.Writer.WriteBooleanValue(publicRequest.EnableSkewProtection.Value);
            }

            if(publicRequest.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                    var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFramework())
            {
                context.Writer.WritePropertyName("framework");
                context.Writer.WriteStringValue(publicRequest.Framework);
            }

            if(publicRequest.IsSetPullRequestEnvironmentName())
            {
                context.Writer.WritePropertyName("pullRequestEnvironmentName");
                context.Writer.WriteStringValue(publicRequest.PullRequestEnvironmentName);
            }

            if(publicRequest.IsSetStage())
            {
                context.Writer.WritePropertyName("stage");
                context.Writer.WriteStringValue(publicRequest.Stage);
            }

            if(publicRequest.IsSetTtl())
            {
                context.Writer.WritePropertyName("ttl");
                context.Writer.WriteStringValue(publicRequest.Ttl);
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
        private static UpdateBranchRequestMarshaller _instance = new UpdateBranchRequestMarshaller();        

        internal static UpdateBranchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBranchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}