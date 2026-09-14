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

using Amazon.AgentRegistryControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitRegistryRecordForApproval Request Marshaller
    /// </summary>
    public partial class SubmitRegistryRecordForApprovalRequestMarshaller : IMarshaller<IRequest, SubmitRegistryRecordForApprovalRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitRegistryRecordForApprovalRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SubmitRegistryRecordForApprovalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AgentRegistryControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-12-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetRecordId())
            {
                throw new AmazonAgentRegistryControlException("Request object does not have required field RecordId set");
            }
            request.AddPathResource("{recordId}", StringUtils.FromString(publicRequest.RecordId));

            if (!publicRequest.IsSetRegistryId())
            {
                throw new AmazonAgentRegistryControlException("Request object does not have required field RegistryId set");
            }
            request.AddPathResource("{registryId}", StringUtils.FromString(publicRequest.RegistryId));

            request.ResourcePath = "/registries/{registryId}/records/{recordId}/submit-for-approval";

            return request;
        }

        private static readonly SubmitRegistryRecordForApprovalRequestMarshaller _instance = new();

        internal static SubmitRegistryRecordForApprovalRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SubmitRegistryRecordForApprovalRequestMarshaller Instance => _instance;
    }
}
