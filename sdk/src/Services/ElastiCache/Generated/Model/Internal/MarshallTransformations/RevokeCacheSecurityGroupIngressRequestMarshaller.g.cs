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

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevokeCacheSecurityGroupIngress Request Marshaller
    /// </summary>
    public partial class RevokeCacheSecurityGroupIngressRequestMarshaller : IMarshaller<IRequest, RevokeCacheSecurityGroupIngressRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokeCacheSecurityGroupIngressRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RevokeCacheSecurityGroupIngressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RevokeCacheSecurityGroupIngress");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCacheSecurityGroupName())
            {
                request.Parameters.Add("CacheSecurityGroupName", StringUtils.FromString(publicRequest.CacheSecurityGroupName));
            }
            if (publicRequest.IsSetEC2SecurityGroupName())
            {
                request.Parameters.Add("EC2SecurityGroupName", StringUtils.FromString(publicRequest.EC2SecurityGroupName));
            }
            if (publicRequest.IsSetEC2SecurityGroupOwnerId())
            {
                request.Parameters.Add("EC2SecurityGroupOwnerId", StringUtils.FromString(publicRequest.EC2SecurityGroupOwnerId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RevokeCacheSecurityGroupIngressRequestMarshaller _instance = new();

        internal static RevokeCacheSecurityGroupIngressRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RevokeCacheSecurityGroupIngressRequestMarshaller Instance => _instance;
    }
}
