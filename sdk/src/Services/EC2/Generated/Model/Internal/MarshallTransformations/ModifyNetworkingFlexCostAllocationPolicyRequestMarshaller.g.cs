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
    /// ModifyNetworkingFlexCostAllocationPolicy Request Marshaller
    /// </summary>
    public partial class ModifyNetworkingFlexCostAllocationPolicyRequestMarshaller : IMarshaller<IRequest, ModifyNetworkingFlexCostAllocationPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyNetworkingFlexCostAllocationPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyNetworkingFlexCostAllocationPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyNetworkingFlexCostAllocationPolicy");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFcaPolicyId())
            {
                request.Parameters.Add("FcaPolicyId", StringUtils.FromString(publicRequest.FcaPolicyId));
            }
            if (publicRequest.IsSetInstanceFcaPolicyDocument())
            {
                if (publicRequest.InstanceFcaPolicyDocument.IsSetCidrRangeSpecifications())
                {
                    if (publicRequest.InstanceFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixes())
                    {
                        if (publicRequest.InstanceFcaPolicyDocument.CidrRangeSpecifications.Prefixes.Count == 0)
                        {
                            request.Parameters.Add("InstanceFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.InstanceFcaPolicyDocument.CidrRangeSpecifications.Prefixes)
                            {
                                if (item2.IsSetCidrLabel())
                                {
                                    request.Parameters.Add("InstanceFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrLabel", StringUtils.FromString(item2.CidrLabel));
                                }
                                if (item2.IsSetCidrRange())
                                {
                                    request.Parameters.Add("InstanceFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrRange", StringUtils.FromString(item2.CidrRange));
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.InstanceFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixesType())
                    {
                        request.Parameters.Add("InstanceFcaPolicyDocument" + ".CidrRangeSpecifications" + ".PrefixesType", StringUtils.FromString(publicRequest.InstanceFcaPolicyDocument.CidrRangeSpecifications.PrefixesType));
                    }
                }
                if (publicRequest.InstanceFcaPolicyDocument.IsSetDimensions())
                {
                    if (publicRequest.InstanceFcaPolicyDocument.Dimensions.Count == 0)
                    {
                        request.Parameters.Add("InstanceFcaPolicyDocument" + ".Dimensions", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceFcaPolicyDocument.Dimensions)
                        {
                            request.Parameters.Add("InstanceFcaPolicyDocument" + ".Dimensions" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.InstanceFcaPolicyDocument.IsSetReportingGranularity())
                {
                    if (publicRequest.InstanceFcaPolicyDocument.ReportingGranularity.Count == 0)
                    {
                        request.Parameters.Add("InstanceFcaPolicyDocument" + ".ReportingGranularity", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.InstanceFcaPolicyDocument.ReportingGranularity)
                        {
                            request.Parameters.Add("InstanceFcaPolicyDocument" + ".ReportingGranularity" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetNatFcaPolicyDocument())
            {
                if (publicRequest.NatFcaPolicyDocument.IsSetCidrRangeSpecifications())
                {
                    if (publicRequest.NatFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixes())
                    {
                        if (publicRequest.NatFcaPolicyDocument.CidrRangeSpecifications.Prefixes.Count == 0)
                        {
                            request.Parameters.Add("NatFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.NatFcaPolicyDocument.CidrRangeSpecifications.Prefixes)
                            {
                                if (item2.IsSetCidrLabel())
                                {
                                    request.Parameters.Add("NatFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrLabel", StringUtils.FromString(item2.CidrLabel));
                                }
                                if (item2.IsSetCidrRange())
                                {
                                    request.Parameters.Add("NatFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrRange", StringUtils.FromString(item2.CidrRange));
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.NatFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixesType())
                    {
                        request.Parameters.Add("NatFcaPolicyDocument" + ".CidrRangeSpecifications" + ".PrefixesType", StringUtils.FromString(publicRequest.NatFcaPolicyDocument.CidrRangeSpecifications.PrefixesType));
                    }
                }
                if (publicRequest.NatFcaPolicyDocument.IsSetDimensions())
                {
                    if (publicRequest.NatFcaPolicyDocument.Dimensions.Count == 0)
                    {
                        request.Parameters.Add("NatFcaPolicyDocument" + ".Dimensions", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.NatFcaPolicyDocument.Dimensions)
                        {
                            request.Parameters.Add("NatFcaPolicyDocument" + ".Dimensions" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.NatFcaPolicyDocument.IsSetReportingGranularity())
                {
                    if (publicRequest.NatFcaPolicyDocument.ReportingGranularity.Count == 0)
                    {
                        request.Parameters.Add("NatFcaPolicyDocument" + ".ReportingGranularity", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.NatFcaPolicyDocument.ReportingGranularity)
                        {
                            request.Parameters.Add("NatFcaPolicyDocument" + ".ReportingGranularity" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetPcxFcaPolicyDocument())
            {
                if (publicRequest.PcxFcaPolicyDocument.IsSetCidrRangeSpecifications())
                {
                    if (publicRequest.PcxFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixes())
                    {
                        if (publicRequest.PcxFcaPolicyDocument.CidrRangeSpecifications.Prefixes.Count == 0)
                        {
                            request.Parameters.Add("PcxFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.PcxFcaPolicyDocument.CidrRangeSpecifications.Prefixes)
                            {
                                if (item2.IsSetCidrLabel())
                                {
                                    request.Parameters.Add("PcxFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrLabel", StringUtils.FromString(item2.CidrLabel));
                                }
                                if (item2.IsSetCidrRange())
                                {
                                    request.Parameters.Add("PcxFcaPolicyDocument" + ".CidrRangeSpecifications" + ".Prefixes" + "." + index2 + ".CidrRange", StringUtils.FromString(item2.CidrRange));
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.PcxFcaPolicyDocument.CidrRangeSpecifications.IsSetPrefixesType())
                    {
                        request.Parameters.Add("PcxFcaPolicyDocument" + ".CidrRangeSpecifications" + ".PrefixesType", StringUtils.FromString(publicRequest.PcxFcaPolicyDocument.CidrRangeSpecifications.PrefixesType));
                    }
                }
                if (publicRequest.PcxFcaPolicyDocument.IsSetDimensions())
                {
                    if (publicRequest.PcxFcaPolicyDocument.Dimensions.Count == 0)
                    {
                        request.Parameters.Add("PcxFcaPolicyDocument" + ".Dimensions", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.PcxFcaPolicyDocument.Dimensions)
                        {
                            request.Parameters.Add("PcxFcaPolicyDocument" + ".Dimensions" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.PcxFcaPolicyDocument.IsSetReportingGranularity())
                {
                    if (publicRequest.PcxFcaPolicyDocument.ReportingGranularity.Count == 0)
                    {
                        request.Parameters.Add("PcxFcaPolicyDocument" + ".ReportingGranularity", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.PcxFcaPolicyDocument.ReportingGranularity)
                        {
                            request.Parameters.Add("PcxFcaPolicyDocument" + ".ReportingGranularity" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetShowBackEnabled())
            {
                request.Parameters.Add("ShowBackEnabled", StringUtils.FromBool(publicRequest.ShowBackEnabled.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyNetworkingFlexCostAllocationPolicyRequestMarshaller _instance = new();

        internal static ModifyNetworkingFlexCostAllocationPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyNetworkingFlexCostAllocationPolicyRequestMarshaller Instance => _instance;
    }
}
