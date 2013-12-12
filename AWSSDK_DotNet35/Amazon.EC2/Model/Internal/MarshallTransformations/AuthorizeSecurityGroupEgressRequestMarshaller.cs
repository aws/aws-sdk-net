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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Authorize Security Group Egress Request Marshaller
    /// </summary>       
    public class AuthorizeSecurityGroupEgressRequestMarshaller : IMarshaller<IRequest, AuthorizeSecurityGroupEgressRequest>
    {
        public IRequest Marshall(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest)
        {
            IRequest request = new DefaultRequest(authorizeSecurityGroupEgressRequest, "AmazonEC2");
            request.Parameters.Add("Action", "AuthorizeSecurityGroupEgress");
            request.Parameters.Add("Version", "2013-10-15");
            if (authorizeSecurityGroupEgressRequest != null && authorizeSecurityGroupEgressRequest.IsSetGroupId())
            {
                request.Parameters.Add("GroupId", StringUtils.FromString(authorizeSecurityGroupEgressRequest.GroupId));
            }

            if (authorizeSecurityGroupEgressRequest != null)
            {
                List<IpPermission> ipPermissionsList = authorizeSecurityGroupEgressRequest.IpPermissions;
                int ipPermissionsListIndex = 1;
                foreach (IpPermission ipPermissionsListValue in ipPermissionsList)
                {
                    if (ipPermissionsListValue != null && ipPermissionsListValue.IsSetIpProtocol())
                    {
                        request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".IpProtocol", StringUtils.FromString(ipPermissionsListValue.IpProtocol));
                    }
                    if (ipPermissionsListValue != null && ipPermissionsListValue.IsSetFromPort())
                    {
                        request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".FromPort", StringUtils.FromInt(ipPermissionsListValue.FromPort));
                    }
                    if (ipPermissionsListValue != null && ipPermissionsListValue.IsSetToPort())
                    {
                        request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".ToPort", StringUtils.FromInt(ipPermissionsListValue.ToPort));
                    }

                    if (ipPermissionsListValue != null)
                    {
                        List<UserIdGroupPair> userIdGroupPairsList = ipPermissionsListValue.UserIdGroupPairs;
                        int userIdGroupPairsListIndex = 1;
                        foreach (UserIdGroupPair userIdGroupPairsListValue in userIdGroupPairsList)
                        {
                            if (userIdGroupPairsListValue != null && userIdGroupPairsListValue.IsSetUserId())
                            {
                                request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".Groups." + userIdGroupPairsListIndex + ".UserId", StringUtils.FromString(userIdGroupPairsListValue.UserId));
                            }
                            if (userIdGroupPairsListValue != null && userIdGroupPairsListValue.IsSetGroupName())
                            {
                                request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".Groups." + userIdGroupPairsListIndex + ".GroupName", StringUtils.FromString(userIdGroupPairsListValue.GroupName));
                            }
                            if (userIdGroupPairsListValue != null && userIdGroupPairsListValue.IsSetGroupId())
                            {
                                request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".Groups." + userIdGroupPairsListIndex + ".GroupId", StringUtils.FromString(userIdGroupPairsListValue.GroupId));
                            }

                            userIdGroupPairsListIndex++;
                        }
                    }
                    if (ipPermissionsListValue != null)
                    {
                        List<string> ipRangesList = ipPermissionsListValue.IpRanges;

                        int ipRangesListIndex = 1;
                        foreach (string ipRangesListValue in ipRangesList)
                        { 
                            request.Parameters.Add("IpPermissions." + ipPermissionsListIndex + ".IpRanges." + ipRangesListIndex + ".CidrIp", StringUtils.FromString(ipRangesListValue));
                            ipRangesListIndex++;
                        }
                    }

                    ipPermissionsListIndex++;
                }
            }

            return request;
        }
    }
}
