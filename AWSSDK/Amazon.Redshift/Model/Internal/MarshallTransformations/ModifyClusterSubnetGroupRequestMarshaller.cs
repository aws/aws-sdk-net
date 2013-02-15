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
    /// Modify Cluster Subnet Group Request Marshaller
    /// </summary>       
    public class ModifyClusterSubnetGroupRequestMarshaller : IMarshaller<IRequest, ModifyClusterSubnetGroupRequest>
    {
        public IRequest Marshall(ModifyClusterSubnetGroupRequest modifyClusterSubnetGroupRequest)
        {
            IRequest request = new DefaultRequest(modifyClusterSubnetGroupRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "ModifyClusterSubnetGroup");
            request.Parameters.Add("Version", "2012-12-01");
            if (modifyClusterSubnetGroupRequest != null && modifyClusterSubnetGroupRequest.IsSetClusterSubnetGroupName())
            {
                request.Parameters.Add("ClusterSubnetGroupName", StringUtils.FromString(modifyClusterSubnetGroupRequest.ClusterSubnetGroupName));
            }
            if (modifyClusterSubnetGroupRequest != null && modifyClusterSubnetGroupRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(modifyClusterSubnetGroupRequest.Description));
            }
            if (modifyClusterSubnetGroupRequest != null)
            {
                List<string> subnetIdsList = modifyClusterSubnetGroupRequest.SubnetIds;

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
