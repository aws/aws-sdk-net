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
    /// Describe Cache Parameters Request Marshaller
    /// </summary>       
    public class DescribeCacheParametersRequestMarshaller : IMarshaller<IRequest, DescribeCacheParametersRequest>
    {
        public IRequest Marshall(DescribeCacheParametersRequest describeCacheParametersRequest)
        {
            IRequest request = new DefaultRequest(describeCacheParametersRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "DescribeCacheParameters");
            request.Parameters.Add("Version", "2013-06-15");
            if (describeCacheParametersRequest != null && describeCacheParametersRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(describeCacheParametersRequest.CacheParameterGroupName));
            }
            if (describeCacheParametersRequest != null && describeCacheParametersRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(describeCacheParametersRequest.Source));
            }
            if (describeCacheParametersRequest != null && describeCacheParametersRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeCacheParametersRequest.MaxRecords));
            }
            if (describeCacheParametersRequest != null && describeCacheParametersRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeCacheParametersRequest.Marker));
            }

            return request;
        }
    }
}
