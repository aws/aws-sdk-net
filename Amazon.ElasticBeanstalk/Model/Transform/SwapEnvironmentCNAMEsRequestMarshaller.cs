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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Transform
{
    /// <summary>
    /// Swap Environment C N A M Es Request Marshaller
    /// </summary>       
    public class SwapEnvironmentCNAMEsRequestMarshaller : IMarshaller<IRequest<SwapEnvironmentCNAMEsRequest>, SwapEnvironmentCNAMEsRequest>
    {
        public IRequest<SwapEnvironmentCNAMEsRequest> Marshall(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest)
        {
            IRequest<SwapEnvironmentCNAMEsRequest> request = new DefaultRequest<SwapEnvironmentCNAMEsRequest>(swapEnvironmentCNAMEsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "SwapEnvironmentCNAMEs");
            request.Parameters.Add("Version", "2010-12-01");
            if (swapEnvironmentCNAMEsRequest != null && swapEnvironmentCNAMEsRequest.IsSetSourceEnvironmentId())
            {
                request.Parameters.Add("SourceEnvironmentId", StringUtils.FromString(swapEnvironmentCNAMEsRequest.SourceEnvironmentId));
            }
            if (swapEnvironmentCNAMEsRequest != null && swapEnvironmentCNAMEsRequest.IsSetSourceEnvironmentName())
            {
                request.Parameters.Add("SourceEnvironmentName", StringUtils.FromString(swapEnvironmentCNAMEsRequest.SourceEnvironmentName));
            }
            if (swapEnvironmentCNAMEsRequest != null && swapEnvironmentCNAMEsRequest.IsSetDestinationEnvironmentId())
            {
                request.Parameters.Add("DestinationEnvironmentId", StringUtils.FromString(swapEnvironmentCNAMEsRequest.DestinationEnvironmentId));
            }
            if (swapEnvironmentCNAMEsRequest != null && swapEnvironmentCNAMEsRequest.IsSetDestinationEnvironmentName())
            {
                request.Parameters.Add("DestinationEnvironmentName", StringUtils.FromString(swapEnvironmentCNAMEsRequest.DestinationEnvironmentName));
            }

            return request;
        }
    }
}
