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
    /// Describe Network Interface Attribute Request Marshaller
    /// </summary>       
    public class DescribeNetworkInterfaceAttributeRequestMarshaller : IMarshaller<IRequest, DescribeNetworkInterfaceAttributeRequest>
    {
        public IRequest Marshall(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest)
        {
            IRequest request = new DefaultRequest(describeNetworkInterfaceAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeNetworkInterfaceAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (describeNetworkInterfaceAttributeRequest != null && describeNetworkInterfaceAttributeRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(describeNetworkInterfaceAttributeRequest.NetworkInterfaceId));
            }
            if (describeNetworkInterfaceAttributeRequest != null && describeNetworkInterfaceAttributeRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(describeNetworkInterfaceAttributeRequest.Description));
            }
            if (describeNetworkInterfaceAttributeRequest != null && describeNetworkInterfaceAttributeRequest.IsSetSourceDestCheck())
            {
                request.Parameters.Add("SourceDestCheck", StringUtils.FromString(describeNetworkInterfaceAttributeRequest.SourceDestCheck));
            }
            if (describeNetworkInterfaceAttributeRequest != null && describeNetworkInterfaceAttributeRequest.IsSetGroups())
            {
                request.Parameters.Add("GroupSet", StringUtils.FromString(describeNetworkInterfaceAttributeRequest.Groups));
            }
            if (describeNetworkInterfaceAttributeRequest != null && describeNetworkInterfaceAttributeRequest.IsSetAttachment())
            {
                request.Parameters.Add("Attachment", StringUtils.FromString(describeNetworkInterfaceAttributeRequest.Attachment));
            }

            return request;
        }
    }
}
