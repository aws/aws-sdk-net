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
    /// RunInstances Request Marshaller
    /// </summary>
    public partial class RunInstancesRequestMarshaller : IMarshaller<IRequest, RunInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RunInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "RunInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAdditionalInfo())
            {
                request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
            }
            if (publicRequest.IsSetBlockDeviceMappings())
            {
                if (publicRequest.BlockDeviceMappings.Count == 0)
                {
                    request.Parameters.Add("BlockDeviceMapping", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BlockDeviceMappings)
                    {
                        if (item0.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".DeviceName", StringUtils.FromString(item0.DeviceName));
                        }
                        if (item0.IsSetEbs())
                        {
                            if (item0.Ebs.IsSetAvailabilityZone())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".AvailabilityZone", StringUtils.FromString(item0.Ebs.AvailabilityZone));
                            }
                            if (item0.Ebs.IsSetAvailabilityZoneId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".AvailabilityZoneId", StringUtils.FromString(item0.Ebs.AvailabilityZoneId));
                            }
                            if (item0.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item0.Ebs.DeleteOnTermination.Value));
                            }
                            if (item0.Ebs.IsSetEbsCardIndex())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".EbsCardIndex", StringUtils.FromInt(item0.Ebs.EbsCardIndex.Value));
                            }
                            if (item0.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item0.Ebs.Encrypted.Value));
                            }
                            if (item0.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Iops", StringUtils.FromInt(item0.Ebs.Iops.Value));
                            }
                            if (item0.Ebs.IsSetKmsKeyId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".KmsKeyId", StringUtils.FromString(item0.Ebs.KmsKeyId));
                            }
                            if (item0.Ebs.IsSetOutpostArn())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".OutpostArn", StringUtils.FromString(item0.Ebs.OutpostArn));
                            }
                            if (item0.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item0.Ebs.SnapshotId));
                            }
                            if (item0.Ebs.IsSetThroughput())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".Throughput", StringUtils.FromInt(item0.Ebs.Throughput.Value));
                            }
                            if (item0.Ebs.IsSetVolumeInitializationRate())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeInitializationRate", StringUtils.FromInt(item0.Ebs.VolumeInitializationRate.Value));
                            }
                            if (item0.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item0.Ebs.VolumeSize.Value));
                            }
                            if (item0.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeType", StringUtils.FromString(item0.Ebs.VolumeType));
                            }
                        }
                        if (item0.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".NoDevice", StringUtils.FromString(item0.NoDevice));
                        }
                        if (item0.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".VirtualName", StringUtils.FromString(item0.VirtualName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetCapacityReservationSpecification())
            {
                if (publicRequest.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                {
                    request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationPreference", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationPreference));
                }
                if (publicRequest.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                {
                    if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                    {
                        request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationId", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                    }
                    if (publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                    {
                        request.Parameters.Add("CapacityReservationSpecification" + ".CapacityReservationTarget" + ".CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                    }
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
            if (publicRequest.IsSetCpuOptions())
            {
                if (publicRequest.CpuOptions.IsSetAmdSevSnp())
                {
                    request.Parameters.Add("CpuOptions" + ".AmdSevSnp", StringUtils.FromString(publicRequest.CpuOptions.AmdSevSnp));
                }
                if (publicRequest.CpuOptions.IsSetCoreCount())
                {
                    request.Parameters.Add("CpuOptions" + ".CoreCount", StringUtils.FromInt(publicRequest.CpuOptions.CoreCount.Value));
                }
                if (publicRequest.CpuOptions.IsSetNestedVirtualization())
                {
                    request.Parameters.Add("CpuOptions" + ".NestedVirtualization", StringUtils.FromString(publicRequest.CpuOptions.NestedVirtualization));
                }
                if (publicRequest.CpuOptions.IsSetThreadsPerCore())
                {
                    request.Parameters.Add("CpuOptions" + ".ThreadsPerCore", StringUtils.FromInt(publicRequest.CpuOptions.ThreadsPerCore.Value));
                }
            }
            if (publicRequest.IsSetCreditSpecification())
            {
                if (publicRequest.CreditSpecification.IsSetCpuCredits())
                {
                    request.Parameters.Add("CreditSpecification" + ".CpuCredits", StringUtils.FromString(publicRequest.CreditSpecification.CpuCredits));
                }
            }
            if (publicRequest.IsSetDisableApiStop())
            {
                request.Parameters.Add("DisableApiStop", StringUtils.FromBool(publicRequest.DisableApiStop.Value));
            }
            if (publicRequest.IsSetDisableApiTermination())
            {
                request.Parameters.Add("DisableApiTermination", StringUtils.FromBool(publicRequest.DisableApiTermination.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized.Value));
            }
            if (publicRequest.IsSetElasticGpuSpecification())
            {
                if (publicRequest.ElasticGpuSpecification.Count == 0)
                {
                    request.Parameters.Add("ElasticGpuSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ElasticGpuSpecification)
                    {
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("ElasticGpuSpecification" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetElasticInferenceAccelerators())
            {
                if (publicRequest.ElasticInferenceAccelerators.Count == 0)
                {
                    request.Parameters.Add("ElasticInferenceAccelerator", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ElasticInferenceAccelerators)
                    {
                        if (item0.IsSetCount())
                        {
                            request.Parameters.Add("ElasticInferenceAccelerator" + "." + index0 + ".Count", StringUtils.FromInt(item0.Count.Value));
                        }
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("ElasticInferenceAccelerator" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetEnablePrimaryIpv6())
            {
                request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6.Value));
            }
            if (publicRequest.IsSetEnclaveOptions())
            {
                if (publicRequest.EnclaveOptions.IsSetEnabled())
                {
                    request.Parameters.Add("EnclaveOptions" + ".Enabled", StringUtils.FromBool(publicRequest.EnclaveOptions.Enabled.Value));
                }
            }
            if (publicRequest.IsSetHibernationOptions())
            {
                if (publicRequest.HibernationOptions.IsSetConfigured())
                {
                    request.Parameters.Add("HibernationOptions" + ".Configured", StringUtils.FromBool(publicRequest.HibernationOptions.Configured.Value));
                }
            }
            if (publicRequest.IsSetIamInstanceProfile())
            {
                if (publicRequest.IamInstanceProfile.IsSetArn())
                {
                    request.Parameters.Add("IamInstanceProfile" + ".Arn", StringUtils.FromString(publicRequest.IamInstanceProfile.Arn));
                }
                if (publicRequest.IamInstanceProfile.IsSetName())
                {
                    request.Parameters.Add("IamInstanceProfile" + ".Name", StringUtils.FromString(publicRequest.IamInstanceProfile.Name));
                }
            }
            if (publicRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
            }
            if (publicRequest.IsSetInstanceInitiatedShutdownBehavior())
            {
                request.Parameters.Add("InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
            }
            if (publicRequest.IsSetInstanceMarketOptions())
            {
                if (publicRequest.InstanceMarketOptions.IsSetMarketType())
                {
                    request.Parameters.Add("InstanceMarketOptions" + ".MarketType", StringUtils.FromString(publicRequest.InstanceMarketOptions.MarketType));
                }
                if (publicRequest.InstanceMarketOptions.IsSetSpotOptions())
                {
                    if (publicRequest.InstanceMarketOptions.SpotOptions.IsSetBlockDurationMinutes())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + ".SpotOptions" + ".BlockDurationMinutes", StringUtils.FromInt(publicRequest.InstanceMarketOptions.SpotOptions.BlockDurationMinutes.Value));
                    }
                    if (publicRequest.InstanceMarketOptions.SpotOptions.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + ".SpotOptions" + ".InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.InstanceInterruptionBehavior));
                    }
                    if (publicRequest.InstanceMarketOptions.SpotOptions.IsSetMaxPrice())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + ".SpotOptions" + ".MaxPrice", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.MaxPrice));
                    }
                    if (publicRequest.InstanceMarketOptions.SpotOptions.IsSetSpotInstanceType())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + ".SpotOptions" + ".SpotInstanceType", StringUtils.FromString(publicRequest.InstanceMarketOptions.SpotOptions.SpotInstanceType));
                    }
                    if (publicRequest.InstanceMarketOptions.SpotOptions.IsSetValidUntil())
                    {
                        request.Parameters.Add("InstanceMarketOptions" + ".SpotOptions" + ".ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.InstanceMarketOptions.SpotOptions.ValidUntil.Value));
                    }
                }
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetIpv6AddressCount())
            {
                request.Parameters.Add("Ipv6AddressCount", StringUtils.FromInt(publicRequest.Ipv6AddressCount.Value));
            }
            if (publicRequest.IsSetIpv6Addresses())
            {
                if (publicRequest.Ipv6Addresses.Count == 0)
                {
                    request.Parameters.Add("Ipv6Address", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Ipv6Addresses)
                    {
                        if (item0.IsSetIpv6Address())
                        {
                            request.Parameters.Add("Ipv6Address" + "." + index0 + ".Ipv6Address", StringUtils.FromString(item0.Ipv6Address));
                        }
                        if (item0.IsSetIsPrimaryIpv6())
                        {
                            request.Parameters.Add("Ipv6Address" + "." + index0 + ".IsPrimaryIpv6", StringUtils.FromBool(item0.IsPrimaryIpv6.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetKernelId())
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
            }
            if (publicRequest.IsSetKeyName())
            {
                request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
            }
            if (publicRequest.IsSetLaunchTemplate())
            {
                if (publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                {
                    request.Parameters.Add("LaunchTemplate" + ".LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                }
                if (publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                {
                    request.Parameters.Add("LaunchTemplate" + ".LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                }
                if (publicRequest.LaunchTemplate.IsSetVersion())
                {
                    request.Parameters.Add("LaunchTemplate" + ".Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                }
            }
            if (publicRequest.IsSetLicenseSpecifications())
            {
                if (publicRequest.LicenseSpecifications.Count == 0)
                {
                    request.Parameters.Add("LicenseSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.LicenseSpecifications)
                    {
                        if (item0.IsSetLicenseConfigurationArn())
                        {
                            request.Parameters.Add("LicenseSpecification" + "." + index0 + ".LicenseConfigurationArn", StringUtils.FromString(item0.LicenseConfigurationArn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMaintenanceOptions())
            {
                if (publicRequest.MaintenanceOptions.IsSetAutoRecovery())
                {
                    request.Parameters.Add("MaintenanceOptions" + ".AutoRecovery", StringUtils.FromString(publicRequest.MaintenanceOptions.AutoRecovery));
                }
            }
            if (publicRequest.IsSetMaxCount())
            {
                request.Parameters.Add("MaxCount", StringUtils.FromInt(publicRequest.MaxCount.Value));
            }
            if (publicRequest.IsSetMetadataOptions())
            {
                if (publicRequest.MetadataOptions.IsSetHttpEndpoint())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpEndpoint", StringUtils.FromString(publicRequest.MetadataOptions.HttpEndpoint));
                }
                if (publicRequest.MetadataOptions.IsSetHttpProtocolIpv6())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpProtocolIpv6", StringUtils.FromString(publicRequest.MetadataOptions.HttpProtocolIpv6));
                }
                if (publicRequest.MetadataOptions.IsSetHttpPutResponseHopLimit())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.MetadataOptions.HttpPutResponseHopLimit.Value));
                }
                if (publicRequest.MetadataOptions.IsSetHttpTokens())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpTokens", StringUtils.FromString(publicRequest.MetadataOptions.HttpTokens));
                }
                if (publicRequest.MetadataOptions.IsSetInstanceMetadataTags())
                {
                    request.Parameters.Add("MetadataOptions" + ".InstanceMetadataTags", StringUtils.FromString(publicRequest.MetadataOptions.InstanceMetadataTags));
                }
            }
            if (publicRequest.IsSetMinCount())
            {
                request.Parameters.Add("MinCount", StringUtils.FromInt(publicRequest.MinCount.Value));
            }
            if (publicRequest.IsSetMonitoring())
            {
                request.Parameters.Add("Monitoring.Enabled", StringUtils.FromBool(publicRequest.Monitoring.Value));
            }
            if (publicRequest.IsSetNetworkInterfaces())
            {
                if (publicRequest.NetworkInterfaces.Count == 0)
                {
                    request.Parameters.Add("NetworkInterface", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NetworkInterfaces)
                    {
                        if (item0.IsSetAssociateCarrierIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".AssociateCarrierIpAddress", StringUtils.FromBool(item0.AssociateCarrierIpAddress.Value));
                        }
                        if (item0.IsSetAssociatePublicIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".AssociatePublicIpAddress", StringUtils.FromBool(item0.AssociatePublicIpAddress.Value));
                        }
                        if (item0.IsSetConnectionTrackingSpecification())
                        {
                            if (item0.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".ConnectionTrackingSpecification" + ".TcpEstablishedTimeout", StringUtils.FromInt(item0.ConnectionTrackingSpecification.TcpEstablishedTimeout.Value));
                            }
                            if (item0.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".ConnectionTrackingSpecification" + ".UdpStreamTimeout", StringUtils.FromInt(item0.ConnectionTrackingSpecification.UdpStreamTimeout.Value));
                            }
                            if (item0.ConnectionTrackingSpecification.IsSetUdpTimeout())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".ConnectionTrackingSpecification" + ".UdpTimeout", StringUtils.FromInt(item0.ConnectionTrackingSpecification.UdpTimeout.Value));
                            }
                        }
                        if (item0.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".DeleteOnTermination", StringUtils.FromBool(item0.DeleteOnTermination.Value));
                        }
                        if (item0.IsSetDescription())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".Description", StringUtils.FromString(item0.Description));
                        }
                        if (item0.IsSetDeviceIndex())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".DeviceIndex", StringUtils.FromInt(item0.DeviceIndex.Value));
                        }
                        if (item0.IsSetEnaQueueCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".EnaQueueCount", StringUtils.FromInt(item0.EnaQueueCount.Value));
                        }
                        if (item0.IsSetEnaSrdSpecification())
                        {
                            if (item0.EnaSrdSpecification.IsSetEnaSrdEnabled())
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".EnaSrdSpecification" + ".EnaSrdEnabled", StringUtils.FromBool(item0.EnaSrdSpecification.EnaSrdEnabled.Value));
                            }
                            if (item0.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                            {
                                if (item0.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + index0 + ".EnaSrdSpecification" + ".EnaSrdUdpSpecification" + ".EnaSrdUdpEnabled", StringUtils.FromBool(item0.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled.Value));
                                }
                            }
                        }
                        if (item0.IsSetGroups())
                        {
                            if (item0.Groups.Count == 0)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".SecurityGroupId", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Groups)
                                {
                                    request.Parameters.Add("NetworkInterface" + "." + index0 + ".SecurityGroupId" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetInterfaceType())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".InterfaceType", StringUtils.FromString(item0.InterfaceType));
                        }
                        if (item0.IsSetIpv4PrefixCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv4PrefixCount", StringUtils.FromInt(item0.Ipv4PrefixCount.Value));
                        }
                        if (item0.IsSetIpv4Prefixes())
                        {
                            if (item0.Ipv4Prefixes.Count == 0)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv4Prefix", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Ipv4Prefixes)
                                {
                                    if (item1.IsSetIpv4Prefix())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv4Prefix" + "." + index1 + ".Ipv4Prefix", StringUtils.FromString(item1.Ipv4Prefix));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetIpv6AddressCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6AddressCount", StringUtils.FromInt(item0.Ipv6AddressCount.Value));
                        }
                        if (item0.IsSetIpv6Addresses())
                        {
                            if (item0.Ipv6Addresses.Count == 0)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6Addresses", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Ipv6Addresses)
                                {
                                    if (item1.IsSetIpv6Address())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6Addresses" + "." + index1 + ".Ipv6Address", StringUtils.FromString(item1.Ipv6Address));
                                    }
                                    if (item1.IsSetIsPrimaryIpv6())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6Addresses" + "." + index1 + ".IsPrimaryIpv6", StringUtils.FromBool(item1.IsPrimaryIpv6.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetIpv6PrefixCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6PrefixCount", StringUtils.FromInt(item0.Ipv6PrefixCount.Value));
                        }
                        if (item0.IsSetIpv6Prefixes())
                        {
                            if (item0.Ipv6Prefixes.Count == 0)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6Prefix", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Ipv6Prefixes)
                                {
                                    if (item1.IsSetIpv6Prefix())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".Ipv6Prefix" + "." + index1 + ".Ipv6Prefix", StringUtils.FromString(item1.Ipv6Prefix));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetNetworkCardIndex())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".NetworkCardIndex", StringUtils.FromInt(item0.NetworkCardIndex.Value));
                        }
                        if (item0.IsSetNetworkInterfaceId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".NetworkInterfaceId", StringUtils.FromString(item0.NetworkInterfaceId));
                        }
                        if (item0.IsSetPrimaryIpv6())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".PrimaryIpv6", StringUtils.FromBool(item0.PrimaryIpv6.Value));
                        }
                        if (item0.IsSetPrivateIpAddress())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".PrivateIpAddress", StringUtils.FromString(item0.PrivateIpAddress));
                        }
                        if (item0.IsSetPrivateIpAddresses())
                        {
                            if (item0.PrivateIpAddresses.Count == 0)
                            {
                                request.Parameters.Add("NetworkInterface" + "." + index0 + ".PrivateIpAddresses", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.PrivateIpAddresses)
                                {
                                    if (item1.IsSetPrimary())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".PrivateIpAddresses" + "." + index1 + ".Primary", StringUtils.FromBool(item1.Primary.Value));
                                    }
                                    if (item1.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("NetworkInterface" + "." + index0 + ".PrivateIpAddresses" + "." + index1 + ".PrivateIpAddress", StringUtils.FromString(item1.PrivateIpAddress));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetSecondaryPrivateIpAddressCount())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".SecondaryPrivateIpAddressCount", StringUtils.FromInt(item0.SecondaryPrivateIpAddressCount.Value));
                        }
                        if (item0.IsSetSubnetId())
                        {
                            request.Parameters.Add("NetworkInterface" + "." + index0 + ".SubnetId", StringUtils.FromString(item0.SubnetId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNetworkPerformanceOptions())
            {
                if (publicRequest.NetworkPerformanceOptions.IsSetBandwidthWeighting())
                {
                    request.Parameters.Add("NetworkPerformanceOptions" + ".BandwidthWeighting", StringUtils.FromString(publicRequest.NetworkPerformanceOptions.BandwidthWeighting));
                }
            }
            if (publicRequest.IsSetOperator())
            {
                if (publicRequest.Operator.IsSetPrincipal())
                {
                    request.Parameters.Add("Operator" + ".Principal", StringUtils.FromString(publicRequest.Operator.Principal));
                }
            }
            if (publicRequest.IsSetPlacement())
            {
                if (publicRequest.Placement.IsSetAffinity())
                {
                    request.Parameters.Add("Placement" + ".Affinity", StringUtils.FromString(publicRequest.Placement.Affinity));
                }
                if (publicRequest.Placement.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("Placement" + ".AvailabilityZone", StringUtils.FromString(publicRequest.Placement.AvailabilityZone));
                }
                if (publicRequest.Placement.IsSetAvailabilityZoneId())
                {
                    request.Parameters.Add("Placement" + ".AvailabilityZoneId", StringUtils.FromString(publicRequest.Placement.AvailabilityZoneId));
                }
                if (publicRequest.Placement.IsSetGroupId())
                {
                    request.Parameters.Add("Placement" + ".GroupId", StringUtils.FromString(publicRequest.Placement.GroupId));
                }
                if (publicRequest.Placement.IsSetGroupName())
                {
                    request.Parameters.Add("Placement" + ".GroupName", StringUtils.FromString(publicRequest.Placement.GroupName));
                }
                if (publicRequest.Placement.IsSetHostId())
                {
                    request.Parameters.Add("Placement" + ".HostId", StringUtils.FromString(publicRequest.Placement.HostId));
                }
                if (publicRequest.Placement.IsSetHostResourceGroupArn())
                {
                    request.Parameters.Add("Placement" + ".HostResourceGroupArn", StringUtils.FromString(publicRequest.Placement.HostResourceGroupArn));
                }
                if (publicRequest.Placement.IsSetPartitionNumber())
                {
                    request.Parameters.Add("Placement" + ".PartitionNumber", StringUtils.FromInt(publicRequest.Placement.PartitionNumber.Value));
                }
                if (publicRequest.Placement.IsSetSpreadDomain())
                {
                    request.Parameters.Add("Placement" + ".SpreadDomain", StringUtils.FromString(publicRequest.Placement.SpreadDomain));
                }
                if (publicRequest.Placement.IsSetTenancy())
                {
                    request.Parameters.Add("Placement" + ".Tenancy", StringUtils.FromString(publicRequest.Placement.Tenancy));
                }
            }
            if (publicRequest.IsSetPrivateDnsNameOptions())
            {
                if (publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsAAAARecord())
                {
                    request.Parameters.Add("PrivateDnsNameOptions" + ".EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsAAAARecord.Value));
                }
                if (publicRequest.PrivateDnsNameOptions.IsSetEnableResourceNameDnsARecord())
                {
                    request.Parameters.Add("PrivateDnsNameOptions" + ".EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.PrivateDnsNameOptions.EnableResourceNameDnsARecord.Value));
                }
                if (publicRequest.PrivateDnsNameOptions.IsSetHostnameType())
                {
                    request.Parameters.Add("PrivateDnsNameOptions" + ".HostnameType", StringUtils.FromString(publicRequest.PrivateDnsNameOptions.HostnameType));
                }
            }
            if (publicRequest.IsSetPrivateIpAddress())
            {
                request.Parameters.Add("PrivateIpAddress", StringUtils.FromString(publicRequest.PrivateIpAddress));
            }
            if (publicRequest.IsSetRamdiskId())
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
            }
            if (publicRequest.IsSetSecondaryInterfaces())
            {
                if (publicRequest.SecondaryInterfaces.Count == 0)
                {
                    request.Parameters.Add("SecondaryInterface", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecondaryInterfaces)
                    {
                        if (item0.IsSetDeleteOnTermination())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".DeleteOnTermination", StringUtils.FromBool(item0.DeleteOnTermination.Value));
                        }
                        if (item0.IsSetDeviceIndex())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".DeviceIndex", StringUtils.FromInt(item0.DeviceIndex.Value));
                        }
                        if (item0.IsSetInterfaceType())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".InterfaceType", StringUtils.FromString(item0.InterfaceType));
                        }
                        if (item0.IsSetNetworkCardIndex())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".NetworkCardIndex", StringUtils.FromInt(item0.NetworkCardIndex.Value));
                        }
                        if (item0.IsSetPrivateIpAddressCount())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".PrivateIpAddressCount", StringUtils.FromInt(item0.PrivateIpAddressCount.Value));
                        }
                        if (item0.IsSetPrivateIpAddresses())
                        {
                            if (item0.PrivateIpAddresses.Count == 0)
                            {
                                request.Parameters.Add("SecondaryInterface" + "." + index0 + ".PrivateIpAddress", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.PrivateIpAddresses)
                                {
                                    if (item1.IsSetPrivateIpAddress())
                                    {
                                        request.Parameters.Add("SecondaryInterface" + "." + index0 + ".PrivateIpAddress" + "." + index1 + ".PrivateIpAddress", StringUtils.FromString(item1.PrivateIpAddress));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetSecondarySubnetId())
                        {
                            request.Parameters.Add("SecondaryInterface" + "." + index0 + ".SecondarySubnetId", StringUtils.FromString(item0.SecondarySubnetId));
                        }
                        index0++;
                    }
                }
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
            if (publicRequest.IsSetSecurityGroups())
            {
                if (publicRequest.SecurityGroups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroup", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroup" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
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
            if (publicRequest.IsSetUserData())
            {
                request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly RunInstancesRequestMarshaller _instance = new();

        internal static RunInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RunInstancesRequestMarshaller Instance => _instance;
    }
}
