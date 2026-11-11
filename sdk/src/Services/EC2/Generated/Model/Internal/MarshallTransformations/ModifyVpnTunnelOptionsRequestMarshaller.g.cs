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
    /// ModifyVpnTunnelOptions Request Marshaller
    /// </summary>
    public partial class ModifyVpnTunnelOptionsRequestMarshaller : IMarshaller<IRequest, ModifyVpnTunnelOptionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpnTunnelOptionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyVpnTunnelOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyVpnTunnelOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetPreSharedKeyStorage())
            {
                request.Parameters.Add("PreSharedKeyStorage", StringUtils.FromString(publicRequest.PreSharedKeyStorage));
            }
            if (publicRequest.IsSetSkipTunnelReplacement())
            {
                request.Parameters.Add("SkipTunnelReplacement", StringUtils.FromBool(publicRequest.SkipTunnelReplacement.Value));
            }
            if (publicRequest.IsSetTunnelOptions())
            {
                if (publicRequest.TunnelOptions.IsSetDPDTimeoutAction())
                {
                    request.Parameters.Add("TunnelOptions" + ".DPDTimeoutAction", StringUtils.FromString(publicRequest.TunnelOptions.DPDTimeoutAction));
                }
                if (publicRequest.TunnelOptions.IsSetDPDTimeoutSeconds())
                {
                    request.Parameters.Add("TunnelOptions" + ".DPDTimeoutSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.DPDTimeoutSeconds.Value));
                }
                if (publicRequest.TunnelOptions.IsSetEnableTunnelLifecycleControl())
                {
                    request.Parameters.Add("TunnelOptions" + ".EnableTunnelLifecycleControl", StringUtils.FromBool(publicRequest.TunnelOptions.EnableTunnelLifecycleControl.Value));
                }
                if (publicRequest.TunnelOptions.IsSetIKEVersions())
                {
                    if (publicRequest.TunnelOptions.IKEVersions.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".IKEVersion", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.IKEVersions)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".IKEVersion" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetLogOptions())
                {
                    if (publicRequest.TunnelOptions.LogOptions.IsSetCloudWatchLogOptions())
                    {
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetBgpLogEnabled())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogEnabled", StringUtils.FromBool(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.BgpLogEnabled.Value));
                        }
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetBgpLogGroupArn())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogGroupArn", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.BgpLogGroupArn));
                        }
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetBgpLogOutputFormat())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogOutputFormat", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.BgpLogOutputFormat));
                        }
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogEnabled())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".LogEnabled", StringUtils.FromBool(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogEnabled.Value));
                        }
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogGroupArn())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".LogGroupArn", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogGroupArn));
                        }
                        if (publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogOutputFormat())
                        {
                            request.Parameters.Add("TunnelOptions" + ".LogOptions" + ".CloudWatchLogOptions" + ".LogOutputFormat", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogOutputFormat));
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase1DHGroupNumbers())
                {
                    if (publicRequest.TunnelOptions.Phase1DHGroupNumbers.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase1DHGroupNumber", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase1DHGroupNumbers)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase1DHGroupNumber" + "." + index1 + ".Value", StringUtils.FromInt(item1.Value.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase1EncryptionAlgorithms())
                {
                    if (publicRequest.TunnelOptions.Phase1EncryptionAlgorithms.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase1EncryptionAlgorithm", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase1EncryptionAlgorithms)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase1EncryptionAlgorithm" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase1IntegrityAlgorithms())
                {
                    if (publicRequest.TunnelOptions.Phase1IntegrityAlgorithms.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase1IntegrityAlgorithm", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase1IntegrityAlgorithms)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase1IntegrityAlgorithm" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase1LifetimeSeconds())
                {
                    request.Parameters.Add("TunnelOptions" + ".Phase1LifetimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.Phase1LifetimeSeconds.Value));
                }
                if (publicRequest.TunnelOptions.IsSetPhase2DHGroupNumbers())
                {
                    if (publicRequest.TunnelOptions.Phase2DHGroupNumbers.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase2DHGroupNumber", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase2DHGroupNumbers)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase2DHGroupNumber" + "." + index1 + ".Value", StringUtils.FromInt(item1.Value.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase2EncryptionAlgorithms())
                {
                    if (publicRequest.TunnelOptions.Phase2EncryptionAlgorithms.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase2EncryptionAlgorithm", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase2EncryptionAlgorithms)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase2EncryptionAlgorithm" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase2IntegrityAlgorithms())
                {
                    if (publicRequest.TunnelOptions.Phase2IntegrityAlgorithms.Count == 0)
                    {
                        request.Parameters.Add("TunnelOptions" + ".Phase2IntegrityAlgorithm", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TunnelOptions.Phase2IntegrityAlgorithms)
                        {
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + ".Phase2IntegrityAlgorithm" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.TunnelOptions.IsSetPhase2LifetimeSeconds())
                {
                    request.Parameters.Add("TunnelOptions" + ".Phase2LifetimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.Phase2LifetimeSeconds.Value));
                }
                if (publicRequest.TunnelOptions.IsSetPreSharedKey())
                {
                    request.Parameters.Add("TunnelOptions" + ".PreSharedKey", StringUtils.FromString(publicRequest.TunnelOptions.PreSharedKey));
                }
                if (publicRequest.TunnelOptions.IsSetRekeyFuzzPercentage())
                {
                    request.Parameters.Add("TunnelOptions" + ".RekeyFuzzPercentage", StringUtils.FromInt(publicRequest.TunnelOptions.RekeyFuzzPercentage.Value));
                }
                if (publicRequest.TunnelOptions.IsSetRekeyMarginTimeSeconds())
                {
                    request.Parameters.Add("TunnelOptions" + ".RekeyMarginTimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.RekeyMarginTimeSeconds.Value));
                }
                if (publicRequest.TunnelOptions.IsSetReplayWindowSize())
                {
                    request.Parameters.Add("TunnelOptions" + ".ReplayWindowSize", StringUtils.FromInt(publicRequest.TunnelOptions.ReplayWindowSize.Value));
                }
                if (publicRequest.TunnelOptions.IsSetStartupAction())
                {
                    request.Parameters.Add("TunnelOptions" + ".StartupAction", StringUtils.FromString(publicRequest.TunnelOptions.StartupAction));
                }
                if (publicRequest.TunnelOptions.IsSetTunnelInsideCidr())
                {
                    request.Parameters.Add("TunnelOptions" + ".TunnelInsideCidr", StringUtils.FromString(publicRequest.TunnelOptions.TunnelInsideCidr));
                }
                if (publicRequest.TunnelOptions.IsSetTunnelInsideIpv6Cidr())
                {
                    request.Parameters.Add("TunnelOptions" + ".TunnelInsideIpv6Cidr", StringUtils.FromString(publicRequest.TunnelOptions.TunnelInsideIpv6Cidr));
                }
            }
            if (publicRequest.IsSetVpnConnectionId())
            {
                request.Parameters.Add("VpnConnectionId", StringUtils.FromString(publicRequest.VpnConnectionId));
            }
            if (publicRequest.IsSetVpnTunnelOutsideIpAddress())
            {
                request.Parameters.Add("VpnTunnelOutsideIpAddress", StringUtils.FromString(publicRequest.VpnTunnelOutsideIpAddress));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyVpnTunnelOptionsRequestMarshaller _instance = new();

        internal static ModifyVpnTunnelOptionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyVpnTunnelOptionsRequestMarshaller Instance => _instance;
    }
}
