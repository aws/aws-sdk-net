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
    /// Copy Image Request Marshaller
    /// </summary>       
    public class CopyImageRequestMarshaller : IMarshaller<IRequest, CopyImageRequest>
    {
        public IRequest Marshall(CopyImageRequest copyImageRequest)
        {
            IRequest request = new DefaultRequest(copyImageRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CopyImage");
            request.Parameters.Add("Version", "2014-05-01");
            if (copyImageRequest != null && copyImageRequest.IsSetSourceRegion())
            {
                request.Parameters.Add("SourceRegion", StringUtils.FromString(copyImageRequest.SourceRegion));
            }
            if (copyImageRequest != null && copyImageRequest.IsSetSourceImageId())
            {
                request.Parameters.Add("SourceImageId", StringUtils.FromString(copyImageRequest.SourceImageId));
            }
            if (copyImageRequest != null && copyImageRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(copyImageRequest.Name));
            }
            if (copyImageRequest != null && copyImageRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(copyImageRequest.Description));
            }
            if (copyImageRequest != null && copyImageRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(copyImageRequest.ClientToken));
            }

            return request;
        }
    }
}
