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
    /// GetCollaborationPrivacyBudgetTemplate Request Marshaller
    /// </summary>
    public partial class GetCollaborationPrivacyBudgetTemplateRequestMarshaller : IMarshaller<IRequest, GetCollaborationPrivacyBudgetTemplateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCollaborationPrivacyBudgetTemplateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCollaborationPrivacyBudgetTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCollaborationIdentifier())
            {
                throw new AmazonCleanRoomsException("Request object does not have required field CollaborationIdentifier set");
            }
            request.AddPathResource("{collaborationIdentifier}", StringUtils.FromString(publicRequest.CollaborationIdentifier));

            if (!publicRequest.IsSetPrivacyBudgetTemplateIdentifier())
            {
                throw new AmazonCleanRoomsException("Request object does not have required field PrivacyBudgetTemplateIdentifier set");
            }
            request.AddPathResource("{privacyBudgetTemplateIdentifier}", StringUtils.FromString(publicRequest.PrivacyBudgetTemplateIdentifier));

            request.ResourcePath = "/collaborations/{collaborationIdentifier}/privacybudgettemplates/{privacyBudgetTemplateIdentifier}";

            return request;
        }

        private static readonly GetCollaborationPrivacyBudgetTemplateRequestMarshaller _instance = new();

        internal static GetCollaborationPrivacyBudgetTemplateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCollaborationPrivacyBudgetTemplateRequestMarshaller Instance => _instance;
    }
}
