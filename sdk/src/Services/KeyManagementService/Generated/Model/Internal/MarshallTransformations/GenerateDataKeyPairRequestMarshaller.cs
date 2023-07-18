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
    /// GenerateDataKeyPair Request Marshaller
    /// </summary>       
    public class GenerateDataKeyPairRequestMarshaller : IMarshaller<IRequest, GenerateDataKeyPairRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateDataKeyPairRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GenerateDataKeyPairRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.GenerateDataKeyPair";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetEncryptionContext())
                {
                    context.Writer.WritePropertyName("EncryptionContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEncryptionContextKvp in publicRequest.EncryptionContext)
                    {
                        context.Writer.WritePropertyName(publicRequestEncryptionContextKvp.Key);
                        var publicRequestEncryptionContextValue = publicRequestEncryptionContextKvp.Value;

                            context.Writer.Write(publicRequestEncryptionContextValue);
                    }
                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetKeyId())
                {
                    context.Writer.WritePropertyName("KeyId");
                    context.Writer.Write(publicRequest.KeyId);
                }

                if(publicRequest.IsSetKeyPairSpec())
                {
                    context.Writer.WritePropertyName("KeyPairSpec");
                    context.Writer.Write(publicRequest.KeyPairSpec);
                }

                if(publicRequest.IsSetRecipient())
                {
                    context.Writer.WritePropertyName("Recipient");
                    context.Writer.WriteObjectStart();

                    var marshaller = RecipientInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Recipient, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GenerateDataKeyPairRequestMarshaller _instance = new GenerateDataKeyPairRequestMarshaller();        

        internal static GenerateDataKeyPairRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateDataKeyPairRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}