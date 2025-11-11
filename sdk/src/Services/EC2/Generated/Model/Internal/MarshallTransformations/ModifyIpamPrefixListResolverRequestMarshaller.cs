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
    /// ModifyIpamPrefixListResolver Request Marshaller
    /// </summary>       
    public class ModifyIpamPrefixListResolverRequestMarshaller : IMarshaller<IRequest, ModifyIpamPrefixListResolverRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamPrefixListResolverRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyIpamPrefixListResolverRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyIpamPrefixListResolver");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetIpamPrefixListResolverId())
                {
                    request.Parameters.Add("IpamPrefixListResolverId", StringUtils.FromString(publicRequest.IpamPrefixListResolverId));
                }
                if(publicRequest.IsSetRules())
                {
                    if (publicRequest.Rules.Count == 0)
                        request.Parameters.Add("Rule", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Rules)
                         {
                            if(publicRequestlistValue.IsSetConditions())
                            {
                                if (publicRequestlistValue.Conditions.Count == 0)
                                    request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Conditions)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetCidr())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "Cidr", StringUtils.FromString(publicRequestlistValuelistValue.Cidr));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetIpamPoolId())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "IpamPoolId", StringUtils.FromString(publicRequestlistValuelistValue.IpamPoolId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetOperation())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "Operation", StringUtils.FromString(publicRequestlistValuelistValue.Operation));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetResourceId())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceId", StringUtils.FromString(publicRequestlistValuelistValue.ResourceId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetResourceOwner())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceOwner", StringUtils.FromString(publicRequestlistValuelistValue.ResourceOwner));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetResourceRegion())
                                        {
                                            request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceRegion", StringUtils.FromString(publicRequestlistValuelistValue.ResourceRegion));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetResourceTag())
                                        {
                                            if(publicRequestlistValuelistValue.ResourceTag.IsSetKey())
                                            {
                                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceTag" + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.ResourceTag.Key));
                                            }
                                            if(publicRequestlistValuelistValue.ResourceTag.IsSetValue())
                                            {
                                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "Condition" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceTag" + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.ResourceTag.Value));
                                            }
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetIpamScopeId())
                            {
                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "IpamScopeId", StringUtils.FromString(publicRequestlistValue.IpamScopeId));
                            }
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetRuleType())
                            {
                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "RuleType", StringUtils.FromString(publicRequestlistValue.RuleType));
                            }
                            if(publicRequestlistValue.IsSetStaticCidr())
                            {
                                request.Parameters.Add("Rule" + "." + publicRequestlistValueIndex + "." + "StaticCidr", StringUtils.FromString(publicRequestlistValue.StaticCidr));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyIpamPrefixListResolverRequestMarshaller _instance = new ModifyIpamPrefixListResolverRequestMarshaller();        

        internal static ModifyIpamPrefixListResolverRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyIpamPrefixListResolverRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}