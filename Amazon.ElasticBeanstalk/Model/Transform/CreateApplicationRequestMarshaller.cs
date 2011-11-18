/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Create Application Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest<CreateApplicationRequest>, CreateApplicationRequest>
    {
        public IRequest<CreateApplicationRequest> Marshall(CreateApplicationRequest createApplicationRequest)
        {
            IRequest<CreateApplicationRequest> request = new DefaultRequest<CreateApplicationRequest>(createApplicationRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "CreateApplication");
            request.Parameters.Add("Version", "2010-12-01");
            if (createApplicationRequest != null && createApplicationRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(createApplicationRequest.ApplicationName));
            }
            if (createApplicationRequest != null && createApplicationRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createApplicationRequest.Description));
            }

            return request;
        }
    }
}
