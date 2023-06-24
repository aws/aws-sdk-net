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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ValidateE911Address Request Marshaller
    /// </summary>       
    public class ValidateE911AddressRequestMarshaller : IMarshaller<IRequest, ValidateE911AddressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ValidateE911AddressRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ValidateE911AddressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/emergency-calling/address";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAwsAccountId())
                {
                    context.Writer.WritePropertyName("AwsAccountId");
                    context.Writer.Write(publicRequest.AwsAccountId);
                }

                if(publicRequest.IsSetCity())
                {
                    context.Writer.WritePropertyName("City");
                    context.Writer.Write(publicRequest.City);
                }

                if(publicRequest.IsSetCountry())
                {
                    context.Writer.WritePropertyName("Country");
                    context.Writer.Write(publicRequest.Country);
                }

                if(publicRequest.IsSetPostalCode())
                {
                    context.Writer.WritePropertyName("PostalCode");
                    context.Writer.Write(publicRequest.PostalCode);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("State");
                    context.Writer.Write(publicRequest.State);
                }

                if(publicRequest.IsSetStreetInfo())
                {
                    context.Writer.WritePropertyName("StreetInfo");
                    context.Writer.Write(publicRequest.StreetInfo);
                }

                if(publicRequest.IsSetStreetNumber())
                {
                    context.Writer.WritePropertyName("StreetNumber");
                    context.Writer.Write(publicRequest.StreetNumber);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ValidateE911AddressRequestMarshaller _instance = new ValidateE911AddressRequestMarshaller();        

        internal static ValidateE911AddressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidateE911AddressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}