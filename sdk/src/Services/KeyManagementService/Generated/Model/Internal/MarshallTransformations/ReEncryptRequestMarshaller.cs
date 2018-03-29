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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReEncrypt Request Marshaller
    /// </summary>       
    public class ReEncryptRequestMarshaller : IMarshaller<IRequest, ReEncryptRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReEncryptRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReEncryptRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.ReEncrypt";
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
                if(publicRequest.IsSetCiphertextBlob())
                {
                    context.Writer.WritePropertyName("CiphertextBlob");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.CiphertextBlob));
                }

                if(publicRequest.IsSetDestinationEncryptionContext())
                {
                    context.Writer.WritePropertyName("DestinationEncryptionContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDestinationEncryptionContextKvp in publicRequest.DestinationEncryptionContext)
                    {
                        context.Writer.WritePropertyName(publicRequestDestinationEncryptionContextKvp.Key);
                        var publicRequestDestinationEncryptionContextValue = publicRequestDestinationEncryptionContextKvp.Value;

                            context.Writer.Write(publicRequestDestinationEncryptionContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDestinationKeyId())
                {
                    context.Writer.WritePropertyName("DestinationKeyId");
                    context.Writer.Write(publicRequest.DestinationKeyId);
                }

                if(publicRequest.IsSetGrantTokens())
                {
                    context.Writer.WritePropertyName("GrantTokens");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGrantTokensListValue in publicRequest.GrantTokens)
                    {
                            context.Writer.Write(publicRequestGrantTokensListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSourceEncryptionContext())
                {
                    context.Writer.WritePropertyName("SourceEncryptionContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSourceEncryptionContextKvp in publicRequest.SourceEncryptionContext)
                    {
                        context.Writer.WritePropertyName(publicRequestSourceEncryptionContextKvp.Key);
                        var publicRequestSourceEncryptionContextValue = publicRequestSourceEncryptionContextKvp.Value;

                            context.Writer.Write(publicRequestSourceEncryptionContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ReEncryptRequestMarshaller _instance = new ReEncryptRequestMarshaller();        

        internal static ReEncryptRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReEncryptRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}