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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Hsm Configuration Request Marshaller
    /// </summary>       
    public class CreateHsmConfigurationRequestMarshaller : IMarshaller<IRequest, CreateHsmConfigurationRequest>
    {
        public IRequest Marshall(CreateHsmConfigurationRequest createHsmConfigurationRequest)
        {
            IRequest request = new DefaultRequest(createHsmConfigurationRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "CreateHsmConfiguration");
            request.Parameters.Add("Version", "2012-12-01");
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetHsmConfigurationIdentifier())
            {
                request.Parameters.Add("HsmConfigurationIdentifier", StringUtils.FromString(createHsmConfigurationRequest.HsmConfigurationIdentifier));
            }
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createHsmConfigurationRequest.Description));
            }
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetHsmIpAddress())
            {
                request.Parameters.Add("HsmIpAddress", StringUtils.FromString(createHsmConfigurationRequest.HsmIpAddress));
            }
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetHsmPartitionName())
            {
                request.Parameters.Add("HsmPartitionName", StringUtils.FromString(createHsmConfigurationRequest.HsmPartitionName));
            }
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetHsmPartitionPassword())
            {
                request.Parameters.Add("HsmPartitionPassword", StringUtils.FromString(createHsmConfigurationRequest.HsmPartitionPassword));
            }
            if (createHsmConfigurationRequest != null && createHsmConfigurationRequest.IsSetHsmServerPublicCertificate())
            {
                request.Parameters.Add("HsmServerPublicCertificate", StringUtils.FromString(createHsmConfigurationRequest.HsmServerPublicCertificate));
            }

            return request;
        }
    }
}
