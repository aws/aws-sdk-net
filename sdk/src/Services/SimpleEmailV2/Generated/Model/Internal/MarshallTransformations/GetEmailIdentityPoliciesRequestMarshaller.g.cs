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

using Amazon.SimpleEmailV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEmailIdentityPolicies Request Marshaller
    /// </summary>
    public partial class GetEmailIdentityPoliciesRequestMarshaller : IMarshaller<IRequest, GetEmailIdentityPoliciesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEmailIdentityPoliciesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEmailIdentityPoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetEmailIdentity())
            {
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field EmailIdentity set");
            }
            request.AddPathResource("{EmailIdentity}", StringUtils.FromString(publicRequest.EmailIdentity));

            request.ResourcePath = "/v2/email/identities/{EmailIdentity}/policies";

            return request;
        }

        private static readonly GetEmailIdentityPoliciesRequestMarshaller _instance = new();

        internal static GetEmailIdentityPoliciesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEmailIdentityPoliciesRequestMarshaller Instance => _instance;
    }
}
