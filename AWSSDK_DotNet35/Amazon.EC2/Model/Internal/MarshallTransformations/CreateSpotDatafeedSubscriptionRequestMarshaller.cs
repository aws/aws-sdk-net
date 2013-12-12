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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Spot Datafeed Subscription Request Marshaller
    /// </summary>       
    public class CreateSpotDatafeedSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateSpotDatafeedSubscriptionRequest>
    {
        public IRequest Marshall(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest)
        {
            IRequest request = new DefaultRequest(createSpotDatafeedSubscriptionRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateSpotDatafeedSubscription");
            request.Parameters.Add("Version", "2013-10-15");
            if (createSpotDatafeedSubscriptionRequest != null && createSpotDatafeedSubscriptionRequest.IsSetBucket())
            {
                request.Parameters.Add("Bucket", StringUtils.FromString(createSpotDatafeedSubscriptionRequest.Bucket));
            }
            if (createSpotDatafeedSubscriptionRequest != null && createSpotDatafeedSubscriptionRequest.IsSetPrefix())
            {
                request.Parameters.Add("Prefix", StringUtils.FromString(createSpotDatafeedSubscriptionRequest.Prefix));
            }

            return request;
        }
    }
}
