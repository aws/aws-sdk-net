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
    /// Modify Vpc Attribute Request Marshaller
    /// </summary>       
    public class ModifyVpcAttributeRequestMarshaller : IMarshaller<IRequest, ModifyVpcAttributeRequest>
    {
        public IRequest Marshall(ModifyVpcAttributeRequest modifyVpcAttributeRequest)
        {
            IRequest request = new DefaultRequest(modifyVpcAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifyVpcAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifyVpcAttributeRequest != null && modifyVpcAttributeRequest.IsSetVpcId())
            {
                request.Parameters.Add("VpcId", StringUtils.FromString(modifyVpcAttributeRequest.VpcId));
            }
            if (modifyVpcAttributeRequest != null && modifyVpcAttributeRequest.IsSetEnableDnsSupport())
            {
                request.Parameters.Add("EnableDnsSupport.Value", StringUtils.FromBool(modifyVpcAttributeRequest.EnableDnsSupport));
            }
            if (modifyVpcAttributeRequest != null && modifyVpcAttributeRequest.IsSetEnableDnsHostnames())
            {
                request.Parameters.Add("EnableDnsHostnames.Value", StringUtils.FromBool(modifyVpcAttributeRequest.EnableDnsHostnames));
            }

            return request;
        }
    }
}
