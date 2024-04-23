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
    /// CreateVpnConnection Request Marshaller
    /// </summary>       
    public class CreateVpnConnectionRequestMarshaller : IMarshaller<IRequest, CreateVpnConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVpnConnectionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVpnConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateVpnConnection");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCustomerGatewayId())
                {
                    request.Parameters.Add("CustomerGatewayId", StringUtils.FromString(publicRequest.CustomerGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptions())
                {
                    if(publicRequest.Options.IsSetEnableAcceleration())
                    {
                        request.Parameters.Add("Options" + "." + "EnableAcceleration", StringUtils.FromBool(publicRequest.Options.EnableAcceleration));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetLocalIpv4NetworkCidr())
                    {
                        request.Parameters.Add("Options" + "." + "LocalIpv4NetworkCidr", StringUtils.FromString(publicRequest.Options.LocalIpv4NetworkCidr));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetLocalIpv6NetworkCidr())
                    {
                        request.Parameters.Add("Options" + "." + "LocalIpv6NetworkCidr", StringUtils.FromString(publicRequest.Options.LocalIpv6NetworkCidr));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetOutsideIpAddressType())
                    {
                        request.Parameters.Add("Options" + "." + "OutsideIpAddressType", StringUtils.FromString(publicRequest.Options.OutsideIpAddressType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetRemoteIpv4NetworkCidr())
                    {
                        request.Parameters.Add("Options" + "." + "RemoteIpv4NetworkCidr", StringUtils.FromString(publicRequest.Options.RemoteIpv4NetworkCidr));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetRemoteIpv6NetworkCidr())
                    {
                        request.Parameters.Add("Options" + "." + "RemoteIpv6NetworkCidr", StringUtils.FromString(publicRequest.Options.RemoteIpv6NetworkCidr));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetStaticRoutesOnly())
                    {
                        request.Parameters.Add("Options" + "." + "StaticRoutesOnly", StringUtils.FromBool(publicRequest.Options.StaticRoutesOnly));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetTransportTransitGatewayAttachmentId())
                    {
                        request.Parameters.Add("Options" + "." + "TransportTransitGatewayAttachmentId", StringUtils.FromString(publicRequest.Options.TransportTransitGatewayAttachmentId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetTunnelInsideIpVersion())
                    {
                        request.Parameters.Add("Options" + "." + "TunnelInsideIpVersion", StringUtils.FromString(publicRequest.Options.TunnelInsideIpVersion));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Options.IsSetTunnelOptions())
                    {
                        int publicRequestOptionslistValueIndex = 1;
                        foreach(var publicRequestOptionslistValue in publicRequest.Options.TunnelOptions)
                        {
                            if(publicRequestOptionslistValue.IsSetDPDTimeoutAction())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "DPDTimeoutAction", StringUtils.FromString(publicRequestOptionslistValue.DPDTimeoutAction));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetDPDTimeoutSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "DPDTimeoutSeconds", StringUtils.FromInt(publicRequestOptionslistValue.DPDTimeoutSeconds));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetEnableTunnelLifecycleControl())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "EnableTunnelLifecycleControl", StringUtils.FromBool(publicRequestOptionslistValue.EnableTunnelLifecycleControl));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetIKEVersions())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.IKEVersions)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "IKEVersion" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetLogOptions())
                            {
                                if(publicRequestOptionslistValue.LogOptions.IsSetCloudWatchLogOptions())
                                {
                                    if(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.IsSetLogEnabled())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogEnabled", StringUtils.FromBool(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.LogEnabled));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.IsSetLogGroupArn())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogGroupArn", StringUtils.FromString(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.LogGroupArn));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.IsSetLogOutputFormat())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogOutputFormat", StringUtils.FromString(publicRequestOptionslistValue.LogOptions.CloudWatchLogOptions.LogOutputFormat));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase1DHGroupNumbers())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1DHGroupNumbers)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1DHGroupNumber" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase1EncryptionAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1EncryptionAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1EncryptionAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase1IntegrityAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1IntegrityAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1IntegrityAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase1LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1LifetimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.Phase1LifetimeSeconds));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase2DHGroupNumbers())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2DHGroupNumbers)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2DHGroupNumber" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase2EncryptionAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2EncryptionAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2EncryptionAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase2IntegrityAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2IntegrityAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2IntegrityAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
#pragma warning restore CS0612,CS0618
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPhase2LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2LifetimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.Phase2LifetimeSeconds));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetPreSharedKey())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "PreSharedKey", StringUtils.FromString(publicRequestOptionslistValue.PreSharedKey));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetRekeyFuzzPercentage())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "RekeyFuzzPercentage", StringUtils.FromInt(publicRequestOptionslistValue.RekeyFuzzPercentage));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetRekeyMarginTimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "RekeyMarginTimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.RekeyMarginTimeSeconds));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetReplayWindowSize())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "ReplayWindowSize", StringUtils.FromInt(publicRequestOptionslistValue.ReplayWindowSize));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetStartupAction())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "StartupAction", StringUtils.FromString(publicRequestOptionslistValue.StartupAction));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetTunnelInsideCidr())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "TunnelInsideCidr", StringUtils.FromString(publicRequestOptionslistValue.TunnelInsideCidr));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestOptionslistValue.IsSetTunnelInsideIpv6Cidr())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "TunnelInsideIpv6Cidr", StringUtils.FromString(publicRequestOptionslistValue.TunnelInsideIpv6Cidr));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestOptionslistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpnGatewayId())
                {
                    request.Parameters.Add("VpnGatewayId", StringUtils.FromString(publicRequest.VpnGatewayId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateVpnConnectionRequestMarshaller _instance = new CreateVpnConnectionRequestMarshaller();        

        internal static CreateVpnConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVpnConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}