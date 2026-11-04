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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResizeCluster Request Marshaller
    /// </summary>
    public partial class ResizeClusterRequestMarshaller : IMarshaller<IRequest, ResizeClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ResizeClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ResizeClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ResizeCluster");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetClassic())
            {
                request.Parameters.Add("Classic", StringUtils.FromBool(publicRequest.Classic.Value));
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetClusterType())
            {
                request.Parameters.Add("ClusterType", StringUtils.FromString(publicRequest.ClusterType));
            }
            if (publicRequest.IsSetNodeType())
            {
                request.Parameters.Add("NodeType", StringUtils.FromString(publicRequest.NodeType));
            }
            if (publicRequest.IsSetNumberOfNodes())
            {
                request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(publicRequest.NumberOfNodes.Value));
            }
            if (publicRequest.IsSetReservedNodeId())
            {
                request.Parameters.Add("ReservedNodeId", StringUtils.FromString(publicRequest.ReservedNodeId));
            }
            if (publicRequest.IsSetTargetReservedNodeOfferingId())
            {
                request.Parameters.Add("TargetReservedNodeOfferingId", StringUtils.FromString(publicRequest.TargetReservedNodeOfferingId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ResizeClusterRequestMarshaller _instance = new();

        internal static ResizeClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResizeClusterRequestMarshaller Instance => _instance;
    }
}
