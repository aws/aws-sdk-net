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

/*
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AllocateHosts Request Marshaller
    /// </summary>       
    public class AllocateHostsRequestMarshaller : IMarshaller<IRequest, AllocateHostsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AllocateHostsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AllocateHostsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AllocateHosts");
            request.Parameters.Add("Version", "2016-09-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoPlacement())
                {
                    request.Parameters.Add("AutoPlacement", StringUtils.FromString(publicRequest.AutoPlacement));
                }
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetQuantity())
                {
                    request.Parameters.Add("Quantity", StringUtils.FromInt(publicRequest.Quantity));
                }
            }
            return request;
        }
    }
}