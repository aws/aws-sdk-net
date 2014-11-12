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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevokeSecurityGroupEgress Request Marshaller
    /// </summary>       
    public class RevokeSecurityGroupEgressRequestMarshaller : IMarshaller<IRequest, RevokeSecurityGroupEgressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokeSecurityGroupEgressRequest)input);
        }
    
        public IRequest Marshall(RevokeSecurityGroupEgressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RevokeSecurityGroupEgress");
            request.Parameters.Add("Version", "2014-10-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetGroupId())
                {
                    request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
                }
                if(publicRequest.IsSetIpPermissions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.IpPermissions)
                    {
                        if(publicRequestlistValue.IsSetFromPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "FromPort", StringUtils.FromInt(publicRequestlistValue.FromPort));
                        }
                        if(publicRequestlistValue.IsSetIpProtocol())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpProtocol", StringUtils.FromString(publicRequestlistValue.IpProtocol));
                        }
                        if(publicRequestlistValue.IsSetIpRanges())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.IpRanges)
                            {
                                request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "IpRanges" + "." + publicRequestlistValuelistValueIndex + "." + "CidrIp", StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetToPort())
                        {
                            request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "ToPort", StringUtils.FromInt(publicRequestlistValue.ToPort));
                        }
                        if(publicRequestlistValue.IsSetUserIdGroupPairs())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.UserIdGroupPairs)
                            {
                                if(publicRequestlistValuelistValue.IsSetGroupId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupId", StringUtils.FromString(publicRequestlistValuelistValue.GroupId));
                                }
                                if(publicRequestlistValuelistValue.IsSetGroupName())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.GroupName));
                                }
                                if(publicRequestlistValuelistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("IpPermissions" + "." + publicRequestlistValueIndex + "." + "Groups" + "." + publicRequestlistValuelistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestlistValuelistValue.UserId));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}