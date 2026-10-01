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
    /// DescribeNodegroup Request Marshaller
    /// </summary>
    public partial class DescribeNodegroupRequestMarshaller : IMarshaller<IRequest, DescribeNodegroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeNodegroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeNodegroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetClusterName())
            {
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            }
            request.AddPathResource("{clusterName}", StringUtils.FromString(publicRequest.ClusterName));

            if (!publicRequest.IsSetNodegroupName())
            {
                throw new AmazonEKSException("Request object does not have required field NodegroupName set");
            }
            request.AddPathResource("{nodegroupName}", StringUtils.FromString(publicRequest.NodegroupName));

            request.ResourcePath = "/clusters/{clusterName}/node-groups/{nodegroupName}";

            return request;
        }

        private static readonly DescribeNodegroupRequestMarshaller _instance = new();

        internal static DescribeNodegroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeNodegroupRequestMarshaller Instance => _instance;
    }
}
