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
    /// RunInstances Request Marshaller
    /// </summary>       
    public class RunInstancesRequestMarshaller : IMarshaller<IRequest, RunInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunInstancesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RunInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RunInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                    {
                        if(publicRequestlistValue.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetEbs())
                        {
                            if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValue.Ebs.Encrypted));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValue.Ebs.Iops));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetKmsKeyId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestlistValue.Ebs.KmsKeyId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetOutpostArn())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestlistValue.Ebs.OutpostArn));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.Ebs.SnapshotId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetThroughput())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestlistValue.Ebs.Throughput));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeSize));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeType));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValue.NoDevice));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCapacityReservationSpecification())
                {
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                    {
                        request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationPreference", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationPreference));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                    {
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationId", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCpuOptions())
                {
                    if(publicRequest.CpuOptions.IsSetAmdSevSnp())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "AmdSevSnp", StringUtils.FromString(publicRequest.CpuOptions.AmdSevSnp));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.CpuOptions.IsSetCoreCount())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "CoreCount", StringUtils.FromInt(publicRequest.CpuOptions.CoreCount));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.CpuOptions.IsSetThreadsPerCore())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "ThreadsPerCore", StringUtils.FromInt(publicRequest.CpuOptions.ThreadsPerCore));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCreditSpecification())
                {
                    if(publicRequest.CreditSpecification.IsSetCpuCredits())
                    {
                        request.Parameters.Add("CreditSpecification" + "." + "CpuCredits", StringUtils.FromString(publicRequest.CreditSpecification.CpuCredits));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDisableApiStop())
                {
                    request.Parameters.Add("DisableApiStop", StringUtils.FromBool(publicRequest.DisableApiStop));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDisableApiTermination())
                {
                    request.Parameters.Add("DisableApiTermination", StringUtils.FromBool(publicRequest.DisableApiTermination));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetElasticGpuSpecification())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ElasticGpuSpecification)
                    {
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("ElasticGpuSpecification" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetElasticInferenceAccelerators())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ElasticInferenceAccelerators)
                    {
                        if(publicRequestlistValue.IsSetCount())
                        {
                            request.Parameters.Add("ElasticInferenceAccelerator" + "." + publicRequestlistValueIndex + "." + "Count", StringUtils.FromInt(publicRequestlistValue.Count));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("ElasticInferenceAccelerator" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnablePrimaryIpv6())
                {
                    request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnclaveOptions())
                {
                    if(publicRequest.EnclaveOptions.IsSetEnabled())
                    {
                        request.Parameters.Add("EnclaveOptions" + "." + "Enabled", StringUtils.FromBool(publicRequest.EnclaveOptions.Enabled));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetHibernationOptions())
                {
                    if(publicRequest.HibernationOptions.IsSetConfigured())
                    {
                        request.Parameters.Add("HibernationOptions" + "." + "Configured", StringUtils.FromBool(publicRequest.HibernationOptions.Configured));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIamInstanceProfile())
                {
                    if(publicRequest.IamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.IamInstanceProfile.Arn));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.IamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.IamInstanceProfile.Name));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceMarketOptions())
                {
                    if(publicRequest.InstanceMarketOptions.IsSetMarketType())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + "." + "MarketType", StringUtils.FromString(publicRequest.InstanceMarketOptions.MarketType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.InstanceMarketOptions.IsSetSpotOptions())
                    {
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetBlockDurationMinutes())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "BlockDurationMinutes", StringUtils.FromInt(publicRequest.InstanceMarketOptions.SpotOptions.BlockDurationMinutes));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetInstanceInterruptionBehavior())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.InstanceInterruptionBehavior));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetMaxPrice())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "MaxPrice", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.MaxPrice));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetSpotInstanceType())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "SpotInstanceType", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.SpotInstanceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetValidUntilUtc())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "ValidUntil", StringUtils.FromDateTimeToISO8601(publicRequest.InstanceMarketOptions.SpotOptions.ValidUntilUtc));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpv6AddressCount())
                {
                    request.Parameters.Add("Ipv6AddressCount", StringUtils.FromInt(publicRequest.Ipv6AddressCount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIpv6Addresses())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Ipv6Addresses)
                    {
                        if(publicRequestlistValue.IsSetIpv6Address())
                        {
                            request.Parameters.Add("Ipv6Address" + "." + publicRequestlistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestlistValue.Ipv6Address));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIsPrimaryIpv6())
                        {
                            request.Parameters.Add("Ipv6Address" + "." + publicRequestlistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestlistValue.IsPrimaryIpv6));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetKernelId())
                {
                    request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetKeyName())
                {
                    request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLaunchTemplate())
                {
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.LaunchTemplate.IsSetVersion())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLicenseSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LicenseSpecifications)
                    {
                        if(publicRequestlistValue.IsSetLicenseConfigurationArn())
                        {
                            request.Parameters.Add("LicenseSpecification" + "." + publicRequestlistValueIndex + "." + "LicenseConfigurationArn", StringUtils.FromString(publicRequestlistValue.LicenseConfigurationArn));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaintenanceOptions())
                {
                    if(publicRequest.MaintenanceOptions.IsSetAutoRecovery())
                    {
                        request.Parameters.Add("MaintenanceOptions" + "." + "AutoRecovery", StringUtils.FromString(publicRequest.MaintenanceOptions.AutoRecovery));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxCount())
                {
                    request.Parameters.Add("MaxCount", StringUtils.FromInt(publicRequest.MaxCount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMetadataOptions())
                {
                    if(publicRequest.MetadataOptions.IsSetHttpEndpoint())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpEndpoint", StringUtils.FromString(publicRequest.MetadataOptions.HttpEndpoint));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.MetadataOptions.IsSetHttpProtocolIpv6())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpProtocolIpv6", StringUtils.FromString(publicRequest.MetadataOptions.HttpProtocolIpv6));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.MetadataOptions.IsSetHttpPutResponseHopLimit())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.MetadataOptions.HttpPutResponseHopLimit));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.MetadataOptions.IsSetHttpTokens())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpTokens", StringUtils.FromString(publicRequest.MetadataOptions.HttpTokens));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.MetadataOptions.IsSetInstanceMetadataTags())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "InstanceMetadataTags", StringUtils.FromString(publicRequest.MetadataOptions.InstanceMetadataTags));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMinCount())
                {
                    request.Parameters.Add("MinCount", StringUtils.FromInt(publicRequest.MinCount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMonitoring())
                {
                    request.Parameters.Add("Monitoring.Enabled", StringUtils.FromBool(publicRequest.Monitoring));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNetworkInterfaces())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.NetworkInterfaces)
                    {
                        if(publicRequestlistValue.IsSetAssociateCarrierIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestlistValue.AssociateCarrierIpAddress));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetAssociatePublicIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestlistValue.AssociatePublicIpAddress));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetConnectionTrackingSpecification())
                        {
                            if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.UdpStreamTimeout));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetUdpTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.UdpTimeout));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.DeleteOnTermination));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetDeviceIndex())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestlistValue.DeviceIndex));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetEnaSrdSpecification())
                        {
                            if(publicRequestlistValue.EnaSrdSpecification.IsSetEnaSrdEnabled())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequestlistValue.EnaSrdSpecification.EnaSrdEnabled));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                            {
                                if(publicRequestlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequestlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetGroups())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Groups)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecurityGroupId" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetInterfaceType())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestlistValue.InterfaceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv4PrefixCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestlistValue.Ipv4PrefixCount));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv4Prefixes())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv4Prefixes)
                            {
                                if(publicRequestlistValuelistValue.IsSetIpv4Prefix())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestlistValuelistValue.Ipv4Prefix));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6AddressCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestlistValue.Ipv6AddressCount));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6Addresses())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Addresses)
                            {
                                if(publicRequestlistValuelistValue.IsSetIpv6Address())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestlistValuelistValue.Ipv6Address));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetIsPrimaryIpv6())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestlistValuelistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestlistValuelistValue.IsPrimaryIpv6));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6PrefixCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestlistValue.Ipv6PrefixCount));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetIpv6Prefixes())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Prefixes)
                            {
                                if(publicRequestlistValuelistValue.IsSetIpv6Prefix())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestlistValuelistValue.Ipv6Prefix));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetNetworkCardIndex())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestlistValue.NetworkCardIndex));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetNetworkInterfaceId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestlistValue.NetworkInterfaceId));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPrimaryIpv6())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrimaryIpv6", StringUtils.FromBool(publicRequestlistValue.PrimaryIpv6));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPrivateIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValue.PrivateIpAddress));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPrivateIpAddresses())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PrivateIpAddresses)
                            {
                                if(publicRequestlistValuelistValue.IsSetPrimary())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestlistValuelistValue.Primary));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetPrivateIpAddress())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValuelistValue.PrivateIpAddress));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSecondaryPrivateIpAddressCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestlistValue.SecondaryPrivateIpAddressCount));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetSubnetId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPlacement())
                {
                    if(publicRequest.Placement.IsSetAffinity())
                    {
                        request.Parameters.Add("Placement" + "." + "Affinity", StringUtils.FromString(publicRequest.Placement.Affinity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.Placement.AvailabilityZone));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetGroupId())
                    {
                        request.Parameters.Add("Placement" + "." + "GroupId", StringUtils.FromString(publicRequest.Placement.GroupId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.Placement.GroupName));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetHostId())
                    {
                        request.Parameters.Add("Placement" + "." + "HostId", StringUtils.FromString(publicRequest.Placement.HostId));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetHostResourceGroupArn())
                    {
                        request.Parameters.Add("Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequest.Placement.HostResourceGroupArn));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetPartitionNumber())
                    {
                        request.Parameters.Add("Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequest.Placement.PartitionNumber));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetSpreadDomain())
                    {
                        request.Parameters.Add("Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequest.Placement.SpreadDomain));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.Placement.Tenancy));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPrivateDnsNameOptions())
                {
                    if(publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsAAAARecord())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsAAAARecord));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsARecord())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsARecord));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PrivateDnsNameOptions.IsSetHostnameType())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "HostnameType", StringUtils.FromString(publicRequest.PrivateDnsNameOptions.HostnameType));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRamdiskId())
                {
                    request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroup" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSubnetId())
                {
                    request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
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
                if(publicRequest.IsSetUserData())
                {
                    request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static RunInstancesRequestMarshaller _instance = new RunInstancesRequestMarshaller();        

        internal static RunInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}