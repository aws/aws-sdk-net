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
    /// Modify Option Group Request Marshaller
    /// </summary>       
    public class ModifyOptionGroupRequestMarshaller : IMarshaller<IRequest, ModifyOptionGroupRequest>
    {
        public IRequest Marshall(ModifyOptionGroupRequest modifyOptionGroupRequest)
        {
            IRequest request = new DefaultRequest(modifyOptionGroupRequest, "AmazonRDS");
            request.Parameters.Add("Action", "ModifyOptionGroup");
            request.Parameters.Add("Version", "2013-01-10");
            if (modifyOptionGroupRequest != null && modifyOptionGroupRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(modifyOptionGroupRequest.OptionGroupName));
            }

            if (modifyOptionGroupRequest != null)
            {
                List<OptionConfiguration> optionsToIncludeList = modifyOptionGroupRequest.OptionsToInclude;
                int optionsToIncludeListIndex = 1;
                foreach (OptionConfiguration optionsToIncludeListValue in optionsToIncludeList)
                {
                    if (optionsToIncludeListValue != null && optionsToIncludeListValue.IsSetOptionName())
                    {
                        request.Parameters.Add("OptionsToInclude.member." + optionsToIncludeListIndex + ".OptionName", StringUtils.FromString(optionsToIncludeListValue.OptionName));
                    }
                    if (optionsToIncludeListValue != null && optionsToIncludeListValue.IsSetPort())
                    {
                        request.Parameters.Add("OptionsToInclude.member." + optionsToIncludeListIndex + ".Port", StringUtils.FromInt(optionsToIncludeListValue.Port));
                    }
                    if (optionsToIncludeListValue != null)
                    {
                        List<string> dBSecurityGroupMembershipsList = optionsToIncludeListValue.DBSecurityGroupMemberships;

                        int dBSecurityGroupMembershipsListIndex = 1;
                        foreach (string dBSecurityGroupMembershipsListValue in dBSecurityGroupMembershipsList)
                        { 
                            request.Parameters.Add("OptionsToInclude.member." + optionsToIncludeListIndex + ".DBSecurityGroupMemberships.member." + dBSecurityGroupMembershipsListIndex, StringUtils.FromString(dBSecurityGroupMembershipsListValue));
                            dBSecurityGroupMembershipsListIndex++;
                        }
                    }
                    if (optionsToIncludeListValue != null)
                    {
                        List<string> vpcSecurityGroupMembershipsList = optionsToIncludeListValue.VpcSecurityGroupMemberships;

                        int vpcSecurityGroupMembershipsListIndex = 1;
                        foreach (string vpcSecurityGroupMembershipsListValue in vpcSecurityGroupMembershipsList)
                        { 
                            request.Parameters.Add("OptionsToInclude.member." + optionsToIncludeListIndex + ".VpcSecurityGroupMemberships.member." + vpcSecurityGroupMembershipsListIndex, StringUtils.FromString(vpcSecurityGroupMembershipsListValue));
                            vpcSecurityGroupMembershipsListIndex++;
                        }
                    }

                    optionsToIncludeListIndex++;
                }
            }
            if (modifyOptionGroupRequest != null)
            {
                List<string> optionsToRemoveList = modifyOptionGroupRequest.OptionsToRemove;

                int optionsToRemoveListIndex = 1;
                foreach (string optionsToRemoveListValue in optionsToRemoveList)
                { 
                    request.Parameters.Add("OptionsToRemove.member." + optionsToRemoveListIndex, StringUtils.FromString(optionsToRemoveListValue));
                    optionsToRemoveListIndex++;
                }
            }
            if (modifyOptionGroupRequest != null && modifyOptionGroupRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(modifyOptionGroupRequest.ApplyImmediately));
            }

            return request;
        }
    }
}
