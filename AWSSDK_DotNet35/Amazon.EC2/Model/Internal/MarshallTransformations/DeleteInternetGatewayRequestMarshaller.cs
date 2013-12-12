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
    /// Delete Internet Gateway Request Marshaller
    /// </summary>       
    public class DeleteInternetGatewayRequestMarshaller : IMarshaller<IRequest, DeleteInternetGatewayRequest>
    {
        public IRequest Marshall(DeleteInternetGatewayRequest deleteInternetGatewayRequest)
        {
            IRequest request = new DefaultRequest(deleteInternetGatewayRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DeleteInternetGateway");
            request.Parameters.Add("Version", "2013-10-15");
            if (deleteInternetGatewayRequest != null && deleteInternetGatewayRequest.IsSetInternetGatewayId())
            {
                request.Parameters.Add("InternetGatewayId", StringUtils.FromString(deleteInternetGatewayRequest.InternetGatewayId));
            }

            return request;
        }
    }
}
