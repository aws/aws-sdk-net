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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Application Request Marshaller
    /// </summary>       
    public class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest>
    {
        public IRequest Marshall(UpdateApplicationRequest updateApplicationRequest)
        {
            IRequest request = new DefaultRequest(updateApplicationRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "UpdateApplication");
            request.Parameters.Add("Version", "2010-12-01");
            if (updateApplicationRequest != null && updateApplicationRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(updateApplicationRequest.ApplicationName));
            }
            if (updateApplicationRequest != null && updateApplicationRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(updateApplicationRequest.Description));
            }

            return request;
        }
    }
}
