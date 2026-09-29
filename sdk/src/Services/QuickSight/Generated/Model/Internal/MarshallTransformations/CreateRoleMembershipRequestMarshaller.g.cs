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

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRoleMembership Request Marshaller
    /// </summary>
    public partial class CreateRoleMembershipRequestMarshaller : IMarshaller<IRequest, CreateRoleMembershipRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRoleMembershipRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateRoleMembershipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            }
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));

            if (!publicRequest.IsSetMemberName())
            {
                throw new AmazonQuickSightException("Request object does not have required field MemberName set");
            }
            request.AddPathResource("{MemberName}", StringUtils.FromString(publicRequest.MemberName));

            if (!publicRequest.IsSetNamespace())
            {
                throw new AmazonQuickSightException("Request object does not have required field Namespace set");
            }
            request.AddPathResource("{Namespace}", StringUtils.FromString(publicRequest.Namespace));

            if (!publicRequest.IsSetRole())
            {
                throw new AmazonQuickSightException("Request object does not have required field Role set");
            }
            request.AddPathResource("{Role}", StringUtils.FromString(publicRequest.Role));

            request.ResourcePath = "/accounts/{AwsAccountId}/namespaces/{Namespace}/roles/{Role}/members/{MemberName}";

            return request;
        }

        private static readonly CreateRoleMembershipRequestMarshaller _instance = new();

        internal static CreateRoleMembershipRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateRoleMembershipRequestMarshaller Instance => _instance;
    }
}
