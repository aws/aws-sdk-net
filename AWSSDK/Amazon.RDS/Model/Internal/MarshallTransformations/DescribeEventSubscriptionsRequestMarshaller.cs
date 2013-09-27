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
    /// Describe Event Subscriptions Request Marshaller
    /// </summary>       
    public class DescribeEventSubscriptionsRequestMarshaller : IMarshaller<IRequest, DescribeEventSubscriptionsRequest>
    {
        public IRequest Marshall(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest)
        {
            IRequest request = new DefaultRequest(describeEventSubscriptionsRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeEventSubscriptions");
            request.Parameters.Add("Version", "2013-05-15");
            if (describeEventSubscriptionsRequest != null && describeEventSubscriptionsRequest.IsSetSubscriptionName())
            {
                request.Parameters.Add("SubscriptionName", StringUtils.FromString(describeEventSubscriptionsRequest.SubscriptionName));
            }
            if (describeEventSubscriptionsRequest != null && describeEventSubscriptionsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeEventSubscriptionsRequest.MaxRecords));
            }
            if (describeEventSubscriptionsRequest != null && describeEventSubscriptionsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeEventSubscriptionsRequest.Marker));
            }

            return request;
        }
    }
}
