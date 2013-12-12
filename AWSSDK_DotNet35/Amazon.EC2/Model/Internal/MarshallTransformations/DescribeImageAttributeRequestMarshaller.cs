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
    /// Describe Image Attribute Request Marshaller
    /// </summary>       
    public class DescribeImageAttributeRequestMarshaller : IMarshaller<IRequest, DescribeImageAttributeRequest>
    {
        public IRequest Marshall(DescribeImageAttributeRequest describeImageAttributeRequest)
        {
            IRequest request = new DefaultRequest(describeImageAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeImageAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (describeImageAttributeRequest != null && describeImageAttributeRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(describeImageAttributeRequest.ImageId));
            }
            if (describeImageAttributeRequest != null && describeImageAttributeRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(describeImageAttributeRequest.Attribute));
            }

            return request;
        }
    }
}
