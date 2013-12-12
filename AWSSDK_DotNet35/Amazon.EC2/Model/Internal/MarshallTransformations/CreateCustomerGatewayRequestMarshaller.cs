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
    /// Create Customer Gateway Request Marshaller
    /// </summary>       
    public class CreateCustomerGatewayRequestMarshaller : IMarshaller<IRequest, CreateCustomerGatewayRequest>
    {
        public IRequest Marshall(CreateCustomerGatewayRequest createCustomerGatewayRequest)
        {
            IRequest request = new DefaultRequest(createCustomerGatewayRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateCustomerGateway");
            request.Parameters.Add("Version", "2013-10-15");
            if (createCustomerGatewayRequest != null && createCustomerGatewayRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(createCustomerGatewayRequest.Type));
            }
            if (createCustomerGatewayRequest != null && createCustomerGatewayRequest.IsSetPublicIp())
            {
                request.Parameters.Add("IpAddress", StringUtils.FromString(createCustomerGatewayRequest.PublicIp));
            }
            if (createCustomerGatewayRequest != null && createCustomerGatewayRequest.IsSetBgpAsn())
            {
                request.Parameters.Add("BgpAsn", StringUtils.FromInt(createCustomerGatewayRequest.BgpAsn));
            }

            return request;
        }
    }
}
