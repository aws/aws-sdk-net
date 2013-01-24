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
    /// List Groups Request Marshaller
    /// </summary>       
    public class ListGroupsRequestMarshaller : IMarshaller<IRequest, ListGroupsRequest>
    {
        public IRequest Marshall(ListGroupsRequest listGroupsRequest)
        {
            IRequest request = new DefaultRequest(listGroupsRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "ListGroups");
            request.Parameters.Add("Version", "2010-05-08");
            if (listGroupsRequest != null && listGroupsRequest.IsSetPathPrefix())
            {
                request.Parameters.Add("PathPrefix", StringUtils.FromString(listGroupsRequest.PathPrefix));
            }
            if (listGroupsRequest != null && listGroupsRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(listGroupsRequest.Marker));
            }
            if (listGroupsRequest != null && listGroupsRequest.IsSetMaxItems())
            {
                request.Parameters.Add("MaxItems", StringUtils.FromInt(listGroupsRequest.MaxItems));
            }

            return request;
        }
    }
}
