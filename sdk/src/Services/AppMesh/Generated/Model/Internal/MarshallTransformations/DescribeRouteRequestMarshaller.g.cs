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

using Amazon.AppMesh.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeRoute Request Marshaller
    /// </summary>
    public partial class DescribeRouteRequestMarshaller : IMarshaller<IRequest, DescribeRouteRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeRouteRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMeshOwner())
            {
                request.Parameters.Add("meshOwner", StringUtils.FromString(publicRequest.MeshOwner));
            }

            if (!publicRequest.IsSetMeshName())
            {
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            }
            request.AddPathResource("{meshName}", StringUtils.FromString(publicRequest.MeshName));

            if (!publicRequest.IsSetRouteName())
            {
                throw new AmazonAppMeshException("Request object does not have required field RouteName set");
            }
            request.AddPathResource("{routeName}", StringUtils.FromString(publicRequest.RouteName));

            if (!publicRequest.IsSetVirtualRouterName())
            {
                throw new AmazonAppMeshException("Request object does not have required field VirtualRouterName set");
            }
            request.AddPathResource("{virtualRouterName}", StringUtils.FromString(publicRequest.VirtualRouterName));

            request.ResourcePath = "/v20190125/meshes/{meshName}/virtualRouter/{virtualRouterName}/routes/{routeName}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeRouteRequestMarshaller _instance = new();

        internal static DescribeRouteRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeRouteRequestMarshaller Instance => _instance;
    }
}
