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

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Availability Options Request Marshaller
    /// </summary>       
    public class UpdateAvailabilityOptionsRequestMarshaller : IMarshaller<IRequest, UpdateAvailabilityOptionsRequest>
    {
        public IRequest Marshall(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest)
        {
            IRequest request = new DefaultRequest(updateAvailabilityOptionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "UpdateAvailabilityOptions");
            request.Parameters.Add("Version", "2013-01-01");
            if (updateAvailabilityOptionsRequest != null && updateAvailabilityOptionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(updateAvailabilityOptionsRequest.DomainName));
            }
            if (updateAvailabilityOptionsRequest != null && updateAvailabilityOptionsRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(updateAvailabilityOptionsRequest.MultiAZ));
            }

            return request;
        }
    }
}
