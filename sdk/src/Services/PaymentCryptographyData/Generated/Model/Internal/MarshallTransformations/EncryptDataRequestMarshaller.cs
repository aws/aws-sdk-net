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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptographyData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EncryptData Request Marshaller
    /// </summary>       
    public class EncryptDataRequestMarshaller : IMarshaller<IRequest, EncryptDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EncryptDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EncryptDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKeyIdentifier())
                throw new AmazonPaymentCryptographyDataException("Request object does not have required field KeyIdentifier set");
            request.AddPathResource("{KeyIdentifier}", StringUtils.FromString(publicRequest.KeyIdentifier));
            request.ResourcePath = "/keys/{KeyIdentifier}/encrypt";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEncryptionAttributes())
                {
                    context.Writer.WritePropertyName("EncryptionAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionDecryptionAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPlainText())
                {
                    context.Writer.WritePropertyName("PlainText");
                    context.Writer.Write(publicRequest.PlainText);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static EncryptDataRequestMarshaller _instance = new EncryptDataRequestMarshaller();        

        internal static EncryptDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EncryptDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}