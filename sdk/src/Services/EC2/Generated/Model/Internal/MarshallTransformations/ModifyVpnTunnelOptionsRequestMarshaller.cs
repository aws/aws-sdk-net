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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVpnTunnelOptions Request Marshaller
    /// </summary>       
    public class ModifyVpnTunnelOptionsRequestMarshaller : IMarshaller<IRequest, ModifyVpnTunnelOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpnTunnelOptionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpnTunnelOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpnTunnelOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetSkipTunnelReplacement())
                {
                    request.Parameters.Add("SkipTunnelReplacement", StringUtils.FromBool(publicRequest.SkipTunnelReplacement));
                }
                if(publicRequest.IsSetTunnelOptions())
                {
                    if(publicRequest.TunnelOptions.IsSetDPDTimeoutAction())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "DPDTimeoutAction", StringUtils.FromString(publicRequest.TunnelOptions.DPDTimeoutAction));
                    }
                    if(publicRequest.TunnelOptions.IsSetDPDTimeoutSeconds())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "DPDTimeoutSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.DPDTimeoutSeconds));
                    }
                    if(publicRequest.TunnelOptions.IsSetEnableTunnelLifecycleControl())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "EnableTunnelLifecycleControl", StringUtils.FromBool(publicRequest.TunnelOptions.EnableTunnelLifecycleControl));
                    }
                    if(publicRequest.TunnelOptions.IsSetIKEVersions())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.IKEVersions)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "IKEVersion" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetLogOptions())
                    {
                        if(publicRequest.TunnelOptions.LogOptions.IsSetCloudWatchLogOptions())
                        {
                            if(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogEnabled())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogEnabled", StringUtils.FromBool(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogEnabled));
                            }
                            if(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogGroupArn())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogGroupArn", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogGroupArn));
                            }
                            if(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.IsSetLogOutputFormat())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "LogOptions" + "." + "CloudWatchLogOptions" + "." + "LogOutputFormat", StringUtils.FromString(publicRequest.TunnelOptions.LogOptions.CloudWatchLogOptions.LogOutputFormat));
                            }
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase1DHGroupNumbers())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase1DHGroupNumbers)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase1DHGroupNumber" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase1EncryptionAlgorithms())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase1EncryptionAlgorithms)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase1EncryptionAlgorithm" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase1IntegrityAlgorithms())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase1IntegrityAlgorithms)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase1IntegrityAlgorithm" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase1LifetimeSeconds())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "Phase1LifetimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.Phase1LifetimeSeconds));
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase2DHGroupNumbers())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase2DHGroupNumbers)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase2DHGroupNumber" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase2EncryptionAlgorithms())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase2EncryptionAlgorithms)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase2EncryptionAlgorithm" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase2IntegrityAlgorithms())
                    {
                        int publicRequestTunnelOptionslistValueIndex = 1;
                        foreach(var publicRequestTunnelOptionslistValue in publicRequest.TunnelOptions.Phase2IntegrityAlgorithms)
                        {
                            if(publicRequestTunnelOptionslistValue.IsSetValue())
                            {
                                request.Parameters.Add("TunnelOptions" + "." + "Phase2IntegrityAlgorithm" + "." + publicRequestTunnelOptionslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTunnelOptionslistValue.Value));
                            }
                            publicRequestTunnelOptionslistValueIndex++;
                        }
                    }
                    if(publicRequest.TunnelOptions.IsSetPhase2LifetimeSeconds())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "Phase2LifetimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.Phase2LifetimeSeconds));
                    }
                    if(publicRequest.TunnelOptions.IsSetPreSharedKey())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "PreSharedKey", StringUtils.FromString(publicRequest.TunnelOptions.PreSharedKey));
                    }
                    if(publicRequest.TunnelOptions.IsSetRekeyFuzzPercentage())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "RekeyFuzzPercentage", StringUtils.FromInt(publicRequest.TunnelOptions.RekeyFuzzPercentage));
                    }
                    if(publicRequest.TunnelOptions.IsSetRekeyMarginTimeSeconds())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "RekeyMarginTimeSeconds", StringUtils.FromInt(publicRequest.TunnelOptions.RekeyMarginTimeSeconds));
                    }
                    if(publicRequest.TunnelOptions.IsSetReplayWindowSize())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "ReplayWindowSize", StringUtils.FromInt(publicRequest.TunnelOptions.ReplayWindowSize));
                    }
                    if(publicRequest.TunnelOptions.IsSetStartupAction())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "StartupAction", StringUtils.FromString(publicRequest.TunnelOptions.StartupAction));
                    }
                    if(publicRequest.TunnelOptions.IsSetTunnelInsideCidr())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "TunnelInsideCidr", StringUtils.FromString(publicRequest.TunnelOptions.TunnelInsideCidr));
                    }
                    if(publicRequest.TunnelOptions.IsSetTunnelInsideIpv6Cidr())
                    {
                        request.Parameters.Add("TunnelOptions" + "." + "TunnelInsideIpv6Cidr", StringUtils.FromString(publicRequest.TunnelOptions.TunnelInsideIpv6Cidr));
                    }
                }
                if(publicRequest.IsSetVpnConnectionId())
                {
                    request.Parameters.Add("VpnConnectionId", StringUtils.FromString(publicRequest.VpnConnectionId));
                }
                if(publicRequest.IsSetVpnTunnelOutsideIpAddress())
                {
                    request.Parameters.Add("VpnTunnelOutsideIpAddress", StringUtils.FromString(publicRequest.VpnTunnelOutsideIpAddress));
                }
            }
            return request;
        }
                    private static ModifyVpnTunnelOptionsRequestMarshaller _instance = new ModifyVpnTunnelOptionsRequestMarshaller();        

        internal static ModifyVpnTunnelOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpnTunnelOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}