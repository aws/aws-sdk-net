/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifySecurityGroupRules Request Marshaller
    /// </summary>       
    public class ModifySecurityGroupRulesRequestMarshaller : IMarshaller<IRequest, ModifySecurityGroupRulesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySecurityGroupRulesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifySecurityGroupRulesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifySecurityGroupRules");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetGroupId())
                {
                    request.Parameters.Add("GroupId", StringUtils.FromString(publicRequest.GroupId));
                }
                if(publicRequest.IsSetSecurityGroupRules())
                {
                    if (publicRequest.SecurityGroupRules.Count == 0)
                        request.Parameters.Add("SecurityGroupRule", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupRules)
                         {
                            if(publicRequestlistValue.IsSetSecurityGroupRule())
                            {
                                if(publicRequestlistValue.SecurityGroupRule.IsSetCidrIpv4())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "CidrIpv4", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.CidrIpv4));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetCidrIpv6())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "CidrIpv6", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.CidrIpv6));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetDescription())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "Description", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.Description));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetFromPort())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "FromPort", StringUtils.FromInt(publicRequestlistValue.SecurityGroupRule.FromPort));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetIpProtocol())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "IpProtocol", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.IpProtocol));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetPrefixListId())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "PrefixListId", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.PrefixListId));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetReferencedGroupId())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "ReferencedGroupId", StringUtils.FromString(publicRequestlistValue.SecurityGroupRule.ReferencedGroupId));
                                }
                                if(publicRequestlistValue.SecurityGroupRule.IsSetToPort())
                                {
                                    request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRule" + "." + "ToPort", StringUtils.FromInt(publicRequestlistValue.SecurityGroupRule.ToPort));
                                }
                            }
                            if(publicRequestlistValue.IsSetSecurityGroupRuleId())
                            {
                                request.Parameters.Add("SecurityGroupRule" + "." + publicRequestlistValueIndex + "." + "SecurityGroupRuleId", StringUtils.FromString(publicRequestlistValue.SecurityGroupRuleId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifySecurityGroupRulesRequestMarshaller _instance = new ModifySecurityGroupRulesRequestMarshaller();        

        internal static ModifySecurityGroupRulesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySecurityGroupRulesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}