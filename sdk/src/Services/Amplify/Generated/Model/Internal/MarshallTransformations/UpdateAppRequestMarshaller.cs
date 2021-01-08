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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessToken())
                {
                    context.Writer.WritePropertyName("accessToken");
                    context.Writer.Write(publicRequest.AccessToken);
                }

                if(publicRequest.IsSetAutoBranchCreationConfig())
                {
                    context.Writer.WritePropertyName("autoBranchCreationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoBranchCreationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoBranchCreationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoBranchCreationPatterns())
                {
                    context.Writer.WritePropertyName("autoBranchCreationPatterns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoBranchCreationPatternsListValue in publicRequest.AutoBranchCreationPatterns)
                    {
                            context.Writer.Write(publicRequestAutoBranchCreationPatternsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBasicAuthCredentials())
                {
                    context.Writer.WritePropertyName("basicAuthCredentials");
                    context.Writer.Write(publicRequest.BasicAuthCredentials);
                }

                if(publicRequest.IsSetBuildSpec())
                {
                    context.Writer.WritePropertyName("buildSpec");
                    context.Writer.Write(publicRequest.BuildSpec);
                }

                if(publicRequest.IsSetCustomHeaders())
                {
                    context.Writer.WritePropertyName("customHeaders");
                    context.Writer.Write(publicRequest.CustomHeaders);
                }

                if(publicRequest.IsSetCustomRules())
                {
                    context.Writer.WritePropertyName("customRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomRulesListValue in publicRequest.CustomRules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CustomRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestCustomRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnableAutoBranchCreation())
                {
                    context.Writer.WritePropertyName("enableAutoBranchCreation");
                    context.Writer.Write(publicRequest.EnableAutoBranchCreation);
                }

                if(publicRequest.IsSetEnableBasicAuth())
                {
                    context.Writer.WritePropertyName("enableBasicAuth");
                    context.Writer.Write(publicRequest.EnableBasicAuth);
                }

                if(publicRequest.IsSetEnableBranchAutoBuild())
                {
                    context.Writer.WritePropertyName("enableBranchAutoBuild");
                    context.Writer.Write(publicRequest.EnableBranchAutoBuild);
                }

                if(publicRequest.IsSetEnableBranchAutoDeletion())
                {
                    context.Writer.WritePropertyName("enableBranchAutoDeletion");
                    context.Writer.Write(publicRequest.EnableBranchAutoDeletion);
                }

                if(publicRequest.IsSetEnvironmentVariables())
                {
                    context.Writer.WritePropertyName("environmentVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                        var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                            context.Writer.Write(publicRequestEnvironmentVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIamServiceRoleArn())
                {
                    context.Writer.WritePropertyName("iamServiceRoleArn");
                    context.Writer.Write(publicRequest.IamServiceRoleArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOauthToken())
                {
                    context.Writer.WritePropertyName("oauthToken");
                    context.Writer.Write(publicRequest.OauthToken);
                }

                if(publicRequest.IsSetPlatform())
                {
                    context.Writer.WritePropertyName("platform");
                    context.Writer.Write(publicRequest.Platform);
                }

                if(publicRequest.IsSetRepository())
                {
                    context.Writer.WritePropertyName("repository");
                    context.Writer.Write(publicRequest.Repository);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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