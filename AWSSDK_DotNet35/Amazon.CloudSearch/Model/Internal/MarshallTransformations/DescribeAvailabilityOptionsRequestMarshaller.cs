/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Availability Options Request Marshaller
    /// </summary>       
    public class DescribeAvailabilityOptionsRequestMarshaller : IMarshaller<IRequest, DescribeAvailabilityOptionsRequest>
    {
        public IRequest Marshall(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest)
        {
            IRequest request = new DefaultRequest(describeAvailabilityOptionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DescribeAvailabilityOptions");
            request.Parameters.Add("Version", "2013-01-01");
            if (describeAvailabilityOptionsRequest != null && describeAvailabilityOptionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(describeAvailabilityOptionsRequest.DomainName));
            }
            if (describeAvailabilityOptionsRequest != null && describeAvailabilityOptionsRequest.IsSetDeployed())
            {
                request.Parameters.Add("Deployed", StringUtils.FromBool(describeAvailabilityOptionsRequest.Deployed));
            }

            return request;
        }
    }
}
