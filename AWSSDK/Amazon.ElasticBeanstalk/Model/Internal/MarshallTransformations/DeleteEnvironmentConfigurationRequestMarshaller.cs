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
    /// Delete Environment Configuration Request Marshaller
    /// </summary>       
    public class DeleteEnvironmentConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteEnvironmentConfigurationRequest>
    {
        public IRequest Marshall(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest)
        {
            IRequest request = new DefaultRequest(deleteEnvironmentConfigurationRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "DeleteEnvironmentConfiguration");
            request.Parameters.Add("Version", "2010-12-01");
            if (deleteEnvironmentConfigurationRequest != null && deleteEnvironmentConfigurationRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(deleteEnvironmentConfigurationRequest.ApplicationName));
            }
            if (deleteEnvironmentConfigurationRequest != null && deleteEnvironmentConfigurationRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(deleteEnvironmentConfigurationRequest.EnvironmentName));
            }

            return request;
        }
    }
}
