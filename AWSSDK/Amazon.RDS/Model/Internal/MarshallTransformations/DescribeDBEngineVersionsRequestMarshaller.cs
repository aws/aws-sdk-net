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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe D B Engine Versions Request Marshaller
    /// </summary>       
    public class DescribeDBEngineVersionsRequestMarshaller : IMarshaller<IRequest, DescribeDBEngineVersionsRequest>
    {
        public IRequest Marshall(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest)
        {
            IRequest request = new DefaultRequest(describeDBEngineVersionsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeDBEngineVersions");
            request.Parameters.Add("Version", "2013-05-15");
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(describeDBEngineVersionsRequest.Engine));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(describeDBEngineVersionsRequest.EngineVersion));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetDBParameterGroupFamily())
            {
                request.Parameters.Add("DBParameterGroupFamily", StringUtils.FromString(describeDBEngineVersionsRequest.DBParameterGroupFamily));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeDBEngineVersionsRequest.MaxRecords));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeDBEngineVersionsRequest.Marker));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetDefaultOnly())
            {
                request.Parameters.Add("DefaultOnly", StringUtils.FromBool(describeDBEngineVersionsRequest.DefaultOnly));
            }
            if (describeDBEngineVersionsRequest != null && describeDBEngineVersionsRequest.IsSetListSupportedCharacterSets())
            {
                request.Parameters.Add("ListSupportedCharacterSets", StringUtils.FromBool(describeDBEngineVersionsRequest.ListSupportedCharacterSets));
            }

            return request;
        }
    }
}
