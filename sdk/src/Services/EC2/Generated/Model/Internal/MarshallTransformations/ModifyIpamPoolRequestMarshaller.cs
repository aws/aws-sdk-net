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
    /// ModifyIpamPool Request Marshaller
    /// </summary>       
    public class ModifyIpamPoolRequestMarshaller : IMarshaller<IRequest, ModifyIpamPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamPoolRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyIpamPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyIpamPool");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddAllocationResourceTags())
                {
                    if (publicRequest.AddAllocationResourceTags.Count == 0)
                        request.Parameters.Add("AddAllocationResourceTag", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddAllocationResourceTags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("AddAllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("AddAllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAllocationDefaultNetmaskLength())
                {
                    request.Parameters.Add("AllocationDefaultNetmaskLength", StringUtils.FromInt(publicRequest.AllocationDefaultNetmaskLength));
                }
                if(publicRequest.IsSetAllocationMaxNetmaskLength())
                {
                    request.Parameters.Add("AllocationMaxNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMaxNetmaskLength));
                }
                if(publicRequest.IsSetAllocationMinNetmaskLength())
                {
                    request.Parameters.Add("AllocationMinNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMinNetmaskLength));
                }
                if(publicRequest.IsSetAutoImport())
                {
                    request.Parameters.Add("AutoImport", StringUtils.FromBool(publicRequest.AutoImport));
                }
                if(publicRequest.IsSetClearAllocationDefaultNetmaskLength())
                {
                    request.Parameters.Add("ClearAllocationDefaultNetmaskLength", StringUtils.FromBool(publicRequest.ClearAllocationDefaultNetmaskLength));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetIpamPoolId())
                {
                    request.Parameters.Add("IpamPoolId", StringUtils.FromString(publicRequest.IpamPoolId));
                }
                if(publicRequest.IsSetRemoveAllocationResourceTags())
                {
                    if (publicRequest.RemoveAllocationResourceTags.Count == 0)
                        request.Parameters.Add("RemoveAllocationResourceTag", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveAllocationResourceTags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("RemoveAllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("RemoveAllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyIpamPoolRequestMarshaller _instance = new ModifyIpamPoolRequestMarshaller();        

        internal static ModifyIpamPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyIpamPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}