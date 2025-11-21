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
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    if (publicRequest.BlockDeviceMappings.Count == 0)
                        request.Parameters.Add("BlockDeviceMapping", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                         {
                            if(publicRequestlistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                            }
                            if(publicRequestlistValue.IsSetEbs())
                            {
                                if(publicRequestlistValue.Ebs.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValue.Ebs.AvailabilityZone));
                                }
                                if(publicRequestlistValue.Ebs.IsSetAvailabilityZoneId())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestlistValue.Ebs.AvailabilityZoneId));
                                }
                                if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                                }
                                if(publicRequestlistValue.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValue.Ebs.Encrypted));
                                }
                                if(publicRequestlistValue.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValue.Ebs.Iops));
                                }
                                if(publicRequestlistValue.Ebs.IsSetKmsKeyId())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestlistValue.Ebs.KmsKeyId));
                                }
                                if(publicRequestlistValue.Ebs.IsSetOutpostArn())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestlistValue.Ebs.OutpostArn));
                                }
                                if(publicRequestlistValue.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.Ebs.SnapshotId));
                                }
                                if(publicRequestlistValue.Ebs.IsSetThroughput())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestlistValue.Ebs.Throughput));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeInitializationRate())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeInitializationRate", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeInitializationRate));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeSize));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeType));
                                }
                            }
                            if(publicRequestlistValue.IsSetNoDevice())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValue.NoDevice));
                            }
                            if(publicRequestlistValue.IsSetVirtualName())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetCapacityReservationSpecification())
                {
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                    {
                        request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationPreference", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationPreference));
                    }
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                    {
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationId", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                        }
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                        }
                    }
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetCpuOptions())
                {
                    if(publicRequest.CpuOptions.IsSetAmdSevSnp())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "AmdSevSnp", StringUtils.FromString(publicRequest.CpuOptions.AmdSevSnp));
                    }
                    if(publicRequest.CpuOptions.IsSetCoreCount())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "CoreCount", StringUtils.FromInt(publicRequest.CpuOptions.CoreCount));
                    }
                    if(publicRequest.CpuOptions.IsSetThreadsPerCore())
                    {
                        request.Parameters.Add("CpuOptions" + "." + "ThreadsPerCore", StringUtils.FromInt(publicRequest.CpuOptions.ThreadsPerCore));
                    }
                }
                if(publicRequest.IsSetCreditSpecification())
                {
                    if(publicRequest.CreditSpecification.IsSetCpuCredits())
                    {
                        request.Parameters.Add("CreditSpecification" + "." + "CpuCredits", StringUtils.FromString(publicRequest.CreditSpecification.CpuCredits));
                    }
                }
                if(publicRequest.IsSetDisableApiStop())
                {
                    request.Parameters.Add("DisableApiStop", StringUtils.FromBool(publicRequest.DisableApiStop));
                }
                if(publicRequest.IsSetDisableApiTermination())
                {
                    request.Parameters.Add("DisableApiTermination", StringUtils.FromBool(publicRequest.DisableApiTermination));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
                if(publicRequest.IsSetElasticGpuSpecification())
                {
                    if (publicRequest.ElasticGpuSpecification.Count == 0)
                        request.Parameters.Add("ElasticGpuSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ElasticGpuSpecification)
                         {
                            if(publicRequestlistValue.IsSetType())
                            {
                                request.Parameters.Add("ElasticGpuSpecification" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetElasticInferenceAccelerators())
                {
                    if (publicRequest.ElasticInferenceAccelerators.Count == 0)
                        request.Parameters.Add("ElasticInferenceAccelerator", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ElasticInferenceAccelerators)
                         {
                            if(publicRequestlistValue.IsSetCount())
                            {
                                request.Parameters.Add("ElasticInferenceAccelerator" + "." + publicRequestlistValueIndex + "." + "Count", StringUtils.FromInt(publicRequestlistValue.Count));
                            }
                            if(publicRequestlistValue.IsSetType())
                            {
                                request.Parameters.Add("ElasticInferenceAccelerator" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEnablePrimaryIpv6())
                {
                    request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6));
                }
                if(publicRequest.IsSetEnclaveOptions())
                {
                    if(publicRequest.EnclaveOptions.IsSetEnabled())
                    {
                        request.Parameters.Add("EnclaveOptions" + "." + "Enabled", StringUtils.FromBool(publicRequest.EnclaveOptions.Enabled));
                    }
                }
                if(publicRequest.IsSetHibernationOptions())
                {
                    if(publicRequest.HibernationOptions.IsSetConfigured())
                    {
                        request.Parameters.Add("HibernationOptions" + "." + "Configured", StringUtils.FromBool(publicRequest.HibernationOptions.Configured));
                    }
                }
                if(publicRequest.IsSetIamInstanceProfile())
                {
                    if(publicRequest.IamInstanceProfile.IsSetArn())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Arn", StringUtils.FromString(publicRequest.IamInstanceProfile.Arn));
                    }
                    if(publicRequest.IamInstanceProfile.IsSetName())
                    {
                        request.Parameters.Add("IamInstanceProfile" + "." + "Name", StringUtils.FromString(publicRequest.IamInstanceProfile.Name));
                    }
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
                }
                if(publicRequest.IsSetInstanceMarketOptions())
                {
                    if(publicRequest.InstanceMarketOptions.IsSetMarketType())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + "." + "MarketType", StringUtils.FromString(publicRequest.InstanceMarketOptions.MarketType));
                    }
                    if(publicRequest.InstanceMarketOptions.IsSetSpotOptions())
                    {
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetBlockDurationMinutes())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "BlockDurationMinutes", StringUtils.FromInt(publicRequest.InstanceMarketOptions.SpotOptions.BlockDurationMinutes));
                        }
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetInstanceInterruptionBehavior())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.InstanceInterruptionBehavior));
                        }
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetMaxPrice())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "MaxPrice", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.MaxPrice));
                        }
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetSpotInstanceType())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "SpotInstanceType", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.SpotInstanceType));
                        }
                        if(publicRequest.InstanceMarketOptions.SpotOptions.IsSetValidUntil())
                        {
                            request.Parameters.Add("InstanceMarketOptions" + "." + "SpotOptions" + "." + "ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.InstanceMarketOptions.SpotOptions.ValidUntil));
                        }
                    }
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetIpv6AddressCount())
                {
                    request.Parameters.Add("Ipv6AddressCount", StringUtils.FromInt(publicRequest.Ipv6AddressCount));
                }
                if(publicRequest.IsSetIpv6Addresses())
                {
                    if (publicRequest.Ipv6Addresses.Count == 0)
                        request.Parameters.Add("Ipv6Address", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Ipv6Addresses)
                         {
                            if(publicRequestlistValue.IsSetIpv6Address())
                            {
                                request.Parameters.Add("Ipv6Address" + "." + publicRequestlistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestlistValue.Ipv6Address));
                            }
                            if(publicRequestlistValue.IsSetIsPrimaryIpv6())
                            {
                                request.Parameters.Add("Ipv6Address" + "." + publicRequestlistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestlistValue.IsPrimaryIpv6));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetKernelId())
                {
                    request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
                }
                if(publicRequest.IsSetKeyName())
                {
                    request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
                }
                if(publicRequest.IsSetLaunchTemplate())
                {
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                    }
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                    }
                    if(publicRequest.LaunchTemplate.IsSetVersion())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                    }
                }
                if(publicRequest.IsSetLicenseSpecifications())
                {
                    if (publicRequest.LicenseSpecifications.Count == 0)
                        request.Parameters.Add("LicenseSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.LicenseSpecifications)
                         {
                            if(publicRequestlistValue.IsSetLicenseConfigurationArn())
                            {
                                request.Parameters.Add("LicenseSpecification" + "." + publicRequestlistValueIndex + "." + "LicenseConfigurationArn", StringUtils.FromString(publicRequestlistValue.LicenseConfigurationArn));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMaintenanceOptions())
                {
                    if(publicRequest.MaintenanceOptions.IsSetAutoRecovery())
                    {
                        request.Parameters.Add("MaintenanceOptions" + "." + "AutoRecovery", StringUtils.FromString(publicRequest.MaintenanceOptions.AutoRecovery));
                    }
                }
                if(publicRequest.IsSetMaxCount())
                {
                    request.Parameters.Add("MaxCount", StringUtils.FromInt(publicRequest.MaxCount));
                }
                if(publicRequest.IsSetMetadataOptions())
                {
                    if(publicRequest.MetadataOptions.IsSetHttpEndpoint())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpEndpoint", StringUtils.FromString(publicRequest.MetadataOptions.HttpEndpoint));
                    }
                    if(publicRequest.MetadataOptions.IsSetHttpProtocolIpv6())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpProtocolIpv6", StringUtils.FromString(publicRequest.MetadataOptions.HttpProtocolIpv6));
                    }
                    if(publicRequest.MetadataOptions.IsSetHttpPutResponseHopLimit())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.MetadataOptions.HttpPutResponseHopLimit));
                    }
                    if(publicRequest.MetadataOptions.IsSetHttpTokens())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpTokens", StringUtils.FromString(publicRequest.MetadataOptions.HttpTokens));
                    }
                    if(publicRequest.MetadataOptions.IsSetInstanceMetadataTags())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "InstanceMetadataTags", StringUtils.FromString(publicRequest.MetadataOptions.InstanceMetadataTags));
                    }
                }
                if(publicRequest.IsSetMinCount())
                {
                    request.Parameters.Add("MinCount", StringUtils.FromInt(publicRequest.MinCount));
                }
                if(publicRequest.IsSetMonitoring())
                {
                    request.Parameters.Add("Monitoring.Enabled", StringUtils.FromBool(publicRequest.Monitoring));
                }
                if(publicRequest.IsSetNetworkInterfaces())
                {
                    if (publicRequest.NetworkInterfaces.Count == 0)
                        request.Parameters.Add("NetworkInterface", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NetworkInterfaces)
                         {
                            if(publicRequestlistValue.IsSetAssociateCarrierIpAddress())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "AssociateCarrierIpAddress", StringUtils.FromBool(publicRequestlistValue.AssociateCarrierIpAddress));
                            }
                            if(publicRequestlistValue.IsSetAssociatePublicIpAddress())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "AssociatePublicIpAddress", StringUtils.FromBool(publicRequestlistValue.AssociatePublicIpAddress));
                            }
                            if(publicRequestlistValue.IsSetConnectionTrackingSpecification())
                            {
                                if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                                }
                                if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.UdpStreamTimeout));
                                }
                                if(publicRequestlistValue.ConnectionTrackingSpecification.IsSetUdpTimeout())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequestlistValue.ConnectionTrackingSpecification.UdpTimeout));
                                }
                            }
                            if(publicRequestlistValue.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.DeleteOnTermination));
                            }
                            if(publicRequestlistValue.IsSetDescription())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                            }
                            if(publicRequestlistValue.IsSetDeviceIndex())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "DeviceIndex", StringUtils.FromInt(publicRequestlistValue.DeviceIndex));
                            }
                            if(publicRequestlistValue.IsSetEnaQueueCount())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "EnaQueueCount", StringUtils.FromInt(publicRequestlistValue.EnaQueueCount));
                            }
                            if(publicRequestlistValue.IsSetEnaSrdSpecification())
                            {
                                if(publicRequestlistValue.EnaSrdSpecification.IsSetEnaSrdEnabled())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequestlistValue.EnaSrdSpecification.EnaSrdEnabled));
                                }
                                if(publicRequestlistValue.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                                {
                                    if(publicRequestlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequestlistValue.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                                    }
                                }
                            }
                            if(publicRequestlistValue.IsSetGroups())
                            {
                                if (publicRequestlistValue.Groups.Count == 0)
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecurityGroupId", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Groups)
                                     {
                                         request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecurityGroupId" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetInterfaceType())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "InterfaceType", StringUtils.FromString(publicRequestlistValue.InterfaceType));
                            }
                            if(publicRequestlistValue.IsSetIpv4PrefixCount())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv4PrefixCount", StringUtils.FromInt(publicRequestlistValue.Ipv4PrefixCount));
                            }
                            if(publicRequestlistValue.IsSetIpv4Prefixes())
                            {
                                if (publicRequestlistValue.Ipv4Prefixes.Count == 0)
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv4Prefix", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv4Prefixes)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetIpv4Prefix())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv4Prefix" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv4Prefix", StringUtils.FromString(publicRequestlistValuelistValue.Ipv4Prefix));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetIpv6AddressCount())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6AddressCount", StringUtils.FromInt(publicRequestlistValue.Ipv6AddressCount));
                            }
                            if(publicRequestlistValue.IsSetIpv6Addresses())
                            {
                                if (publicRequestlistValue.Ipv6Addresses.Count == 0)
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Addresses", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Addresses)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetIpv6Address())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv6Address", StringUtils.FromString(publicRequestlistValuelistValue.Ipv6Address));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetIsPrimaryIpv6())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Addresses" + "." + publicRequestlistValuelistValueIndex + "." + "IsPrimaryIpv6", StringUtils.FromBool(publicRequestlistValuelistValue.IsPrimaryIpv6));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetIpv6PrefixCount())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6PrefixCount", StringUtils.FromInt(publicRequestlistValue.Ipv6PrefixCount));
                            }
                            if(publicRequestlistValue.IsSetIpv6Prefixes())
                            {
                                if (publicRequestlistValue.Ipv6Prefixes.Count == 0)
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Prefix", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Ipv6Prefixes)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetIpv6Prefix())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "Ipv6Prefix" + "." + publicRequestlistValuelistValueIndex + "." + "Ipv6Prefix", StringUtils.FromString(publicRequestlistValuelistValue.Ipv6Prefix));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetNetworkCardIndex())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "NetworkCardIndex", StringUtils.FromInt(publicRequestlistValue.NetworkCardIndex));
                            }
                            if(publicRequestlistValue.IsSetNetworkInterfaceId())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "NetworkInterfaceId", StringUtils.FromString(publicRequestlistValue.NetworkInterfaceId));
                            }
                            if(publicRequestlistValue.IsSetPrimaryIpv6())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrimaryIpv6", StringUtils.FromBool(publicRequestlistValue.PrimaryIpv6));
                            }
                            if(publicRequestlistValue.IsSetPrivateIpAddress())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValue.PrivateIpAddress));
                            }
                            if(publicRequestlistValue.IsSetPrivateIpAddresses())
                            {
                                if (publicRequestlistValue.PrivateIpAddresses.Count == 0)
                                    request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddresses", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PrivateIpAddresses)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetPrimary())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestlistValuelistValueIndex + "." + "Primary", StringUtils.FromBool(publicRequestlistValuelistValue.Primary));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetPrivateIpAddress())
                                        {
                                            request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "PrivateIpAddresses" + "." + publicRequestlistValuelistValueIndex + "." + "PrivateIpAddress", StringUtils.FromString(publicRequestlistValuelistValue.PrivateIpAddress));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetSecondaryPrivateIpAddressCount())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SecondaryPrivateIpAddressCount", StringUtils.FromInt(publicRequestlistValue.SecondaryPrivateIpAddressCount));
                            }
                            if(publicRequestlistValue.IsSetSubnetId())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + publicRequestlistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.SubnetId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNetworkPerformanceOptions())
                {
                    if(publicRequest.NetworkPerformanceOptions.IsSetBandwidthWeighting())
                    {
                        request.Parameters.Add("NetworkPerformanceOptions" + "." + "BandwidthWeighting", StringUtils.FromString(publicRequest.NetworkPerformanceOptions.BandwidthWeighting));
                    }
                }
                if(publicRequest.IsSetOperator())
                {
                    if(publicRequest.Operator.IsSetPrincipal())
                    {
                        request.Parameters.Add("Operator" + "." + "Principal", StringUtils.FromString(publicRequest.Operator.Principal));
                    }
                }
                if(publicRequest.IsSetPlacement())
                {
                    if(publicRequest.Placement.IsSetAffinity())
                    {
                        request.Parameters.Add("Placement" + "." + "Affinity", StringUtils.FromString(publicRequest.Placement.Affinity));
                    }
                    if(publicRequest.Placement.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.Placement.AvailabilityZone));
                    }
                    if(publicRequest.Placement.IsSetAvailabilityZoneId())
                    {
                        request.Parameters.Add("Placement" + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequest.Placement.AvailabilityZoneId));
                    }
                    if(publicRequest.Placement.IsSetGroupId())
                    {
                        request.Parameters.Add("Placement" + "." + "GroupId", StringUtils.FromString(publicRequest.Placement.GroupId));
                    }
                    if(publicRequest.Placement.IsSetGroupName())
                    {
                        request.Parameters.Add("Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.Placement.GroupName));
                    }
                    if(publicRequest.Placement.IsSetHostId())
                    {
                        request.Parameters.Add("Placement" + "." + "HostId", StringUtils.FromString(publicRequest.Placement.HostId));
                    }
                    if(publicRequest.Placement.IsSetHostResourceGroupArn())
                    {
                        request.Parameters.Add("Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequest.Placement.HostResourceGroupArn));
                    }
                    if(publicRequest.Placement.IsSetPartitionNumber())
                    {
                        request.Parameters.Add("Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequest.Placement.PartitionNumber));
                    }
                    if(publicRequest.Placement.IsSetSpreadDomain())
                    {
                        request.Parameters.Add("Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequest.Placement.SpreadDomain));
                    }
                    if(publicRequest.Placement.IsSetTenancy())
                    {
                        request.Parameters.Add("Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.Placement.Tenancy));
                    }
                }
                if(publicRequest.IsSetPrivateDnsNameOptions())
                {
                    if(publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsAAAARecord())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsAAAARecord));
                    }
                    if(publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsARecord())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsARecord));
                    }
                    if(publicRequest.PrivateDnsNameOptions.IsSetHostnameType())
                    {
                        request.Parameters.Add("PrivateDnsNameOptions" + "." + "HostnameType", StringUtils.FromString(publicRequest.PrivateDnsNameOptions.HostnameType));
                    }
                }
                if(publicRequest.IsSetPrivateIpAddress())
                {
                    request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
                }
                if(publicRequest.IsSetRamdiskId())
                {
                    request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    if (publicRequest.SecurityGroupIds.Count == 0)
                        request.Parameters.Add("SecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                         {
                             request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSecurityGroups())
                {
                    if (publicRequest.SecurityGroups.Count == 0)
                        request.Parameters.Add("SecurityGroup", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                         {
                             request.Parameters.Add("SecurityGroup" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSubnetId())
                {
                    request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUserData())
                {
                    request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
                }
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