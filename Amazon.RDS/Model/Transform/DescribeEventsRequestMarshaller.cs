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
    /// Describe Events Request Marshaller
    /// </summary>       
    public class DescribeEventsRequestMarshaller : IMarshaller<IRequest<DescribeEventsRequest>, DescribeEventsRequest> 
    {

        public IRequest<DescribeEventsRequest> Marshall(DescribeEventsRequest describeEventsRequest) 
        {
            IRequest<DescribeEventsRequest> request = new DefaultRequest<DescribeEventsRequest>(describeEventsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeEvents");
            request.Parameters.Add("Version", "2010-07-28");
            if (describeEventsRequest != null && describeEventsRequest.IsSetSourceIdentifier()) 
            {
                request.Parameters.Add("SourceIdentifier", StringUtils.FromString(describeEventsRequest.SourceIdentifier));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetSourceType()) 
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(describeEventsRequest.SourceType));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetStartTime()) 
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(describeEventsRequest.StartTime));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetEndTime()) 
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(describeEventsRequest.EndTime));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetDuration()) 
            {
                request.Parameters.Add("Duration", StringUtils.FromInt(describeEventsRequest.Duration));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetMaxRecords()) 
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeEventsRequest.MaxRecords));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetMarker()) 
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeEventsRequest.Marker));
            }


            return request;
        }
    }
}
