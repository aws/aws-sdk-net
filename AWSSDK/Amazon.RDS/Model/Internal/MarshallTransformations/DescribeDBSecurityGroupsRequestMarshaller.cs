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
    /// Describe D B Security Groups Request Marshaller
    /// </summary>       
    public class DescribeDBSecurityGroupsRequestMarshaller : IMarshaller<IRequest, DescribeDBSecurityGroupsRequest>
    {
        public IRequest Marshall(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest)
        {
            IRequest request = new DefaultRequest(describeDBSecurityGroupsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeDBSecurityGroups");
            request.Parameters.Add("Version", "2013-05-15");
            if (describeDBSecurityGroupsRequest != null && describeDBSecurityGroupsRequest.IsSetDBSecurityGroupName())
            {
                request.Parameters.Add("DBSecurityGroupName", StringUtils.FromString(describeDBSecurityGroupsRequest.DBSecurityGroupName));
            }
            if (describeDBSecurityGroupsRequest != null && describeDBSecurityGroupsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeDBSecurityGroupsRequest.MaxRecords));
            }
            if (describeDBSecurityGroupsRequest != null && describeDBSecurityGroupsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeDBSecurityGroupsRequest.Marker));
            }

            return request;
        }
    }
}
