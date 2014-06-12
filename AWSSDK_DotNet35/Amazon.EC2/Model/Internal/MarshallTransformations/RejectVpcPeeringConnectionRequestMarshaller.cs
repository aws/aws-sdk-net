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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Reject Vpc Peering Connection Request Marshaller
    /// </summary>       
    public class RejectVpcPeeringConnectionRequestMarshaller : IMarshaller<IRequest, RejectVpcPeeringConnectionRequest>
    {
        public IRequest Marshall(RejectVpcPeeringConnectionRequest rejectVpcPeeringConnectionRequest)
        {
            IRequest request = new DefaultRequest(rejectVpcPeeringConnectionRequest, "AmazonEC2");
            request.Parameters.Add("Action", "RejectVpcPeeringConnection");
            request.Parameters.Add("Version", "2014-05-01");
            if (rejectVpcPeeringConnectionRequest != null && rejectVpcPeeringConnectionRequest.IsSetVpcPeeringConnectionId())
            {
                request.Parameters.Add("VpcPeeringConnectionId", StringUtils.FromString(rejectVpcPeeringConnectionRequest.VpcPeeringConnectionId));
            }

            return request;
        }
    }
}
