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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptography.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateKey Request Marshaller
    /// </summary>       
    public class CreateKeyRequestMarshaller : IMarshaller<IRequest, CreateKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptography");
            string target = "PaymentCryptographyControlPlane.CreateKey";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-09-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeriveKeyUsage())
                {
                    context.Writer.WritePropertyName("DeriveKeyUsage");
                    context.Writer.Write(publicRequest.DeriveKeyUsage);
                }

                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("Enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetExportable())
                {
                    context.Writer.WritePropertyName("Exportable");
                    context.Writer.Write(publicRequest.Exportable);
                }

                if(publicRequest.IsSetKeyAttributes())
                {
                    context.Writer.WritePropertyName("KeyAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = KeyAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KeyAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKeyCheckValueAlgorithm())
                {
                    context.Writer.WritePropertyName("KeyCheckValueAlgorithm");
                    context.Writer.Write(publicRequest.KeyCheckValueAlgorithm);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateKeyRequestMarshaller _instance = new CreateKeyRequestMarshaller();        

        internal static CreateKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}