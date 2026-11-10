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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyIpamPool Request Marshaller
    /// </summary>
    public partial class ModifyIpamPoolRequestMarshaller : IMarshaller<IRequest, ModifyIpamPoolRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamPoolRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyIpamPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyIpamPool");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAddAllocationResourceTags())
            {
                if (publicRequest.AddAllocationResourceTags.Count == 0)
                {
                    request.Parameters.Add("AddAllocationResourceTag", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddAllocationResourceTags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("AddAllocationResourceTag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("AddAllocationResourceTag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAllocationDefaultNetmaskLength())
            {
                request.Parameters.Add("AllocationDefaultNetmaskLength", StringUtils.FromInt(publicRequest.AllocationDefaultNetmaskLength.Value));
            }
            if (publicRequest.IsSetAllocationMaxNetmaskLength())
            {
                request.Parameters.Add("AllocationMaxNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMaxNetmaskLength.Value));
            }
            if (publicRequest.IsSetAllocationMinNetmaskLength())
            {
                request.Parameters.Add("AllocationMinNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMinNetmaskLength.Value));
            }
            if (publicRequest.IsSetAutoImport())
            {
                request.Parameters.Add("AutoImport", StringUtils.FromBool(publicRequest.AutoImport.Value));
            }
            if (publicRequest.IsSetClearAllocationDefaultNetmaskLength())
            {
                request.Parameters.Add("ClearAllocationDefaultNetmaskLength", StringUtils.FromBool(publicRequest.ClearAllocationDefaultNetmaskLength.Value));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetIpamPoolId())
            {
                request.Parameters.Add("IpamPoolId", StringUtils.FromString(publicRequest.IpamPoolId));
            }
            if (publicRequest.IsSetRemoveAllocationResourceTags())
            {
                if (publicRequest.RemoveAllocationResourceTags.Count == 0)
                {
                    request.Parameters.Add("RemoveAllocationResourceTag", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveAllocationResourceTags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("RemoveAllocationResourceTag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("RemoveAllocationResourceTag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyIpamPoolRequestMarshaller _instance = new();

        internal static ModifyIpamPoolRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyIpamPoolRequestMarshaller Instance => _instance;
    }
}
