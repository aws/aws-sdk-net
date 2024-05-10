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
    /// VerifyCardValidationData Request Marshaller
    /// </summary>       
    public class VerifyCardValidationDataRequestMarshaller : IMarshaller<IRequest, VerifyCardValidationDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((VerifyCardValidationDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(VerifyCardValidationDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/cardvalidationdata/verify";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetKeyIdentifier())
                {
                    context.Writer.WritePropertyName("KeyIdentifier");
                    context.Writer.Write(publicRequest.KeyIdentifier);
                }

                if(publicRequest.IsSetPrimaryAccountNumber())
                {
                    context.Writer.WritePropertyName("PrimaryAccountNumber");
                    context.Writer.Write(publicRequest.PrimaryAccountNumber);
                }

                if(publicRequest.IsSetValidationData())
                {
                    context.Writer.WritePropertyName("ValidationData");
                    context.Writer.Write(publicRequest.ValidationData);
                }

                if(publicRequest.IsSetVerificationAttributes())
                {
                    context.Writer.WritePropertyName("VerificationAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = CardVerificationAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VerificationAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static VerifyCardValidationDataRequestMarshaller _instance = new VerifyCardValidationDataRequestMarshaller();        

        internal static VerifyCardValidationDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifyCardValidationDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}