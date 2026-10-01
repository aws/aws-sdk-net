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

using Amazon.EKS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeUpdate Request Marshaller
    /// </summary>
    public partial class DescribeUpdateRequestMarshaller : IMarshaller<IRequest, DescribeUpdateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeUpdateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeUpdateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAddonName())
            {
                request.Parameters.Add("addonName", StringUtils.FromString(publicRequest.AddonName));
            }

            if (publicRequest.IsSetCapabilityName())
            {
                request.Parameters.Add("capabilityName", StringUtils.FromString(publicRequest.CapabilityName));
            }

            if (publicRequest.IsSetNodegroupName())
            {
                request.Parameters.Add("nodegroupName", StringUtils.FromString(publicRequest.NodegroupName));
            }

            if (!publicRequest.IsSetName())
            {
                throw new AmazonEKSException("Request object does not have required field Name set");
            }
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));

            if (!publicRequest.IsSetUpdateId())
            {
                throw new AmazonEKSException("Request object does not have required field UpdateId set");
            }
            request.AddPathResource("{updateId}", StringUtils.FromString(publicRequest.UpdateId));

            request.ResourcePath = "/clusters/{name}/updates/{updateId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeUpdateRequestMarshaller _instance = new();

        internal static DescribeUpdateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeUpdateRequestMarshaller Instance => _instance;
    }
}
