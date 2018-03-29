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
    /// RegisterCACertificate Request Marshaller
    /// </summary>       
    public class RegisterCACertificateRequestMarshaller : IMarshaller<IRequest, RegisterCACertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterCACertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterCACertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/cacertificate";
            
            if (publicRequest.IsSetAllowAutoRegistration())
                request.Parameters.Add("allowAutoRegistration", StringUtils.FromBool(publicRequest.AllowAutoRegistration));
            
            if (publicRequest.IsSetSetAsActive())
                request.Parameters.Add("setAsActive", StringUtils.FromBool(publicRequest.SetAsActive));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCaCertificate())
                {
                    context.Writer.WritePropertyName("caCertificate");
                    context.Writer.Write(publicRequest.CaCertificate);
                }

                if(publicRequest.IsSetRegistrationConfig())
                {
                    context.Writer.WritePropertyName("registrationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = RegistrationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RegistrationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVerificationCertificate())
                {
                    context.Writer.WritePropertyName("verificationCertificate");
                    context.Writer.Write(publicRequest.VerificationCertificate);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static RegisterCACertificateRequestMarshaller _instance = new RegisterCACertificateRequestMarshaller();        

        internal static RegisterCACertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterCACertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}