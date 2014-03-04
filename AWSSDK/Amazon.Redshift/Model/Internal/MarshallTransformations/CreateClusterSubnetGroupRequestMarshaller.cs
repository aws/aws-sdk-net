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
    /// Create Cluster Subnet Group Request Marshaller
    /// </summary>       
    public class CreateClusterSubnetGroupRequestMarshaller : IMarshaller<IRequest, CreateClusterSubnetGroupRequest>
    {
        public IRequest Marshall(CreateClusterSubnetGroupRequest createClusterSubnetGroupRequest)
        {
            IRequest request = new DefaultRequest(createClusterSubnetGroupRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "CreateClusterSubnetGroup");
            request.Parameters.Add("Version", "2012-12-01");
            if (createClusterSubnetGroupRequest != null && createClusterSubnetGroupRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(createClusterSubnetGroupRequest.ClusterSubnetGroupName));
            }
            if (createClusterSubnetGroupRequest != null && createClusterSubnetGroupRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createClusterSubnetGroupRequest.Description));
            }
            if (createClusterSubnetGroupRequest != null)
            {
                List<string> subnetIdsList = createClusterSubnetGroupRequest.SubnetIds;

                int subnetIdsListIndex = 1;
                foreach (string subnetIdsListValue in subnetIdsList)
                { 
                    request.Parameters.Add("SubnetIds.member." + subnetIdsListIndex, StringUtils.FromString(subnetIdsListValue));
                    subnetIdsListIndex++;
                }
            }

            return request;
        }
    }
}
