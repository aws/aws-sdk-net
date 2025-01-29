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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteKxClusterNode Request Marshaller
    /// </summary>       
    public class DeleteKxClusterNodeRequestMarshaller : IMarshaller<IRequest, DeleteKxClusterNodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteKxClusterNodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteKxClusterNodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonFinspaceException("Request object does not have required field ClusterName set");
            request.AddPathResource("{clusterName}", StringUtils.FromString(publicRequest.ClusterName));
            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            if (!publicRequest.IsSetNodeId())
                throw new AmazonFinspaceException("Request object does not have required field NodeId set");
            request.AddPathResource("{nodeId}", StringUtils.FromString(publicRequest.NodeId));
            request.ResourcePath = "/kx/environments/{environmentId}/clusters/{clusterName}/nodes/{nodeId}";

            return request;
        }
        private static DeleteKxClusterNodeRequestMarshaller _instance = new DeleteKxClusterNodeRequestMarshaller();        

        internal static DeleteKxClusterNodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteKxClusterNodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}