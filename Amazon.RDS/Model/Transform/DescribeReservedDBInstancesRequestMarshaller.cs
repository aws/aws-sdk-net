/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    /// Describe Reserved D B Instances Request Marshaller
    /// </summary>       
    public class DescribeReservedDBInstancesRequestMarshaller : IMarshaller<IRequest<DescribeReservedDBInstancesRequest>, DescribeReservedDBInstancesRequest> 
    {

        public IRequest<DescribeReservedDBInstancesRequest> Marshall(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest) 
        {
            IRequest<DescribeReservedDBInstancesRequest> request = new DefaultRequest<DescribeReservedDBInstancesRequest>(describeReservedDBInstancesRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeReservedDBInstances");
            request.Parameters.Add("Version", "2011-04-01");
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
