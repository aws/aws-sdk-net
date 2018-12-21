/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeRoute Request Marshaller
    /// </summary>       
    public class DescribeRouteRequestMarshaller : IMarshaller<IRequest, DescribeRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-01";            
            request.HttpMethod = "GET";

            string uriResourcePath = "/meshes/{meshName}/virtualRouter/{virtualRouterName}/routes/{routeName}";
            if (!publicRequest.IsSetMeshName())
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            uriResourcePath = uriResourcePath.Replace("{meshName}", StringUtils.FromStringWithSlashEncoding(publicRequest.MeshName));
            if (!publicRequest.IsSetRouteName())
                throw new AmazonAppMeshException("Request object does not have required field RouteName set");
            uriResourcePath = uriResourcePath.Replace("{routeName}", StringUtils.FromStringWithSlashEncoding(publicRequest.RouteName));
            if (!publicRequest.IsSetVirtualRouterName())
                throw new AmazonAppMeshException("Request object does not have required field VirtualRouterName set");
            uriResourcePath = uriResourcePath.Replace("{virtualRouterName}", StringUtils.FromStringWithSlashEncoding(publicRequest.VirtualRouterName));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DescribeRouteRequestMarshaller _instance = new DescribeRouteRequestMarshaller();        

        internal static DescribeRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}