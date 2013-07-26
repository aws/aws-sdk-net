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
    /// Describe Reserved Nodes Request Marshaller
    /// </summary>       
    public class DescribeReservedNodesRequestMarshaller : IMarshaller<IRequest, DescribeReservedNodesRequest>
    {
        public IRequest Marshall(DescribeReservedNodesRequest describeReservedNodesRequest)
        {
            IRequest request = new DefaultRequest(describeReservedNodesRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeReservedNodes");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeReservedNodesRequest != null && describeReservedNodesRequest.IsSetReservedNodeId())
            {
                request.Parameters.Add("ReservedNodeId", StringUtils.FromString(describeReservedNodesRequest.ReservedNodeId));
            }
            if (describeReservedNodesRequest != null && describeReservedNodesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeReservedNodesRequest.MaxRecords));
            }
            if (describeReservedNodesRequest != null && describeReservedNodesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeReservedNodesRequest.Marker));
            }

            return request;
        }
    }
}
