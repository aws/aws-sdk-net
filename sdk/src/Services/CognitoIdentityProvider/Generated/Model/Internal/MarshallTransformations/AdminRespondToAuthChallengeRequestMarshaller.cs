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

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdminRespondToAuthChallenge Request Marshaller
    /// </summary>       
    public class AdminRespondToAuthChallengeRequestMarshaller : IMarshaller<IRequest, AdminRespondToAuthChallengeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AdminRespondToAuthChallengeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AdminRespondToAuthChallengeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.AdminRespondToAuthChallenge";
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
                if(publicRequest.IsSetAnalyticsMetadata())
                {
                    context.Writer.WritePropertyName("AnalyticsMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalyticsMetadataTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnalyticsMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChallengeName())
                {
                    context.Writer.WritePropertyName("ChallengeName");
                    context.Writer.Write(publicRequest.ChallengeName);
                }

                if(publicRequest.IsSetChallengeResponses())
                {
                    context.Writer.WritePropertyName("ChallengeResponses");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestChallengeResponsesKvp in publicRequest.ChallengeResponses)
                    {
                        context.Writer.WritePropertyName(publicRequestChallengeResponsesKvp.Key);
                        var publicRequestChallengeResponsesValue = publicRequestChallengeResponsesKvp.Value;

                            context.Writer.Write(publicRequestChallengeResponsesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientId())
                {
                    context.Writer.WritePropertyName("ClientId");
                    context.Writer.Write(publicRequest.ClientId);
                }

                if(publicRequest.IsSetContextData())
                {
                    context.Writer.WritePropertyName("ContextData");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContextDataTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContextData, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSession())
                {
                    context.Writer.WritePropertyName("Session");
                    context.Writer.Write(publicRequest.Session);
                }

                if(publicRequest.IsSetUserPoolId())
                {
                    context.Writer.WritePropertyName("UserPoolId");
                    context.Writer.Write(publicRequest.UserPoolId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AdminRespondToAuthChallengeRequestMarshaller _instance = new AdminRespondToAuthChallengeRequestMarshaller();        

        internal static AdminRespondToAuthChallengeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminRespondToAuthChallengeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}