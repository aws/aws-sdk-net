/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Describe Reserved D B Instances Offerings Request Marshaller
    /// </summary>       
    public class DescribeReservedDBInstancesOfferingsRequestMarshaller : IMarshaller<IRequest<DescribeReservedDBInstancesOfferingsRequest>, DescribeReservedDBInstancesOfferingsRequest> 
    {

        public IRequest<DescribeReservedDBInstancesOfferingsRequest> Marshall(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest) 
        {
            IRequest<DescribeReservedDBInstancesOfferingsRequest> request = new DefaultRequest<DescribeReservedDBInstancesOfferingsRequest>(describeReservedDBInstancesOfferingsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeReservedDBInstancesOfferings");
            request.Parameters.Add("Version", "2010-07-28");
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetReservedDBInstancesOfferingId()) 
            {
                request.Parameters.Add("ReservedDBInstancesOfferingId", StringUtils.FromString(describeReservedDBInstancesOfferingsRequest.ReservedDBInstancesOfferingId));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetDBInstanceClass()) 
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(describeReservedDBInstancesOfferingsRequest.DBInstanceClass));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetDuration()) 
            {
                request.Parameters.Add("Duration", StringUtils.FromString(describeReservedDBInstancesOfferingsRequest.Duration));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetProductDescription()) 
            {
                request.Parameters.Add("ProductDescription", StringUtils.FromString(describeReservedDBInstancesOfferingsRequest.ProductDescription));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetMultiAZ()) 
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(describeReservedDBInstancesOfferingsRequest.MultiAZ));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeReservedDBInstancesOfferingsRequest.MaxRecords));
            }
            if (describeReservedDBInstancesOfferingsRequest != null && describeReservedDBInstancesOfferingsRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeReservedDBInstancesOfferingsRequest.Marker));
            }


            return request;
        }
    }
}
