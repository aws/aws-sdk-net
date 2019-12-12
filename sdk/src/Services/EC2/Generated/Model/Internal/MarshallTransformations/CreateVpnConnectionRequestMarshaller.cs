/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                if(publicRequest.IsSetOptions())
                {
                    if(publicRequest.Options.IsSetEnableAcceleration())
                    {
                        request.Parameters.Add("Options" + "." + "EnableAcceleration", StringUtils.FromBool(publicRequest.Options.EnableAcceleration));
                    }
                    if(publicRequest.Options.IsSetStaticRoutesOnly())
                    {
                        request.Parameters.Add("Options" + "." + "StaticRoutesOnly", StringUtils.FromBool(publicRequest.Options.StaticRoutesOnly));
                    }
                    if(publicRequest.Options.IsSetTunnelOptions())
                    {
                        int publicRequestOptionslistValueIndex = 1;
                        foreach(var publicRequestOptionslistValue in publicRequest.Options.TunnelOptions)
                        {
                            if(publicRequestOptionslistValue.IsSetDPDTimeoutSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "DPDTimeoutSeconds", StringUtils.FromInt(publicRequestOptionslistValue.DPDTimeoutSeconds));
                            }
                            if(publicRequestOptionslistValue.IsSetIKEVersions())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.IKEVersions)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "IKEVersion" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase1DHGroupNumbers())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1DHGroupNumbers)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1DHGroupNumber" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase1EncryptionAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1EncryptionAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1EncryptionAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase1IntegrityAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase1IntegrityAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1IntegrityAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase1LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase1LifetimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.Phase1LifetimeSeconds));
                            }
                            if(publicRequestOptionslistValue.IsSetPhase2DHGroupNumbers())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2DHGroupNumbers)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2DHGroupNumber" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromInt(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase2EncryptionAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2EncryptionAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2EncryptionAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase2IntegrityAlgorithms())
                            {
                                int publicRequestOptionslistValuelistValueIndex = 1;
                                foreach(var publicRequestOptionslistValuelistValue in publicRequestOptionslistValue.Phase2IntegrityAlgorithms)
                                {
                                    if(publicRequestOptionslistValuelistValue.IsSetValue())
                                    {
                                        request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2IntegrityAlgorithm" + "." + publicRequestOptionslistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestOptionslistValuelistValue.Value));
                                    }
                                    publicRequestOptionslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOptionslistValue.IsSetPhase2LifetimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "Phase2LifetimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.Phase2LifetimeSeconds));
                            }
                            if(publicRequestOptionslistValue.IsSetPreSharedKey())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "PreSharedKey", StringUtils.FromString(publicRequestOptionslistValue.PreSharedKey));
                            }
                            if(publicRequestOptionslistValue.IsSetRekeyFuzzPercentage())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "RekeyFuzzPercentage", StringUtils.FromInt(publicRequestOptionslistValue.RekeyFuzzPercentage));
                            }
                            if(publicRequestOptionslistValue.IsSetRekeyMarginTimeSeconds())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "RekeyMarginTimeSeconds", StringUtils.FromInt(publicRequestOptionslistValue.RekeyMarginTimeSeconds));
                            }
                            if(publicRequestOptionslistValue.IsSetReplayWindowSize())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "ReplayWindowSize", StringUtils.FromInt(publicRequestOptionslistValue.ReplayWindowSize));
                            }
                            if(publicRequestOptionslistValue.IsSetTunnelInsideCidr())
                            {
                                request.Parameters.Add("Options" + "." + "TunnelOptions" + "." + publicRequestOptionslistValueIndex + "." + "TunnelInsideCidr", StringUtils.FromString(publicRequestOptionslistValue.TunnelInsideCidr));
                            }
                            publicRequestOptionslistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetTransitGatewayId())
                {
                    request.Parameters.Add("TransitGatewayId", StringUtils.FromString(publicRequest.TransitGatewayId));
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
                if(publicRequest.IsSetVpnGatewayId())
                {
                    request.Parameters.Add("VpnGatewayId", StringUtils.FromString(publicRequest.VpnGatewayId));
                }
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