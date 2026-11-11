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
    /// CreateVpnConnection Request Marshaller
    /// </summary>
    public partial class CreateVpnConnectionRequestMarshaller : IMarshaller<IRequest, CreateVpnConnectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpnConnectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateVpnConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateVpnConnection");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetCustomerGatewayId())
            {
                request.Parameters.Add("CustomerGatewayId", StringUtils.FromString(publicRequest.CustomerGatewayId));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetOptions())
            {
                if (publicRequest.Options.IsSetEnableAcceleration())
                {
                    request.Parameters.Add("Options" + ".EnableAcceleration", StringUtils.FromBool(publicRequest.Options.EnableAcceleration.Value));
                }
                if (publicRequest.Options.IsSetLocalIpv4NetworkCidr())
                {
                    request.Parameters.Add("Options" + ".LocalIpv4NetworkCidr", StringUtils.FromString(publicRequest.Options.LocalIpv4NetworkCidr));
                }
                if (publicRequest.Options.IsSetLocalIpv6NetworkCidr())
                {
                    request.Parameters.Add("Options" + ".LocalIpv6NetworkCidr", StringUtils.FromString(publicRequest.Options.LocalIpv6NetworkCidr));
                }
                if (publicRequest.Options.IsSetOutsideIpAddressType())
                {
                    request.Parameters.Add("Options" + ".OutsideIpAddressType", StringUtils.FromString(publicRequest.Options.OutsideIpAddressType));
                }
                if (publicRequest.Options.IsSetRemoteIpv4NetworkCidr())
                {
                    request.Parameters.Add("Options" + ".RemoteIpv4NetworkCidr", StringUtils.FromString(publicRequest.Options.RemoteIpv4NetworkCidr));
                }
                if (publicRequest.Options.IsSetRemoteIpv6NetworkCidr())
                {
                    request.Parameters.Add("Options" + ".RemoteIpv6NetworkCidr", StringUtils.FromString(publicRequest.Options.RemoteIpv6NetworkCidr));
                }
                if (publicRequest.Options.IsSetStaticRoutesOnly())
                {
                    request.Parameters.Add("Options" + ".StaticRoutesOnly", StringUtils.FromBool(publicRequest.Options.StaticRoutesOnly.Value));
                }
                if (publicRequest.Options.IsSetTransportTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("Options" + ".TransportTransitGatewayAttachmentId", StringUtils.FromString(publicRequest.Options.TransportTransitGatewayAttachmentId));
                }
                if (publicRequest.Options.IsSetTunnelBandwidth())
                {
                    request.Parameters.Add("Options" + ".TunnelBandwidth", StringUtils.FromString(publicRequest.Options.TunnelBandwidth));
                }
                if (publicRequest.Options.IsSetTunnelInsideIpVersion())
                {
                    request.Parameters.Add("Options" + ".TunnelInsideIpVersion", StringUtils.FromString(publicRequest.Options.TunnelInsideIpVersion));
                }
                if (publicRequest.Options.IsSetTunnelOptions())
                {
                    if (publicRequest.Options.TunnelOptions.Count == 0)
                    {
                        request.Parameters.Add("Options" + ".TunnelOptions", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Options.TunnelOptions)
                        {
                            if (item1.IsSetDPDTimeoutAction())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".DPDTimeoutAction", StringUtils.FromString(item1.DPDTimeoutAction));
                            }
                            if (item1.IsSetDPDTimeoutSeconds())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".DPDTimeoutSeconds", StringUtils.FromInt(item1.DPDTimeoutSeconds.Value));
                            }
                            if (item1.IsSetEnableTunnelLifecycleControl())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".EnableTunnelLifecycleControl", StringUtils.FromBool(item1.EnableTunnelLifecycleControl.Value));
                            }
                            if (item1.IsSetIKEVersions())
                            {
                                if (item1.IKEVersions.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".IKEVersion", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.IKEVersions)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".IKEVersion" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetLogOptions())
                            {
                                if (item1.LogOptions.IsSetCloudWatchLogOptions())
                                {
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetBgpLogEnabled())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogEnabled", StringUtils.FromBool(item1.LogOptions.CloudWatchLogOptions.BgpLogEnabled.Value));
                                    }
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetBgpLogGroupArn())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogGroupArn", StringUtils.FromString(item1.LogOptions.CloudWatchLogOptions.BgpLogGroupArn));
                                    }
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetBgpLogOutputFormat())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".BgpLogOutputFormat", StringUtils.FromString(item1.LogOptions.CloudWatchLogOptions.BgpLogOutputFormat));
                                    }
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetLogEnabled())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".LogEnabled", StringUtils.FromBool(item1.LogOptions.CloudWatchLogOptions.LogEnabled.Value));
                                    }
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetLogGroupArn())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".LogGroupArn", StringUtils.FromString(item1.LogOptions.CloudWatchLogOptions.LogGroupArn));
                                    }
                                    if (item1.LogOptions.CloudWatchLogOptions.IsSetLogOutputFormat())
                                    {
                                        request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".LogOptions" + ".CloudWatchLogOptions" + ".LogOutputFormat", StringUtils.FromString(item1.LogOptions.CloudWatchLogOptions.LogOutputFormat));
                                    }
                                }
                            }
                            if (item1.IsSetPhase1DHGroupNumbers())
                            {
                                if (item1.Phase1DHGroupNumbers.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1DHGroupNumber", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase1DHGroupNumbers)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1DHGroupNumber" + "." + index2 + ".Value", StringUtils.FromInt(item2.Value.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase1EncryptionAlgorithms())
                            {
                                if (item1.Phase1EncryptionAlgorithms.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1EncryptionAlgorithm", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase1EncryptionAlgorithms)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1EncryptionAlgorithm" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase1IntegrityAlgorithms())
                            {
                                if (item1.Phase1IntegrityAlgorithms.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1IntegrityAlgorithm", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase1IntegrityAlgorithms)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1IntegrityAlgorithm" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase1LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase1LifetimeSeconds", StringUtils.FromInt(item1.Phase1LifetimeSeconds.Value));
                            }
                            if (item1.IsSetPhase2DHGroupNumbers())
                            {
                                if (item1.Phase2DHGroupNumbers.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2DHGroupNumber", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase2DHGroupNumbers)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2DHGroupNumber" + "." + index2 + ".Value", StringUtils.FromInt(item2.Value.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase2EncryptionAlgorithms())
                            {
                                if (item1.Phase2EncryptionAlgorithms.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2EncryptionAlgorithm", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase2EncryptionAlgorithms)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2EncryptionAlgorithm" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase2IntegrityAlgorithms())
                            {
                                if (item1.Phase2IntegrityAlgorithms.Count == 0)
                                {
                                    request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2IntegrityAlgorithm", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Phase2IntegrityAlgorithms)
                                    {
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2IntegrityAlgorithm" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item1.IsSetPhase2LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".Phase2LifetimeSeconds", StringUtils.FromInt(item1.Phase2LifetimeSeconds.Value));
                            }
                            if (item1.IsSetPreSharedKey())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".PreSharedKey", StringUtils.FromString(item1.PreSharedKey));
                            }
                            if (item1.IsSetRekeyFuzzPercentage())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".RekeyFuzzPercentage", StringUtils.FromInt(item1.RekeyFuzzPercentage.Value));
                            }
                            if (item1.IsSetRekeyMarginTimeSeconds())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".RekeyMarginTimeSeconds", StringUtils.FromInt(item1.RekeyMarginTimeSeconds.Value));
                            }
                            if (item1.IsSetReplayWindowSize())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".ReplayWindowSize", StringUtils.FromInt(item1.ReplayWindowSize.Value));
                            }
                            if (item1.IsSetStartupAction())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".StartupAction", StringUtils.FromString(item1.StartupAction));
                            }
                            if (item1.IsSetTunnelInsideCidr())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".TunnelInsideCidr", StringUtils.FromString(item1.TunnelInsideCidr));
                            }
                            if (item1.IsSetTunnelInsideIpv6Cidr())
                            {
                                request.Parameters.Add("Options" + ".TunnelOptions" + "." + index1 + ".TunnelInsideIpv6Cidr", StringUtils.FromString(item1.TunnelInsideIpv6Cidr));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetPreSharedKeyStorage())
            {
                request.Parameters.Add("PreSharedKeyStorage", StringUtils.FromString(publicRequest.PreSharedKeyStorage));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTransitGatewayId())
            {
                request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
            }
            if (publicRequest.IsSetType())
            {
                request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
            }
            if (publicRequest.IsSetVpnConcentratorId())
            {
                request.Parameters.Add("VpnConcentratorId", StringUtils.FromString(publicRequest.VpnConcentratorId));
            }
            if (publicRequest.IsSetVpnGatewayId())
            {
                request.Parameters.Add("VpnGatewayId", StringUtils.FromString(publicRequest.VpnGatewayId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateVpnConnectionRequestMarshaller _instance = new();

        internal static CreateVpnConnectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateVpnConnectionRequestMarshaller Instance => _instance;
    }
}
