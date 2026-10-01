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

using Amazon.Wickr.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteSecurityGroup Request Marshaller
    /// </summary>
    public partial class DeleteSecurityGroupRequestMarshaller : IMarshaller<IRequest, DeleteSecurityGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteSecurityGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteSecurityGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Wickr");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-01";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetGroupId())
            {
                throw new AmazonWickrException("Request object does not have required field GroupId set");
            }
            request.AddPathResource("{groupId}", StringUtils.FromString(publicRequest.GroupId));

            if (!publicRequest.IsSetNetworkId())
            {
                throw new AmazonWickrException("Request object does not have required field NetworkId set");
            }
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));

            request.ResourcePath = "/networks/{networkId}/security-groups/{groupId}";

            return request;
        }

        private static readonly DeleteSecurityGroupRequestMarshaller _instance = new();

        internal static DeleteSecurityGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteSecurityGroupRequestMarshaller Instance => _instance;
    }
}
