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
    /// PurchaseReservedCacheNodesOffering Request Marshaller
    /// </summary>
    public partial class PurchaseReservedCacheNodesOfferingRequestMarshaller : IMarshaller<IRequest, PurchaseReservedCacheNodesOfferingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PurchaseReservedCacheNodesOfferingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PurchaseReservedCacheNodesOfferingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PurchaseReservedCacheNodesOffering");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCacheNodeCount())
            {
                request.Parameters.Add("CacheNodeCount", StringUtils.FromInt(publicRequest.CacheNodeCount.Value));
            }
            if (publicRequest.IsSetReservedCacheNodeId())
            {
                request.Parameters.Add("ReservedCacheNodeId", StringUtils.FromString(publicRequest.ReservedCacheNodeId));
            }
            if (publicRequest.IsSetReservedCacheNodesOfferingId())
            {
                request.Parameters.Add("ReservedCacheNodesOfferingId", StringUtils.FromString(publicRequest.ReservedCacheNodesOfferingId));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PurchaseReservedCacheNodesOfferingRequestMarshaller _instance = new();

        internal static PurchaseReservedCacheNodesOfferingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PurchaseReservedCacheNodesOfferingRequestMarshaller Instance => _instance;
    }
}
