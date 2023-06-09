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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGraphqlApi Request Marshaller
    /// </summary>       
    public class CreateGraphqlApiRequestMarshaller : IMarshaller<IRequest, CreateGraphqlApiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGraphqlApiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGraphqlApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/apis";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalAuthenticationProviders())
                {
                    context.Writer.WritePropertyName("additionalAuthenticationProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalAuthenticationProvidersListValue in publicRequest.AdditionalAuthenticationProviders)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AdditionalAuthenticationProviderMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdditionalAuthenticationProvidersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApiType())
                {
                    context.Writer.WritePropertyName("apiType");
                    context.Writer.Write(publicRequest.ApiType);
                }

                if(publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WritePropertyName("authenticationType");
                    context.Writer.Write(publicRequest.AuthenticationType);
                }

                if(publicRequest.IsSetLambdaAuthorizerConfig())
                {
                    context.Writer.WritePropertyName("lambdaAuthorizerConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LambdaAuthorizerConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LambdaAuthorizerConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogConfig())
                {
                    context.Writer.WritePropertyName("logConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMergedApiExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("mergedApiExecutionRoleArn");
                    context.Writer.Write(publicRequest.MergedApiExecutionRoleArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOpenIDConnectConfig())
                {
                    context.Writer.WritePropertyName("openIDConnectConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OpenIDConnectConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OpenIDConnectConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOwnerContact())
                {
                    context.Writer.WritePropertyName("ownerContact");
                    context.Writer.Write(publicRequest.OwnerContact);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUserPoolConfig())
                {
                    context.Writer.WritePropertyName("userPoolConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserPoolConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserPoolConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVisibility())
                {
                    context.Writer.WritePropertyName("visibility");
                    context.Writer.Write(publicRequest.Visibility);
                }

                if(publicRequest.IsSetXrayEnabled())
                {
                    context.Writer.WritePropertyName("xrayEnabled");
                    context.Writer.Write(publicRequest.XrayEnabled);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGraphqlApiRequestMarshaller _instance = new CreateGraphqlApiRequestMarshaller();        

        internal static CreateGraphqlApiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGraphqlApiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}