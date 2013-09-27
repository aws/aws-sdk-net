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
    /// Describe Cluster Security Groups Request Marshaller
    /// </summary>       
    public class DescribeClusterSecurityGroupsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSecurityGroupsRequest>
    {
        public IRequest Marshall(DescribeClusterSecurityGroupsRequest describeClusterSecurityGroupsRequest)
        {
            IRequest request = new DefaultRequest(describeClusterSecurityGroupsRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeClusterSecurityGroups");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeClusterSecurityGroupsRequest != null && describeClusterSecurityGroupsRequest.IsSetClusterSecurityGroupName())
            {
                request.Parameters.Add("ClusterSecurityGroupName", StringUtils.FromString(describeClusterSecurityGroupsRequest.ClusterSecurityGroupName));
            }
            if (describeClusterSecurityGroupsRequest != null && describeClusterSecurityGroupsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeClusterSecurityGroupsRequest.MaxRecords));
            }
            if (describeClusterSecurityGroupsRequest != null && describeClusterSecurityGroupsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeClusterSecurityGroupsRequest.Marker));
            }

            return request;
        }
    }
}
