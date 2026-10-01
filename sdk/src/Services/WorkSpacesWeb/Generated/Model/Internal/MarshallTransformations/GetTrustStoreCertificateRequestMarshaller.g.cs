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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.WorkSpacesWeb.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTrustStoreCertificate Request Marshaller
    /// </summary>
    public partial class GetTrustStoreCertificateRequestMarshaller : IMarshaller<IRequest, GetTrustStoreCertificateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTrustStoreCertificateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTrustStoreCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesWeb");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-08";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.Thumbprint))
            {
                throw new AmazonWorkSpacesWebException("Request object does not have required field Thumbprint set");
            }

            if (publicRequest.IsSetThumbprint())
            {
                request.Parameters.Add("thumbprint", StringUtils.FromString(publicRequest.Thumbprint));
            }

            if (!publicRequest.IsSetTrustStoreArn())
            {
                throw new AmazonWorkSpacesWebException("Request object does not have required field TrustStoreArn set");
            }
            request.AddPathResource("{trustStoreArn+}", StringUtils.FromString(publicRequest.TrustStoreArn.TrimStart('/')));

            request.ResourcePath = "/trustStores/{trustStoreArn+}/certificate";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetTrustStoreCertificateRequestMarshaller _instance = new();

        internal static GetTrustStoreCertificateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTrustStoreCertificateRequestMarshaller Instance => _instance;
    }
}
