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
    /// UpdateApp Request Marshaller
    /// </summary>       
    public class UpdateAppRequestMarshaller : IMarshaller<IRequest, UpdateAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            request.ResourcePath = "/apps/{appId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessToken())
            {
                context.Writer.WritePropertyName("accessToken");
                context.Writer.WriteStringValue(publicRequest.AccessToken);
            }

            if(publicRequest.IsSetAutoBranchCreationConfig())
            {
                context.Writer.WritePropertyName("autoBranchCreationConfig");
                context.Writer.WriteStartObject();

                var marshaller = AutoBranchCreationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoBranchCreationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoBranchCreationPatterns())
            {
                context.Writer.WritePropertyName("autoBranchCreationPatterns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAutoBranchCreationPatternsListValue in publicRequest.AutoBranchCreationPatterns)
                {
                        context.Writer.WriteStringValue(publicRequestAutoBranchCreationPatternsListValue);
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetCacheConfig())
            {
                context.Writer.WritePropertyName("cacheConfig");
                context.Writer.WriteStartObject();

                var marshaller = CacheConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComputeRoleArn())
            {
                context.Writer.WritePropertyName("computeRoleArn");
                context.Writer.WriteStringValue(publicRequest.ComputeRoleArn);
            }

            if(publicRequest.IsSetCustomHeaders())
            {
                context.Writer.WritePropertyName("customHeaders");
                context.Writer.WriteStringValue(publicRequest.CustomHeaders);
            }

            if(publicRequest.IsSetCustomRules())
            {
                context.Writer.WritePropertyName("customRules");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomRulesListValue in publicRequest.CustomRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnableAutoBranchCreation())
            {
                context.Writer.WritePropertyName("enableAutoBranchCreation");
                context.Writer.WriteBooleanValue(publicRequest.EnableAutoBranchCreation.Value);
            }

            if(publicRequest.IsSetEnableBasicAuth())
            {
                context.Writer.WritePropertyName("enableBasicAuth");
                context.Writer.WriteBooleanValue(publicRequest.EnableBasicAuth.Value);
            }

            if(publicRequest.IsSetEnableBranchAutoBuild())
            {
                context.Writer.WritePropertyName("enableBranchAutoBuild");
                context.Writer.WriteBooleanValue(publicRequest.EnableBranchAutoBuild.Value);
            }

            if(publicRequest.IsSetEnableBranchAutoDeletion())
            {
                context.Writer.WritePropertyName("enableBranchAutoDeletion");
                context.Writer.WriteBooleanValue(publicRequest.EnableBranchAutoDeletion.Value);
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

            if(publicRequest.IsSetIamServiceRoleArn())
            {
                context.Writer.WritePropertyName("iamServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamServiceRoleArn);
            }

            if(publicRequest.IsSetJobConfig())
            {
                context.Writer.WritePropertyName("jobConfig");
                context.Writer.WriteStartObject();

                var marshaller = JobConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOauthToken())
            {
                context.Writer.WritePropertyName("oauthToken");
                context.Writer.WriteStringValue(publicRequest.OauthToken);
            }

            if(publicRequest.IsSetPlatform())
            {
                context.Writer.WritePropertyName("platform");
                context.Writer.WriteStringValue(publicRequest.Platform);
            }

            if(publicRequest.IsSetRepository())
            {
                context.Writer.WritePropertyName("repository");
                context.Writer.WriteStringValue(publicRequest.Repository);
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
        private static UpdateAppRequestMarshaller _instance = new UpdateAppRequestMarshaller();        

        internal static UpdateAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}