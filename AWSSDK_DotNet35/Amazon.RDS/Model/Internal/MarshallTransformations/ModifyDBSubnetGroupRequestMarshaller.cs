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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify D B Subnet Group Request Marshaller
    /// </summary>       
    public class ModifyDBSubnetGroupRequestMarshaller : IMarshaller<IRequest, ModifyDBSubnetGroupRequest>
    {
        public IRequest Marshall(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest)
        {
            IRequest request = new DefaultRequest(modifyDBSubnetGroupRequest, "AmazonRDS");
            request.Parameters.Add("Action", "ModifyDBSubnetGroup");
            request.Parameters.Add("Version", "2013-05-15");
            if (modifyDBSubnetGroupRequest != null && modifyDBSubnetGroupRequest.IsSetDBSubnetGroupName())
            {
                request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(modifyDBSubnetGroupRequest.DBSubnetGroupName));
            }
            if (modifyDBSubnetGroupRequest != null && modifyDBSubnetGroupRequest.IsSetDBSubnetGroupDescription())
            {
                request.Parameters.Add("DBSubnetGroupDescription", StringUtils.FromString(modifyDBSubnetGroupRequest.DBSubnetGroupDescription));
            }
            if (modifyDBSubnetGroupRequest != null)
            {
                List<string> subnetIdsList = modifyDBSubnetGroupRequest.SubnetIds;

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
