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
    /// CreateClientVpnEndpoint Request Marshaller
    /// </summary>
    public partial class CreateClientVpnEndpointRequestMarshaller : IMarshaller<IRequest, CreateClientVpnEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClientVpnEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateClientVpnEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateClientVpnEndpoint");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAuthenticationOptions())
            {
                if (publicRequest.AuthenticationOptions.Count == 0)
                {
                    request.Parameters.Add("Authentication", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AuthenticationOptions)
                    {
                        if (item0.IsSetActiveDirectory())
                        {
                            if (item0.ActiveDirectory.IsSetDirectoryId())
                            {
                                request.Parameters.Add("Authentication" + "." + index0 + ".ActiveDirectory" + ".DirectoryId", StringUtils.FromString(item0.ActiveDirectory.DirectoryId));
                            }
                        }
                        if (item0.IsSetFederatedAuthentication())
                        {
                            if (item0.FederatedAuthentication.IsSetSAMLProviderArn())
                            {
                                request.Parameters.Add("Authentication" + "." + index0 + ".FederatedAuthentication" + ".SAMLProviderArn", StringUtils.FromString(item0.FederatedAuthentication.SAMLProviderArn));
                            }
                            if (item0.FederatedAuthentication.IsSetSelfServiceSAMLProviderArn())
                            {
                                request.Parameters.Add("Authentication" + "." + index0 + ".FederatedAuthentication" + ".SelfServiceSAMLProviderArn", StringUtils.FromString(item0.FederatedAuthentication.SelfServiceSAMLProviderArn));
                            }
                        }
                        if (item0.IsSetMutualAuthentication())
                        {
                            if (item0.MutualAuthentication.IsSetClientRootCertificateChainArn())
                            {
                                request.Parameters.Add("Authentication" + "." + index0 + ".MutualAuthentication" + ".ClientRootCertificateChainArn", StringUtils.FromString(item0.MutualAuthentication.ClientRootCertificateChainArn));
                            }
                        }
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("Authentication" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClientCidrBlock())
            {
                request.Parameters.Add("ClientCidrBlock", StringUtils.FromString(publicRequest.ClientCidrBlock));
            }
            if (publicRequest.IsSetClientConnectOptions())
            {
                if (publicRequest.ClientConnectOptions.IsSetEnabled())
                {
                    request.Parameters.Add("ClientConnectOptions" + ".Enabled", StringUtils.FromBool(publicRequest.ClientConnectOptions.Enabled.Value));
                }
                if (publicRequest.ClientConnectOptions.IsSetLambdaFunctionArn())
                {
                    request.Parameters.Add("ClientConnectOptions" + ".LambdaFunctionArn", StringUtils.FromString(publicRequest.ClientConnectOptions.LambdaFunctionArn));
                }
            }
            if (publicRequest.IsSetClientLoginBannerOptions())
            {
                if (publicRequest.ClientLoginBannerOptions.IsSetBannerText())
                {
                    request.Parameters.Add("ClientLoginBannerOptions" + ".BannerText", StringUtils.FromString(publicRequest.ClientLoginBannerOptions.BannerText));
                }
                if (publicRequest.ClientLoginBannerOptions.IsSetEnabled())
                {
                    request.Parameters.Add("ClientLoginBannerOptions" + ".Enabled", StringUtils.FromBool(publicRequest.ClientLoginBannerOptions.Enabled.Value));
                }
            }
            if (publicRequest.IsSetClientRouteEnforcementOptions())
            {
                if (publicRequest.ClientRouteEnforcementOptions.IsSetEnforced())
                {
                    request.Parameters.Add("ClientRouteEnforcementOptions" + ".Enforced", StringUtils.FromBool(publicRequest.ClientRouteEnforcementOptions.Enforced.Value));
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetConnectionLogOptions())
            {
                if (publicRequest.ConnectionLogOptions.IsSetCloudwatchLogGroup())
                {
                    request.Parameters.Add("ConnectionLogOptions" + ".CloudwatchLogGroup", StringUtils.FromString(publicRequest.ConnectionLogOptions.CloudwatchLogGroup));
                }
                if (publicRequest.ConnectionLogOptions.IsSetCloudwatchLogStream())
                {
                    request.Parameters.Add("ConnectionLogOptions" + ".CloudwatchLogStream", StringUtils.FromString(publicRequest.ConnectionLogOptions.CloudwatchLogStream));
                }
                if (publicRequest.ConnectionLogOptions.IsSetEnabled())
                {
                    request.Parameters.Add("ConnectionLogOptions" + ".Enabled", StringUtils.FromBool(publicRequest.ConnectionLogOptions.Enabled.Value));
                }
                if (publicRequest.ConnectionLogOptions.IsSetIncludeAuthorizationPolicyContext())
                {
                    request.Parameters.Add("ConnectionLogOptions" + ".IncludeAuthorizationPolicyContext", StringUtils.FromBool(publicRequest.ConnectionLogOptions.IncludeAuthorizationPolicyContext.Value));
                }
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDevicePostureOptions())
            {
                if (publicRequest.DevicePostureOptions.IsSetEnabled())
                {
                    request.Parameters.Add("DevicePostureOptions" + ".Enabled", StringUtils.FromBool(publicRequest.DevicePostureOptions.Enabled.Value));
                }
                if (publicRequest.DevicePostureOptions.IsSetTrustProviders())
                {
                    if (publicRequest.DevicePostureOptions.TrustProviders.Count == 0)
                    {
                        request.Parameters.Add("DevicePostureOptions" + ".TrustProvider", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.DevicePostureOptions.TrustProviders)
                        {
                            if (item1.IsSetPublicSigningKeyUrl())
                            {
                                request.Parameters.Add("DevicePostureOptions" + ".TrustProvider" + "." + index1 + ".PublicSigningKeyUrl", StringUtils.FromString(item1.PublicSigningKeyUrl));
                            }
                            if (item1.IsSetTenantId())
                            {
                                request.Parameters.Add("DevicePostureOptions" + ".TrustProvider" + "." + index1 + ".TenantId", StringUtils.FromString(item1.TenantId));
                            }
                            if (item1.IsSetTrustProviderType())
                            {
                                request.Parameters.Add("DevicePostureOptions" + ".TrustProvider" + "." + index1 + ".TrustProviderType", StringUtils.FromString(item1.TrustProviderType));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetDisconnectOnSessionTimeout())
            {
                request.Parameters.Add("DisconnectOnSessionTimeout", StringUtils.FromBool(publicRequest.DisconnectOnSessionTimeout.Value));
            }
            if (publicRequest.IsSetDnsServers())
            {
                if (publicRequest.DnsServers.Count == 0)
                {
                    request.Parameters.Add("DnsServers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DnsServers)
                    {
                        request.Parameters.Add("DnsServers" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEndpointIpAddressType())
            {
                request.Parameters.Add("EndpointIpAddressType", StringUtils.FromString(publicRequest.EndpointIpAddressType));
            }
            if (publicRequest.IsSetSecurityGroupIds())
            {
                if (publicRequest.SecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSelfServicePortal())
            {
                request.Parameters.Add("SelfServicePortal", StringUtils.FromString(publicRequest.SelfServicePortal));
            }
            if (publicRequest.IsSetServerCertificateArn())
            {
                request.Parameters.Add("ServerCertificateArn", StringUtils.FromString(publicRequest.ServerCertificateArn));
            }
            if (publicRequest.IsSetSessionTimeoutHours())
            {
                request.Parameters.Add("SessionTimeoutHours", StringUtils.FromInt(publicRequest.SessionTimeoutHours.Value));
            }
            if (publicRequest.IsSetSplitTunnel())
            {
                request.Parameters.Add("SplitTunnel", StringUtils.FromBool(publicRequest.SplitTunnel.Value));
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
            if (publicRequest.IsSetTrafficIpAddressType())
            {
                request.Parameters.Add("TrafficIpAddressType", StringUtils.FromString(publicRequest.TrafficIpAddressType));
            }
            if (publicRequest.IsSetTransitGatewayConfiguration())
            {
                if (publicRequest.TransitGatewayConfiguration.IsSetAvailabilityZoneIds())
                {
                    if (publicRequest.TransitGatewayConfiguration.AvailabilityZoneIds.Count == 0)
                    {
                        request.Parameters.Add("TransitGatewayConfiguration" + ".AvailabilityZoneId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TransitGatewayConfiguration.AvailabilityZoneIds)
                        {
                            request.Parameters.Add("TransitGatewayConfiguration" + ".AvailabilityZoneId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.TransitGatewayConfiguration.IsSetAvailabilityZones())
                {
                    if (publicRequest.TransitGatewayConfiguration.AvailabilityZones.Count == 0)
                    {
                        request.Parameters.Add("TransitGatewayConfiguration" + ".AvailabilityZone", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.TransitGatewayConfiguration.AvailabilityZones)
                        {
                            request.Parameters.Add("TransitGatewayConfiguration" + ".AvailabilityZone" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.TransitGatewayConfiguration.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayConfiguration" + ".TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayConfiguration.TransitGatewayId));
                }
            }
            if (publicRequest.IsSetTransportProtocol())
            {
                request.Parameters.Add("TransportProtocol", StringUtils.FromString(publicRequest.TransportProtocol));
            }
            if (publicRequest.IsSetVpcId())
            {
                request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
            }
            if (publicRequest.IsSetVpnPort())
            {
                request.Parameters.Add("VpnPort", StringUtils.FromInt(publicRequest.VpnPort.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateClientVpnEndpointRequestMarshaller _instance = new();

        internal static CreateClientVpnEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateClientVpnEndpointRequestMarshaller Instance => _instance;
    }
}
