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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Instance Profiles Request Marshaller
    /// </summary>       
    public class ListInstanceProfilesRequestMarshaller : IMarshaller<IRequest, ListInstanceProfilesRequest>
    {
        public IRequest Marshall(ListInstanceProfilesRequest listInstanceProfilesRequest)
        {
            IRequest request = new DefaultRequest(listInstanceProfilesRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "ListInstanceProfiles");
            request.Parameters.Add("Version", "2010-05-08");
            if (listInstanceProfilesRequest != null && listInstanceProfilesRequest.IsSetPathPrefix())
            {
                request.Parameters.Add("PathPrefix", StringUtils.FromString(listInstanceProfilesRequest.PathPrefix));
            }
            if (listInstanceProfilesRequest != null && listInstanceProfilesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(listInstanceProfilesRequest.Marker));
            }
            if (listInstanceProfilesRequest != null && listInstanceProfilesRequest.IsSetMaxItems())
            {
                request.Parameters.Add("MaxItems", StringUtils.FromInt(listInstanceProfilesRequest.MaxItems));
            }

            return request;
        }
    }
}
