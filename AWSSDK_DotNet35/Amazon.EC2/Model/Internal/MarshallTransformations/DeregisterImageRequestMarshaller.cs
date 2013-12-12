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
    /// Deregister Image Request Marshaller
    /// </summary>       
    public class DeregisterImageRequestMarshaller : IMarshaller<IRequest, DeregisterImageRequest>
    {
        public IRequest Marshall(DeregisterImageRequest deregisterImageRequest)
        {
            IRequest request = new DefaultRequest(deregisterImageRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DeregisterImage");
            request.Parameters.Add("Version", "2013-10-15");
            if (deregisterImageRequest != null && deregisterImageRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(deregisterImageRequest.ImageId));
            }

            return request;
        }
    }
}
