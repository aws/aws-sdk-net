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

using Amazon.Signer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSigningProfile Request Marshaller
    /// </summary>
    public partial class GetSigningProfileRequestMarshaller : IMarshaller<IRequest, GetSigningProfileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSigningProfileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSigningProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetProfileOwner())
            {
                request.Parameters.Add("profileOwner", StringUtils.FromString(publicRequest.ProfileOwner));
            }

            if (!publicRequest.IsSetProfileName())
            {
                throw new AmazonSignerException("Request object does not have required field ProfileName set");
            }
            request.AddPathResource("{profileName}", StringUtils.FromString(publicRequest.ProfileName));

            request.ResourcePath = "/signing-profiles/{profileName}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetSigningProfileRequestMarshaller _instance = new();

        internal static GetSigningProfileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSigningProfileRequestMarshaller Instance => _instance;
    }
}
