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
    /// UpdateCACertificate Request Marshaller
    /// </summary>       
    public class UpdateCACertificateRequestMarshaller : IMarshaller<IRequest, UpdateCACertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCACertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCACertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/cacertificate/{caCertificateId}";
            if (!publicRequest.IsSetCertificateId())
                throw new AmazonIoTException("Request object does not have required field CertificateId set");
            uriResourcePath = uriResourcePath.Replace("{caCertificateId}", StringUtils.FromString(publicRequest.CertificateId));
            
            if (publicRequest.IsSetNewAutoRegistrationStatus())
                request.Parameters.Add("newAutoRegistrationStatus", StringUtils.FromString(publicRequest.NewAutoRegistrationStatus));
            
            if (publicRequest.IsSetNewStatus())
                request.Parameters.Add("newStatus", StringUtils.FromString(publicRequest.NewStatus));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetRegistrationConfig())
                {
                    context.Writer.WritePropertyName("registrationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = RegistrationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RegistrationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRemoveAutoRegistration())
                {
                    context.Writer.WritePropertyName("removeAutoRegistration");
                    context.Writer.Write(publicRequest.RemoveAutoRegistration);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateCACertificateRequestMarshaller _instance = new UpdateCACertificateRequestMarshaller();        

        internal static UpdateCACertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCACertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}