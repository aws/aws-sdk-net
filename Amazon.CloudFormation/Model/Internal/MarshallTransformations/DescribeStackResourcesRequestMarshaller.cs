/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Stack Resources Request Marshaller
    /// </summary>       
    public class DescribeStackResourcesRequestMarshaller : IMarshaller<IRequest<DescribeStackResourcesRequest>, DescribeStackResourcesRequest>
    {
        public IRequest<DescribeStackResourcesRequest> Marshall(DescribeStackResourcesRequest describeStackResourcesRequest)
        {
            IRequest<DescribeStackResourcesRequest> request = new DefaultRequest<DescribeStackResourcesRequest>(describeStackResourcesRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "DescribeStackResources");
            request.Parameters.Add("Version", "2010-05-15");
            if (describeStackResourcesRequest != null && describeStackResourcesRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(describeStackResourcesRequest.StackName));
            }
            if (describeStackResourcesRequest != null && describeStackResourcesRequest.IsSetLogicalResourceId())
            {
                request.Parameters.Add("LogicalResourceId", StringUtils.FromString(describeStackResourcesRequest.LogicalResourceId));
            }
            if (describeStackResourcesRequest != null && describeStackResourcesRequest.IsSetPhysicalResourceId())
            {
                request.Parameters.Add("PhysicalResourceId", StringUtils.FromString(describeStackResourcesRequest.PhysicalResourceId));
            }

            return request;
        }
    }
}
