/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Transform
{
    /// <summary>
    /// Upload Server Certificate Request Marshaller
    /// </summary>       
    public class UploadServerCertificateRequestMarshaller : IMarshaller<IRequest<UploadServerCertificateRequest>, UploadServerCertificateRequest> 
    {

        public IRequest<UploadServerCertificateRequest> Marshall(UploadServerCertificateRequest uploadServerCertificateRequest) 
        {
            IRequest<UploadServerCertificateRequest> request = new DefaultRequest<UploadServerCertificateRequest>(uploadServerCertificateRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "UploadServerCertificate");
            request.Parameters.Add("Version", "2010-05-08");
            if (uploadServerCertificateRequest != null && uploadServerCertificateRequest.IsSetPath()) 
            {
                request.Parameters.Add("Path", StringUtils.FromString(uploadServerCertificateRequest.Path));
            }
            if (uploadServerCertificateRequest != null && uploadServerCertificateRequest.IsSetServerCertificateName()) 
            {
                request.Parameters.Add("ServerCertificateName", StringUtils.FromString(uploadServerCertificateRequest.ServerCertificateName));
            }
            if (uploadServerCertificateRequest != null && uploadServerCertificateRequest.IsSetCertificateBody()) 
            {
                request.Parameters.Add("CertificateBody", StringUtils.FromString(uploadServerCertificateRequest.CertificateBody));
            }
            if (uploadServerCertificateRequest != null && uploadServerCertificateRequest.IsSetPrivateKey()) 
            {
                request.Parameters.Add("PrivateKey", StringUtils.FromString(uploadServerCertificateRequest.PrivateKey));
            }
            if (uploadServerCertificateRequest != null && uploadServerCertificateRequest.IsSetCertificateChain()) 
            {
                request.Parameters.Add("CertificateChain", StringUtils.FromString(uploadServerCertificateRequest.CertificateChain));
            }


            return request;
        }
    }
}
