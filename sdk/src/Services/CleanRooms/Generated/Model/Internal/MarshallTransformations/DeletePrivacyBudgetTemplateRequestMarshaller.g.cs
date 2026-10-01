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

using Amazon.CleanRooms.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePrivacyBudgetTemplate Request Marshaller
    /// </summary>
    public partial class DeletePrivacyBudgetTemplateRequestMarshaller : IMarshaller<IRequest, DeletePrivacyBudgetTemplateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePrivacyBudgetTemplateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeletePrivacyBudgetTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMembershipIdentifier())
            {
                throw new AmazonCleanRoomsException("Request object does not have required field MembershipIdentifier set");
            }
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));

            if (!publicRequest.IsSetPrivacyBudgetTemplateIdentifier())
            {
                throw new AmazonCleanRoomsException("Request object does not have required field PrivacyBudgetTemplateIdentifier set");
            }
            request.AddPathResource("{privacyBudgetTemplateIdentifier}", StringUtils.FromString(publicRequest.PrivacyBudgetTemplateIdentifier));

            request.ResourcePath = "/memberships/{membershipIdentifier}/privacybudgettemplates/{privacyBudgetTemplateIdentifier}";

            return request;
        }

        private static readonly DeletePrivacyBudgetTemplateRequestMarshaller _instance = new();

        internal static DeletePrivacyBudgetTemplateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeletePrivacyBudgetTemplateRequestMarshaller Instance => _instance;
    }
}
