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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Cluster Subnet Groups Request Marshaller
    /// </summary>       
    public class DescribeClusterSubnetGroupsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSubnetGroupsRequest>
    {
        public IRequest Marshall(DescribeClusterSubnetGroupsRequest describeClusterSubnetGroupsRequest)
        {
            IRequest request = new DefaultRequest(describeClusterSubnetGroupsRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeClusterSubnetGroups");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeClusterSubnetGroupsRequest != null && describeClusterSubnetGroupsRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(describeClusterSubnetGroupsRequest.ClusterSubnetGroupName));
            }
            if (describeClusterSubnetGroupsRequest != null && describeClusterSubnetGroupsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeClusterSubnetGroupsRequest.MaxRecords));
            }
            if (describeClusterSubnetGroupsRequest != null && describeClusterSubnetGroupsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeClusterSubnetGroupsRequest.Marker));
            }

            return request;
        }
    }
}
