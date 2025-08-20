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
    /// UpdateTerms Request Marshaller
    /// </summary>       
    public class UpdateTermsRequestMarshaller : IMarshaller<IRequest, UpdateTermsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTermsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTermsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentityProvider");
            string target = "AWSCognitoIdentityProviderService.UpdateTerms";
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
                if(publicRequest.IsSetEnforcement())
                {
                    context.Writer.WritePropertyName("Enforcement");
                    context.Writer.Write(publicRequest.Enforcement);
                }

                if(publicRequest.IsSetLinks())
                {
                    context.Writer.WritePropertyName("Links");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestLinksKvp in publicRequest.Links)
                    {
                        context.Writer.WritePropertyName(publicRequestLinksKvp.Key);
                        var publicRequestLinksValue = publicRequestLinksKvp.Value;

                            context.Writer.Write(publicRequestLinksValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTermsId())
                {
                    context.Writer.WritePropertyName("TermsId");
                    context.Writer.Write(publicRequest.TermsId);
                }

                if(publicRequest.IsSetTermsName())
                {
                    context.Writer.WritePropertyName("TermsName");
                    context.Writer.Write(publicRequest.TermsName);
                }

                if(publicRequest.IsSetTermsSource())
                {
                    context.Writer.WritePropertyName("TermsSource");
                    context.Writer.Write(publicRequest.TermsSource);
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
        private static UpdateTermsRequestMarshaller _instance = new UpdateTermsRequestMarshaller();        

        internal static UpdateTermsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTermsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}