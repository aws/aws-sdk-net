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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecretsManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecretsManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRandomPassword Request Marshaller
    /// </summary>       
    public class GetRandomPasswordRequestMarshaller : IMarshaller<IRequest, GetRandomPasswordRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRandomPasswordRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRandomPasswordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecretsManager");
            string target = "secretsmanager.GetRandomPassword";
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
                if(publicRequest.IsSetExcludeCharacters())
                {
                    context.Writer.WritePropertyName("ExcludeCharacters");
                    context.Writer.Write(publicRequest.ExcludeCharacters);
                }

                if(publicRequest.IsSetExcludeLowercase())
                {
                    context.Writer.WritePropertyName("ExcludeLowercase");
                    context.Writer.Write(publicRequest.ExcludeLowercase);
                }

                if(publicRequest.IsSetExcludeNumbers())
                {
                    context.Writer.WritePropertyName("ExcludeNumbers");
                    context.Writer.Write(publicRequest.ExcludeNumbers);
                }

                if(publicRequest.IsSetExcludePunctuation())
                {
                    context.Writer.WritePropertyName("ExcludePunctuation");
                    context.Writer.Write(publicRequest.ExcludePunctuation);
                }

                if(publicRequest.IsSetExcludeUppercase())
                {
                    context.Writer.WritePropertyName("ExcludeUppercase");
                    context.Writer.Write(publicRequest.ExcludeUppercase);
                }

                if(publicRequest.IsSetIncludeSpace())
                {
                    context.Writer.WritePropertyName("IncludeSpace");
                    context.Writer.Write(publicRequest.IncludeSpace);
                }

                if(publicRequest.IsSetPasswordLength())
                {
                    context.Writer.WritePropertyName("PasswordLength");
                    context.Writer.Write(publicRequest.PasswordLength);
                }

                if(publicRequest.IsSetRequireEachIncludedType())
                {
                    context.Writer.WritePropertyName("RequireEachIncludedType");
                    context.Writer.Write(publicRequest.RequireEachIncludedType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetRandomPasswordRequestMarshaller _instance = new GetRandomPasswordRequestMarshaller();        

        internal static GetRandomPasswordRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRandomPasswordRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}