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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRevocationStatus Request Marshaller
    /// </summary>       
    public class GetRevocationStatusRequestMarshaller : IMarshaller<IRequest, GetRevocationStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRevocationStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRevocationStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-25";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCertificateHashes())
                request.ParameterCollection.Add("certificateHashes", publicRequest.CertificateHashes);
            
            if (publicRequest.IsSetJobArn())
                request.Parameters.Add("jobArn", StringUtils.FromString(publicRequest.JobArn));
            
            if (publicRequest.IsSetPlatformId())
                request.Parameters.Add("platformId", StringUtils.FromString(publicRequest.PlatformId));
            
            if (publicRequest.IsSetProfileVersionArn())
                request.Parameters.Add("profileVersionArn", StringUtils.FromString(publicRequest.ProfileVersionArn));
            
            if (publicRequest.IsSetSignatureTimestamp())
                request.Parameters.Add("signatureTimestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.SignatureTimestamp));
            request.ResourcePath = "/revocations";
            request.UseQueryString = true;
            
            request.HostPrefix = $"verification.";

            return request;
        }
        private static GetRevocationStatusRequestMarshaller _instance = new GetRevocationStatusRequestMarshaller();        

        internal static GetRevocationStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRevocationStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}