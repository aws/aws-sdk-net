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
    /// AcceptCertificateTransfer Request Marshaller
    /// </summary>       
    public class AcceptCertificateTransferRequestMarshaller : IMarshaller<IRequest, AcceptCertificateTransferRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AcceptCertificateTransferRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AcceptCertificateTransferRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetCertificateId())
                throw new AmazonIoTException("Request object does not have required field CertificateId set");
            request.AddPathResource("{certificateId}", StringUtils.FromString(publicRequest.CertificateId));
            
            if (publicRequest.IsSetSetAsActive())
                request.Parameters.Add("setAsActive", StringUtils.FromBool(publicRequest.SetAsActive));
            request.ResourcePath = "/accept-certificate-transfer/{certificateId}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static AcceptCertificateTransferRequestMarshaller _instance = new AcceptCertificateTransferRequestMarshaller();        

        internal static AcceptCertificateTransferRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcceptCertificateTransferRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}