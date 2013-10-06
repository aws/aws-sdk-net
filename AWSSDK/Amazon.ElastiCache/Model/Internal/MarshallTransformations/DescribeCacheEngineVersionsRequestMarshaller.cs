/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Cache Engine Versions Request Marshaller
    /// </summary>       
    public class DescribeCacheEngineVersionsRequestMarshaller : IMarshaller<IRequest, DescribeCacheEngineVersionsRequest>
    {
        public IRequest Marshall(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest)
        {
            IRequest request = new DefaultRequest(describeCacheEngineVersionsRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeCacheEngineVersions");
            request.Parameters.Add("Version", "2013-06-15");
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(describeCacheEngineVersionsRequest.Engine));
            }
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(describeCacheEngineVersionsRequest.EngineVersion));
            }
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetCacheParameterGroupFamily())
            {
                request.Parameters.Add("CacheParameterGroupFamily", StringUtils.FromString(describeCacheEngineVersionsRequest.CacheParameterGroupFamily));
            }
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeCacheEngineVersionsRequest.MaxRecords));
            }
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeCacheEngineVersionsRequest.Marker));
            }
            if (describeCacheEngineVersionsRequest != null && describeCacheEngineVersionsRequest.IsSetDefaultOnly())
            {
                request.Parameters.Add("DefaultOnly", StringUtils.FromBool(describeCacheEngineVersionsRequest.DefaultOnly));
            }

            return request;
        }
    }
}
