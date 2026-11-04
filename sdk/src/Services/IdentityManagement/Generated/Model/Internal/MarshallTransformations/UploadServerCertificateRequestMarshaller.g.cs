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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.IdentityManagement.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UploadServerCertificate Request Marshaller
    /// </summary>
    public partial class UploadServerCertificateRequestMarshaller : IMarshaller<IRequest, UploadServerCertificateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UploadServerCertificateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UploadServerCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UploadServerCertificate");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetCertificateBody())
            {
                request.Parameters.Add("CertificateBody", StringUtils.FromString(publicRequest.CertificateBody));
            }
            if (publicRequest.IsSetCertificateChain())
            {
                request.Parameters.Add("CertificateChain", StringUtils.FromString(publicRequest.CertificateChain));
            }
            if (publicRequest.IsSetPath())
            {
                request.Parameters.Add("Path", StringUtils.FromString(publicRequest.Path));
            }
            if (publicRequest.IsSetPrivateKey())
            {
                request.Parameters.Add("PrivateKey", StringUtils.FromString(publicRequest.PrivateKey));
            }
            if (publicRequest.IsSetServerCertificateName())
            {
                request.Parameters.Add("ServerCertificateName", StringUtils.FromString(publicRequest.ServerCertificateName));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UploadServerCertificateRequestMarshaller _instance = new();

        internal static UploadServerCertificateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UploadServerCertificateRequestMarshaller Instance => _instance;
    }
}
