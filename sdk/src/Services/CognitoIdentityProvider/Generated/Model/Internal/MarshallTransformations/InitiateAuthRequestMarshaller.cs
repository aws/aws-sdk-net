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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InitiateAuth Request Marshaller
    /// </summary>       
    public class InitiateAuthRequestMarshaller : IMarshaller<IRequest, InitiateAuthRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InitiateAuthRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InitiateAuthRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.InitiateAuth";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnalyticsMetadata())
                {
                    context.Writer.WritePropertyName("AnalyticsMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalyticsMetadataTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnalyticsMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuthFlow())
                {
                    context.Writer.WritePropertyName("AuthFlow");
                    context.Writer.Write(publicRequest.AuthFlow);
                }

                if(publicRequest.IsSetAuthParameters())
                {
                    context.Writer.WritePropertyName("AuthParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAuthParametersKvp in publicRequest.AuthParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestAuthParametersKvp.Key);
                        var publicRequestAuthParametersValue = publicRequestAuthParametersKvp.Value;

                            context.Writer.Write(publicRequestAuthParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("ClientId");
                    context.Writer.Write(publicRequest.ClientId);
                }

                if(publicRequest.IsSetClientMetadata())
                {
                    context.Writer.WritePropertyName("ClientMetadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestClientMetadataKvp in publicRequest.ClientMetadata)
                    {
                        context.Writer.WritePropertyName(publicRequestClientMetadataKvp.Key);
                        var publicRequestClientMetadataValue = publicRequestClientMetadataKvp.Value;

                            context.Writer.Write(publicRequestClientMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSession())
                {
                    context.Writer.WritePropertyName("Session");
                    context.Writer.Write(publicRequest.Session);
                }

                if(publicRequest.IsSetUserContextData())
                {
                    context.Writer.WritePropertyName("UserContextData");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserContextDataTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserContextData, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static InitiateAuthRequestMarshaller _instance = new InitiateAuthRequestMarshaller();        

        internal static InitiateAuthRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InitiateAuthRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}