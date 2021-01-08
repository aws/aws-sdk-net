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
using ThirdParty.Json.LitJson;

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSigningProfile Request Marshaller
    /// </summary>       
    public class GetSigningProfileRequestMarshaller : IMarshaller<IRequest, GetSigningProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSigningProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSigningProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-25";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetProfileName())
                throw new AmazonSignerException("Request object does not have required field ProfileName set");
            request.AddPathResource("{profileName}", StringUtils.FromString(publicRequest.ProfileName));
            
            if (publicRequest.IsSetProfileOwner())
                request.Parameters.Add("profileOwner", StringUtils.FromString(publicRequest.ProfileOwner));
            request.ResourcePath = "/signing-profiles/{profileName}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static GetSigningProfileRequestMarshaller _instance = new GetSigningProfileRequestMarshaller();        

        internal static GetSigningProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSigningProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}