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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAuthorizer Request Marshaller
    /// </summary>       
    public class CreateAuthorizerRequestMarshaller : IMarshaller<IRequest, CreateAuthorizerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAuthorizerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAuthorizerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/authorizer/{authorizerName}";
            if (!publicRequest.IsSetAuthorizerName())
                throw new AmazonIoTException("Request object does not have required field AuthorizerName set");
            uriResourcePath = uriResourcePath.Replace("{authorizerName}", StringUtils.FromString(publicRequest.AuthorizerName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizerFunctionArn())
                {
                    context.Writer.WritePropertyName("authorizerFunctionArn");
                    context.Writer.Write(publicRequest.AuthorizerFunctionArn);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTokenKeyName())
                {
                    context.Writer.WritePropertyName("tokenKeyName");
                    context.Writer.Write(publicRequest.TokenKeyName);
                }

                if(publicRequest.IsSetTokenSigningPublicKeys())
                {
                    context.Writer.WritePropertyName("tokenSigningPublicKeys");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTokenSigningPublicKeysKvp in publicRequest.TokenSigningPublicKeys)
                    {
                        context.Writer.WritePropertyName(publicRequestTokenSigningPublicKeysKvp.Key);
                        var publicRequestTokenSigningPublicKeysValue = publicRequestTokenSigningPublicKeysKvp.Value;

                            context.Writer.Write(publicRequestTokenSigningPublicKeysValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAuthorizerRequestMarshaller _instance = new CreateAuthorizerRequestMarshaller();        

        internal static CreateAuthorizerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAuthorizerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}