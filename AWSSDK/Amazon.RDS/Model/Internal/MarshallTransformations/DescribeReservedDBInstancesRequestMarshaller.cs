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
    /// Describe Reserved D B Instances Request Marshaller
    /// </summary>       
    public class DescribeReservedDBInstancesRequestMarshaller : IMarshaller<IRequest, DescribeReservedDBInstancesRequest>
    {
        public IRequest Marshall(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest)
        {
            IRequest request = new DefaultRequest(describeReservedDBInstancesRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeReservedDBInstances");
            request.Parameters.Add("Version", "2013-01-10");
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetReservedDBInstanceId())
            {
                request.Parameters.Add("ReservedDBInstanceId", StringUtils.FromString(describeReservedDBInstancesRequest.ReservedDBInstanceId));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetReservedDBInstancesOfferingId())
            {
                request.Parameters.Add("ReservedDBInstancesOfferingId", StringUtils.FromString(describeReservedDBInstancesRequest.ReservedDBInstancesOfferingId));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(describeReservedDBInstancesRequest.DBInstanceClass));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetDuration())
            {
                request.Parameters.Add("Duration", StringUtils.FromString(describeReservedDBInstancesRequest.Duration));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetProductDescription())
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(describeReservedDBInstancesRequest.ProductDescription));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetOfferingType())
            {
                request.Parameters.Add("OfferingType", StringUtils.FromString(describeReservedDBInstancesRequest.OfferingType));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(describeReservedDBInstancesRequest.MultiAZ));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeReservedDBInstancesRequest.MaxRecords));
            }
            if (describeReservedDBInstancesRequest != null && describeReservedDBInstancesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeReservedDBInstancesRequest.Marker));
            }

            return request;
        }
    }
}
