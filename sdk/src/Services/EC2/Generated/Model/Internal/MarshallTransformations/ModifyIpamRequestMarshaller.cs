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
    /// ModifyIpam Request Marshaller
    /// </summary>       
    public class ModifyIpamRequestMarshaller : IMarshaller<IRequest, ModifyIpamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyIpamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyIpam");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddOperatingRegions())
                {
                    if (publicRequest.AddOperatingRegions.Count == 0)
                        request.Parameters.Add("AddOperatingRegion", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddOperatingRegions)
                         {
                            if(publicRequestlistValue.IsSetRegionName())
                            {
                                request.Parameters.Add("AddOperatingRegion" + "." + publicRequestlistValueIndex + "." + "RegionName", StringUtils.FromString(publicRequestlistValue.RegionName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEnablePrivateGua())
                {
                    request.Parameters.Add("EnablePrivateGua", StringUtils.FromBool(publicRequest.EnablePrivateGua));
                }
                if(publicRequest.IsSetIpamId())
                {
                    request.Parameters.Add("IpamId", StringUtils.FromString(publicRequest.IpamId));
                }
                if(publicRequest.IsSetMeteredAccount())
                {
                    request.Parameters.Add("MeteredAccount", StringUtils.FromString(publicRequest.MeteredAccount));
                }
                if(publicRequest.IsSetRemoveOperatingRegions())
                {
                    if (publicRequest.RemoveOperatingRegions.Count == 0)
                        request.Parameters.Add("RemoveOperatingRegion", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveOperatingRegions)
                         {
                            if(publicRequestlistValue.IsSetRegionName())
                            {
                                request.Parameters.Add("RemoveOperatingRegion" + "." + publicRequestlistValueIndex + "." + "RegionName", StringUtils.FromString(publicRequestlistValue.RegionName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTier())
                {
                    request.Parameters.Add("Tier", StringUtils.FromString(publicRequest.Tier));
                }
            }
            return request;
        }
                    private static ModifyIpamRequestMarshaller _instance = new ModifyIpamRequestMarshaller();        

        internal static ModifyIpamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyIpamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}