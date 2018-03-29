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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PurchaseReservedCacheNodesOffering Request Marshaller
    /// </summary>       
    public class PurchaseReservedCacheNodesOfferingRequestMarshaller : IMarshaller<IRequest, PurchaseReservedCacheNodesOfferingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PurchaseReservedCacheNodesOfferingRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PurchaseReservedCacheNodesOfferingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "PurchaseReservedCacheNodesOffering");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheNodeCount())
                {
                    request.Parameters.Add("CacheNodeCount", StringUtils.FromInt(publicRequest.CacheNodeCount));
                }
                if(publicRequest.IsSetReservedCacheNodeId())
                {
                    request.Parameters.Add("ReservedCacheNodeId", StringUtils.FromString(publicRequest.ReservedCacheNodeId));
                }
                if(publicRequest.IsSetReservedCacheNodesOfferingId())
                {
                    request.Parameters.Add("ReservedCacheNodesOfferingId", StringUtils.FromString(publicRequest.ReservedCacheNodesOfferingId));
                }
            }
            return request;
        }
                    private static PurchaseReservedCacheNodesOfferingRequestMarshaller _instance = new PurchaseReservedCacheNodesOfferingRequestMarshaller();        

        internal static PurchaseReservedCacheNodesOfferingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PurchaseReservedCacheNodesOfferingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}